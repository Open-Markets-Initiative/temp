using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrument Event Grp Comp Message Methods
    /// </summary>

    public partial class InstrumentEventGrpComp
    {
        /// <summary>
        ///  Length of Instrument Event Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Instrument Event Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, InstrumentEventGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode instrument event grp comp ---

            if (!message.TryGetGroup(InstrumentEventGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(InstrumentEventGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode instrument event grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode instrument event grp comp group ---

            message.AppendInt(InstrumentEventGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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