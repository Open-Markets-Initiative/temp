using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Side Alloc Grp Bc Comp Message Methods
    /// </summary>

    public partial class SideAllocGrpBcComp
    {
        /// <summary>
        ///  Length of Side Alloc Grp Bc Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Side Alloc Grp Bc Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode side alloc grp bc comp ---

            if (!message.TryGetGroup(SideAllocGrpBcComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SideAllocGrpBcComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var allocQty = group.GetDouble(AllocQty.FixTag);
                AllocQty.Encode(pointer, current, allocQty, out current);

                var reversalApprovalTime = group.GetULong(ReversalApprovalTime.FixTag);
                ReversalApprovalTime.Encode(pointer, current, reversalApprovalTime, out current);

                var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
                IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

                var tesEnrichmentRuleId = (uint)group.GetInt(TesEnrichmentRuleId.FixTag);
                TesEnrichmentRuleId.Encode(pointer, current, tesEnrichmentRuleId, out current);

                if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
                {
                    PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
                }
                else
                {
                    PartyExecutingFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
                {
                    PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
                }
                else
                {
                    PartyExecutingTrader.SetNull(pointer, current, out current);
                }

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                var tradeAllocStatus = (byte)group.GetInt(TradeAllocStatus.FixTag);
                TradeAllocStatus.Encode(pointer, current, tradeAllocStatus, out current);

                Pad3.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Side Alloc Grp Bc Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            var allocQty = AllocQty.Decode(pointer, current, out current);
            message.AppendDouble(AllocQty.FixTag, allocQty);

            var reversalApprovalTime = ReversalApprovalTime.Decode(pointer, current, out current);
            message.AppendULong(ReversalApprovalTime.FixTag, reversalApprovalTime);

            var individualAllocId = (int)IndividualAllocId.Decode(pointer, current, out current);
            message.AppendInt(IndividualAllocId.FixTag, individualAllocId);

            var tesEnrichmentRuleId = (int)TesEnrichmentRuleId.Decode(pointer, current, out current);
            message.AppendInt(TesEnrichmentRuleId.FixTag, tesEnrichmentRuleId);

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var tradeAllocStatus = TradeAllocStatus.Decode(pointer, current, out current);
            message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);

            current += Pad3.Length;

        }
    }
}