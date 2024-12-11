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
                if (group.TryGetDouble(AllocQty.FixTag, out var allocQty))
                {
                    AllocQty.Encode(pointer, current, allocQty, out current);
                }
                else
                {
                    AllocQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(IndividualAllocId.FixTag, out var individualAllocId))
                {
                    IndividualAllocId.Encode(pointer, current, (uint)individualAllocId, out current);
                }
                else
                {
                    IndividualAllocId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(PartySubIdType.FixTag, out var partySubIdType))
                {
                    PartySubIdType.Encode(pointer, current, (ushort)partySubIdType, out current);
                }
                else
                {
                    PartySubIdType.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(InstrmtMatchSideId.FixTag, out var instrmtMatchSideId))
                {
                    InstrmtMatchSideId.Encode(pointer, current, (byte)instrmtMatchSideId, out current);
                }
                else
                {
                    InstrmtMatchSideId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradeAllocStatus.FixTag, out var tradeAllocStatus))
                {
                    TradeAllocStatus.Encode(pointer, current, (byte)tradeAllocStatus, out current);
                }
                else
                {
                    TradeAllocStatus.SetNull(pointer, current, out current);
                }

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
                if (AllocQty.TryDecode(pointer, current, out var allocQty, out current))
                {
                    message.AppendDouble(AllocQty.FixTag, allocQty);
                }

                if (IndividualAllocId.TryDecode(pointer, current, out var individualAllocId, out current))
                {
                    message.AppendInt(IndividualAllocId.FixTag, (int)individualAllocId);
                }

                if (PartySubIdType.TryDecode(pointer, current, out var partySubIdType, out current))
                {
                    message.AppendInt(PartySubIdType.FixTag, (short)partySubIdType);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                if (InstrmtMatchSideId.TryDecode(pointer, current, out var instrmtMatchSideId, out current))
                {
                    message.AppendInt(InstrmtMatchSideId.FixTag, instrmtMatchSideId);
                }

                if (TradeAllocStatus.TryDecode(pointer, current, out var tradeAllocStatus, out current))
                {
                    message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);
                }

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