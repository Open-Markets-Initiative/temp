using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Alloc Grp Comp Message Methods
    /// </summary>

    public static partial class SideAllocGrpComp
    {
        /// <summary>
        ///  Fix Tag for Side Alloc Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39139;

        /// <summary>
        ///  Encode Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup sideAllocGrpComp, out int current)
        {
            current = offset;

            foreach (var group in sideAllocGrpComp.sectionList)
            {
                var allocQty = group.GetDouble(AllocQty.FixTag);
                AllocQty.Encode(pointer, current, allocQty, out current);

                var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
                IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

                var tesEnrichmentRuleId = (uint)group.GetInt(TesEnrichmentRuleId.FixTag);
                TesEnrichmentRuleId.Encode(pointer, current, tesEnrichmentRuleId, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

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

                Pad4.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoSideAllocs.FixTag, count);

            while (count-- > 0)
            {
                var allocQty = AllocQty.Decode(pointer, current, out current);
                message.AppendDouble(AllocQty.FixTag, allocQty);

                var individualAllocId = (int)IndividualAllocId.Decode(pointer, current, out current);
                message.AppendInt(IndividualAllocId.FixTag, individualAllocId);

                var tesEnrichmentRuleId = (int)TesEnrichmentRuleId.Decode(pointer, current, out current);
                message.AppendInt(TesEnrichmentRuleId.FixTag, tesEnrichmentRuleId);

                var side = Side.Decode(pointer, current, out current);
                message.AppendInt(Side.FixTag, side);

                if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
                {
                    message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
                }

                if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
                {
                    message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
                }

                current += Pad4.Length;

            }
        }
    }
}