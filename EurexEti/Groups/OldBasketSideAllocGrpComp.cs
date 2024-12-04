using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Old Basket Side Alloc Grp Comp Message Methods
    /// </summary>

    public partial class OldBasketSideAllocGrpComp
    {
        /// <summary>
        ///  Fix Tag for Old Basket Side Alloc Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39122;

        /// <summary>
        ///  Length of Old Basket Side Alloc Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Old Basket Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode old basket side alloc grp comp ---

            if (!message.TryGetGroup(OldBasketSideAllocGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(OldBasketSideAllocGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var allocQty = group.GetDouble(AllocQty.FixTag);
                AllocQty.Encode(pointer, current, allocQty, out current);

                var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
                IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

                var partySubIdType = (ushort)group.GetInt(PartySubIdType.FixTag);
                PartySubIdType.Encode(pointer, current, partySubIdType, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                var positionEffect = group.GetToken(PositionEffect.FixTag);
                PositionEffect.Encode(pointer, current, positionEffect, out current);

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

                Pad3.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Old Basket Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            OldBasketSideAllocGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}