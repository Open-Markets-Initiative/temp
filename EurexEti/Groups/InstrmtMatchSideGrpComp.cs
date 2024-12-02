using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrmt Match Side Grp Comp Message Methods
    /// </summary>

    public partial class InstrmtMatchSideGrpComp
    {
        /// <summary>
        ///  Length of Instrmt Match Side Grp Comp in bytes
        /// </summary>
        public const int Length = 80;

        /// <summary>
        ///  Encode Instrmt Match Side Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, InstrmtMatchSideGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode instrmt match side grp comp ---

            if (!message.TryGetGroup(InstrmtMatchSideGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(InstrmtMatchSideGrpComp.FixTag, message);
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
        ///  Decode Instrmt Match Side Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode instrmt match side grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode instrmt match side grp comp group ---

            message.AppendInt(InstrmtMatchSideGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var lastPx = LastPx.Decode(pointer, current, out current);
                message.AppendDouble(LastPx.FixTag, lastPx);

                var transBkdTime = TransBkdTime.Decode(pointer, current, out current);
                message.AppendULong(TransBkdTime.FixTag, transBkdTime);

                var relatedClosePrice = RelatedClosePrice.Decode(pointer, current, out current);
                message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);

                var clearingTradePrice = ClearingTradePrice.Decode(pointer, current, out current);
                message.AppendDouble(ClearingTradePrice.FixTag, clearingTradePrice);

                var packageId = (int)PackageId.Decode(pointer, current, out current);
                message.AppendInt(PackageId.FixTag, packageId);

                var sideMarketSegmentId = SideMarketSegmentId.Decode(pointer, current, out current);
                message.AppendInt(SideMarketSegmentId.FixTag, sideMarketSegmentId);

                var sideTrdSubTyp = (short)SideTrdSubTyp.Decode(pointer, current, out current);
                message.AppendInt(SideTrdSubTyp.FixTag, sideTrdSubTyp);

                var productComplex = ProductComplex.Decode(pointer, current, out current);
                message.AppendInt(ProductComplex.FixTag, productComplex);

                var tradePublishIndicator = TradePublishIndicator.Decode(pointer, current, out current);
                message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);

                var instrmtMatchSideId = InstrmtMatchSideId.Decode(pointer, current, out current);
                message.AppendInt(InstrmtMatchSideId.FixTag, instrmtMatchSideId);

                var effectOnBasket = EffectOnBasket.Decode(pointer, current, out current);
                message.AppendInt(EffectOnBasket.FixTag, effectOnBasket);

                if (TradeReportText.TryDecode(pointer, current, out var tradeReportText, out current))
                {
                    message.AppendString(TradeReportText.FixTag, tradeReportText);
                }

                current += Pad6.Length;

            }
        }
    }
}