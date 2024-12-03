using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrument Attribute Grp Comp Message Methods
    /// </summary>

    public partial class InstrumentAttributeGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrument Attribute Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39113;

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

            // --- TODO ---

            InstrumentAttributeGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}