using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Instrument Attribute Grp Comp Message Methods
    /// </summary>

    public partial static class InstrumentAttributeGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrument Attribute Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39113;

        /// <summary>
        ///  Encode Instrument Attribute Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int instrumentAttributeGrpComp, out int current)
        {
            current = offset;

            foreach (var group in instrumentAttributeGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noInstrAttrib.FixTag, count);

            while (count--)
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