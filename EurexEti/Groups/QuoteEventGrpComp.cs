using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Event Grp Comp Message Methods
    /// </summary>

    public partial class QuoteEventGrpComp
    {
        /// <summary>
        ///  Length of Quote Event Grp Comp in bytes
        /// </summary>
        public const int Length = 48;

        /// <summary>
        ///  Encode Quote Event Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, QuoteEventGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode quote event grp comp ---

            if (!message.TryGetGroup(QuoteEventGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(QuoteEventGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var quoteEventPx = group.GetDouble(QuoteEventPx.FixTag);
                QuoteEventPx.Encode(pointer, current, quoteEventPx, out current);

                var quoteEventQty = group.GetDouble(QuoteEventQty.FixTag);
                QuoteEventQty.Encode(pointer, current, quoteEventQty, out current);

                var quoteMsgId = group.GetULong(QuoteMsgId.FixTag);
                QuoteMsgId.Encode(pointer, current, quoteMsgId, out current);

                var quoteEventMatchId = (uint)group.GetInt(QuoteEventMatchId.FixTag);
                QuoteEventMatchId.Encode(pointer, current, quoteEventMatchId, out current);

                var quoteEventExecId = group.GetInt(QuoteEventExecId.FixTag);
                QuoteEventExecId.Encode(pointer, current, quoteEventExecId, out current);

                var quoteEventType = (byte)group.GetInt(QuoteEventType.FixTag);
                QuoteEventType.Encode(pointer, current, quoteEventType, out current);

                var quoteEventSide = (byte)group.GetInt(QuoteEventSide.FixTag);
                QuoteEventSide.Encode(pointer, current, quoteEventSide, out current);

                var quoteEventLiquidityInd = (byte)group.GetInt(QuoteEventLiquidityInd.FixTag);
                QuoteEventLiquidityInd.Encode(pointer, current, quoteEventLiquidityInd, out current);

                var quoteEventReason = (byte)group.GetInt(QuoteEventReason.FixTag);
                QuoteEventReason.Encode(pointer, current, quoteEventReason, out current);

                Pad4.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Quote Event Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode quote event grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode quote event grp comp group ---

            message.AppendInt(QuoteEventGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var quoteEventPx = QuoteEventPx.Decode(pointer, current, out current);
                message.AppendDouble(QuoteEventPx.FixTag, quoteEventPx);

                var quoteEventQty = QuoteEventQty.Decode(pointer, current, out current);
                message.AppendDouble(QuoteEventQty.FixTag, quoteEventQty);

                var quoteMsgId = QuoteMsgId.Decode(pointer, current, out current);
                message.AppendULong(QuoteMsgId.FixTag, quoteMsgId);

                var quoteEventMatchId = (int)QuoteEventMatchId.Decode(pointer, current, out current);
                message.AppendInt(QuoteEventMatchId.FixTag, quoteEventMatchId);

                var quoteEventExecId = QuoteEventExecId.Decode(pointer, current, out current);
                message.AppendInt(QuoteEventExecId.FixTag, quoteEventExecId);

                var quoteEventType = QuoteEventType.Decode(pointer, current, out current);
                message.AppendInt(QuoteEventType.FixTag, quoteEventType);

                var quoteEventSide = QuoteEventSide.Decode(pointer, current, out current);
                message.AppendInt(QuoteEventSide.FixTag, quoteEventSide);

                var quoteEventLiquidityInd = QuoteEventLiquidityInd.Decode(pointer, current, out current);
                message.AppendInt(QuoteEventLiquidityInd.FixTag, quoteEventLiquidityInd);

                var quoteEventReason = QuoteEventReason.Decode(pointer, current, out current);
                message.AppendInt(QuoteEventReason.FixTag, quoteEventReason);

                current += Pad4.Length;

            }
        }
    }
}