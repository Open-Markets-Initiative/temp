using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Side Alloc Grp Comp Message Methods
    /// </summary>

    public static partial class BasketSideAllocGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Side Alloc Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39105;

        /// <summary>
        ///  Encode Basket Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup basketSideAllocGrpComp, out int current)
        {
            current = offset;

            foreach (var group in basketSideAllocGrpComp.sectionList)
            {
                var allocQty = group.GetDouble(AllocQty.FixTag);
                AllocQty.Encode(pointer, current, allocQty, out current);

                var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
                IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

                var partySubIdType = (ushort)group.GetInt(PartySubIdType.FixTag);
                PartySubIdType.Encode(pointer, current, partySubIdType, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                var instrmtMatchSideId = (byte)group.GetInt(InstrmtMatchSideId.FixTag);
                InstrmtMatchSideId.Encode(pointer, current, instrmtMatchSideId, out current);

                var tradeAllocStatus = (byte)group.GetInt(TradeAllocStatus.FixTag);
                TradeAllocStatus.Encode(pointer, current, tradeAllocStatus, out current);

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
        ///  Decode Basket Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoBasketSideAlloc.FixTag, count);

            while (count-- > 0)
            {
                var allocQty = AllocQty.Decode(pointer, current, out current);
                message.AppendDouble(AllocQty.FixTag, allocQty);

                var individualAllocId = (int)IndividualAllocId.Decode(pointer, current, out current);
                message.AppendInt(IndividualAllocId.FixTag, individualAllocId);

                var partySubIdType = (short)PartySubIdType.Decode(pointer, current, out current);
                message.AppendInt(PartySubIdType.FixTag, partySubIdType);

                var side = Side.Decode(pointer, current, out current);
                message.AppendInt(Side.FixTag, side);

                var instrmtMatchSideId = InstrmtMatchSideId.Decode(pointer, current, out current);
                message.AppendInt(InstrmtMatchSideId.FixTag, instrmtMatchSideId);

                var tradeAllocStatus = TradeAllocStatus.Decode(pointer, current, out current);
                message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);

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