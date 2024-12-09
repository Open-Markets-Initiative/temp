using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Instrument Event Grp Comp Message Methods
    /// </summary>

    public static partial class InstrumentEventGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrument Event Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39114;

        /// <summary>
        ///  Encode Instrument Event Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup instrumentEventGrpComp, out int current)
        {
            current = offset;

            foreach (var group in instrumentEventGrpComp.sectionList)
            {
                var eventDate = (uint)group.GetInt(EventDate.FixTag);
                EventDate.Encode(pointer, current, eventDate, out current);

                var eventType = (byte)group.GetInt(EventType.FixTag);
                EventType.Encode(pointer, current, eventType, out current);

                Pad3.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Instrument Event Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noEvents.FixTag, count);

            while (count--)
            {
                var eventDate = (int)EventDate.Decode(pointer, current, out current);
                message.AppendInt(EventDate.FixTag, eventDate);

                var eventType = EventType.Decode(pointer, current, out current);
                message.AppendInt(EventType.FixTag, eventType);

                current += Pad3.Length;

            }
        }
    }
}