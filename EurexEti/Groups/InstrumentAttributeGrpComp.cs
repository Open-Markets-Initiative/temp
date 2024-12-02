using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrument Attribute Grp Comp Message Methods
    /// </summary>

    public partial class InstrumentAttributeGrpComp
    {
        /// <summary>
        ///  Length of Instrument Attribute Grp Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Instrument Attribute Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, InstrumentAttributeGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode instrument attribute grp comp ---

            if (!message.TryGetGroup(InstrumentAttributeGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(InstrumentAttributeGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var instrAttribType = (byte)group.GetInt(InstrAttribType.FixTag);
                InstrAttribType.Encode(pointer, current, instrAttribType, out current);

                if (group.TryGetString(InstrAttribValue.FixTag, out var instrAttribValue))
                {
                    InstrAttribValue.Encode(pointer, current, instrAttribValue, out current);
                }
                else
                {
                    InstrAttribValue.SetNull(pointer, current, out current);
                }

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Instrument Attribute Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode instrument attribute grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode instrument attribute grp comp group ---

            message.AppendInt(InstrumentAttributeGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var instrAttribType = InstrAttribType.Decode(pointer, current, out current);
                message.AppendInt(InstrAttribType.FixTag, instrAttribType);

                if (InstrAttribValue.TryDecode(pointer, current, out var instrAttribValue, out current))
                {
                    message.AppendString(InstrAttribValue.FixTag, instrAttribValue);
                }

                current += Pad7.Length;

            }
        }
    }
}