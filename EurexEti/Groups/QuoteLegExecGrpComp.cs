using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Leg Exec Grp Comp Message Methods
    /// </summary>

    public partial class QuoteLegExecGrpComp
    {
        /// <summary>
        ///  Fix Tag for Quote Leg Exec Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39127;

        /// <summary>
        ///  Length of Quote Leg Exec Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Quote Leg Exec Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode quote leg exec grp comp ---

            if (!message.TryGetGroup(QuoteLegExecGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(QuoteLegExecGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legLastPx = group.GetDouble(LegLastPx.FixTag);
                LegLastPx.Encode(pointer, current, legLastPx, out current);

                var legLastQty = group.GetDouble(LegLastQty.FixTag);
                LegLastQty.Encode(pointer, current, legLastQty, out current);

                var legExecId = group.GetInt(LegExecId.FixTag);
                LegExecId.Encode(pointer, current, legExecId, out current);

                var legSide = (byte)group.GetInt(LegSide.FixTag);
                LegSide.Encode(pointer, current, legSide, out current);

                var noQuoteEventsIndex = (byte)group.GetInt(NoQuoteEventsIndex.FixTag);
                NoQuoteEventsIndex.Encode(pointer, current, noQuoteEventsIndex, out current);

                Pad2.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Quote Leg Exec Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legLastPx = LegLastPx.Decode(pointer, current, out current);
            message.AppendDouble(LegLastPx.FixTag, legLastPx);

            var legLastQty = LegLastQty.Decode(pointer, current, out current);
            message.AppendDouble(LegLastQty.FixTag, legLastQty);

            var legExecId = LegExecId.Decode(pointer, current, out current);
            message.AppendInt(LegExecId.FixTag, legExecId);

            var legSide = LegSide.Decode(pointer, current, out current);
            message.AppendInt(LegSide.FixTag, legSide);

            var noQuoteEventsIndex = NoQuoteEventsIndex.Decode(pointer, current, out current);
            message.AppendInt(NoQuoteEventsIndex.FixTag, noQuoteEventsIndex);

            current += Pad2.Length;

        }
    }
}