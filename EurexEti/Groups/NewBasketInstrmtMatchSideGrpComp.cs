using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  New Basket Instrmt Match Side Grp Comp Message Methods
    /// </summary>

    public partial class NewBasketInstrmtMatchSideGrpComp
    {
        /// <summary>
        ///  Fix Tag for New Basket Instrmt Match Side Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39117;

        /// <summary>
        ///  Length of New Basket Instrmt Match Side Grp Comp in bytes
        /// </summary>
        public const int Length = 80;

        /// <summary>
        ///  Encode New Basket Instrmt Match Side Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode new basket instrmt match side grp comp ---

            if (!message.TryGetGroup(NewBasketInstrmtMatchSideGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(NewBasketInstrmtMatchSideGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var lastPx = group.GetDouble(LastPx.FixTag);
                LastPx.Encode(pointer, current, lastPx, out current);

                var transBkdTime = group.GetULong(TransBkdTime.FixTag);
                TransBkdTime.Encode(pointer, current, transBkdTime, out current);

                var relatedClosePrice = group.GetDouble(RelatedClosePrice.FixTag);
                RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);

                var clearingTradePrice = group.GetDouble(ClearingTradePrice.FixTag);
                ClearingTradePrice.Encode(pointer, current, clearingTradePrice, out current);

                var packageId = (uint)group.GetInt(PackageId.FixTag);
                PackageId.Encode(pointer, current, packageId, out current);

                var sideMarketSegmentId = group.GetInt(SideMarketSegmentId.FixTag);
                SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);

                var sideTrdSubTyp = (ushort)group.GetInt(SideTrdSubTyp.FixTag);
                SideTrdSubTyp.Encode(pointer, current, sideTrdSubTyp, out current);

                var productComplex = (byte)group.GetInt(ProductComplex.FixTag);
                ProductComplex.Encode(pointer, current, productComplex, out current);

                var tradePublishIndicator = (byte)group.GetInt(TradePublishIndicator.FixTag);
                TradePublishIndicator.Encode(pointer, current, tradePublishIndicator, out current);

                var instrmtMatchSideId = (byte)group.GetInt(InstrmtMatchSideId.FixTag);
                InstrmtMatchSideId.Encode(pointer, current, instrmtMatchSideId, out current);

                var effectOnBasket = (byte)group.GetInt(EffectOnBasket.FixTag);
                EffectOnBasket.Encode(pointer, current, effectOnBasket, out current);

                if (group.TryGetString(TradeReportText.FixTag, out var tradeReportText))
                {
                    TradeReportText.Encode(pointer, current, tradeReportText, out current);
                }
                else
                {
                    TradeReportText.SetNull(pointer, current, out current);
                }

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode New Basket Instrmt Match Side Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            NewBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}