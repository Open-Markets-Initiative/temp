using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  New Basket Instrmt Match Side Grp Comp Message Methods
/// </summary>

public static partial class NewBasketInstrmtMatchSideGrpComp
{
    /// <summary>
    ///  Fix Tag for New Basket Instrmt Match Side Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39117;

    /// <summary>
    ///  Encode New Basket Instrmt Match Side Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup newBasketInstrmtMatchSideGrpComp, out int current)
    {
        current = offset;

        foreach (var group in newBasketInstrmtMatchSideGrpComp.sectionList)
        {
            if (group.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(LastPx.FixTag, out var lastPx))
            {
                LastPx.Encode(pointer, current, lastPx, out current);
            }
            else
            {
                LastPx.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(TransBkdTime.FixTag, out var transBkdTime))
            {
                TransBkdTime.Encode(pointer, current, transBkdTime, out current);
            }
            else
            {
                TransBkdTime.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(RelatedClosePrice.FixTag, out var relatedClosePrice))
            {
                RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);
            }
            else
            {
                RelatedClosePrice.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(ClearingTradePrice.FixTag, out var clearingTradePrice))
            {
                ClearingTradePrice.Encode(pointer, current, clearingTradePrice, out current);
            }
            else
            {
                ClearingTradePrice.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PackageId.FixTag, out var packageId))
            {
                PackageId.Encode(pointer, current, (uint)packageId, out current);
            }
            else
            {
                PackageId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(SideMarketSegmentId.FixTag, out var sideMarketSegmentId))
            {
                SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);
            }
            else
            {
                SideMarketSegmentId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(SideTrdSubTyp.FixTag, out var sideTrdSubTyp))
            {
                SideTrdSubTyp.Encode(pointer, current, (ushort)sideTrdSubTyp, out current);
            }
            else
            {
                SideTrdSubTyp.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(ProductComplex.FixTag, out var productComplex))
            {
                ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
            }
            else
            {
                ProductComplex.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(TradePublishIndicator.FixTag, out var tradePublishIndicator))
            {
                TradePublishIndicator.Encode(pointer, current, (byte)tradePublishIndicator, out current);
            }
            else
            {
                TradePublishIndicator.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(InstrmtMatchSideId.FixTag, out var instrmtMatchSideId))
            {
                InstrmtMatchSideId.Encode(pointer, current, (byte)instrmtMatchSideId, out current);
            }
            else
            {
                InstrmtMatchSideId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(EffectOnBasket.FixTag, out var effectOnBasket))
            {
                EffectOnBasket.Encode(pointer, current, (byte)effectOnBasket, out current);
            }
            else
            {
                EffectOnBasket.SetNull(pointer, current, out current);
            }

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
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoNewBasketInstrmtMatchSides.FixTag, count);

        while (count-- > 0)
        {
            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
            {
                message.AppendDouble(LastPx.FixTag, lastPx);
            }

            if (TransBkdTime.TryDecode(pointer, current, out var transBkdTime, out current))
            {
                message.AppendULong(TransBkdTime.FixTag, transBkdTime);
            }

            if (RelatedClosePrice.TryDecode(pointer, current, out var relatedClosePrice, out current))
            {
                message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);
            }

            if (ClearingTradePrice.TryDecode(pointer, current, out var clearingTradePrice, out current))
            {
                message.AppendDouble(ClearingTradePrice.FixTag, clearingTradePrice);
            }

            if (PackageId.TryDecode(pointer, current, out var packageId, out current))
            {
                message.AppendInt(PackageId.FixTag, (int)packageId);
            }

            if (SideMarketSegmentId.TryDecode(pointer, current, out var sideMarketSegmentId, out current))
            {
                message.AppendInt(SideMarketSegmentId.FixTag, sideMarketSegmentId);
            }

            if (SideTrdSubTyp.TryDecode(pointer, current, out var sideTrdSubTyp, out current))
            {
                message.AppendInt(SideTrdSubTyp.FixTag, (short)sideTrdSubTyp);
            }

            if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
            {
                message.AppendInt(ProductComplex.FixTag, productComplex);
            }

            if (TradePublishIndicator.TryDecode(pointer, current, out var tradePublishIndicator, out current))
            {
                message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);
            }

            if (InstrmtMatchSideId.TryDecode(pointer, current, out var instrmtMatchSideId, out current))
            {
                message.AppendInt(InstrmtMatchSideId.FixTag, instrmtMatchSideId);
            }

            if (EffectOnBasket.TryDecode(pointer, current, out var effectOnBasket, out current))
            {
                message.AppendInt(EffectOnBasket.FixTag, effectOnBasket);
            }

            if (TradeReportText.TryDecode(pointer, current, out var tradeReportText, out current))
            {
                message.AppendString(TradeReportText.FixTag, tradeReportText);
            }

            current += Pad6.Length;

        }
    }
}
