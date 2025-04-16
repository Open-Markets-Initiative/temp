using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Order Exec Report Broadcast Message Methods
/// </summary>

public static partial class OrderExecReportBroadcast
{
    /// <summary>
    ///  Eti Identifier for Order Exec Report Broadcast
    /// </summary>
    public const string Identifier = "10901";

    /// <summary>
    ///  Encode Order Exec Report Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.OrderExecReportBroadcast, out current);

        // --- encode order exec report broadcast message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetInt(PartyIdExecutingUnit.FixTag, out var partyIdExecutingUnit))
        {
            PartyIdExecutingUnit.Encode(pointer, current, (uint)partyIdExecutingUnit, out current);
        }
        else
        {
            PartyIdExecutingUnit.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplId.FixTag, out var applId))
        {
            ApplId.Encode(pointer, current, (byte)applId, out current);
        }
        else
        {
            ApplId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(OrderId.FixTag, out var orderId))
        {
            OrderId.Encode(pointer, current, orderId, out current);
        }
        else
        {
            OrderId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ClOrdId.FixTag, out var clOrdId))
        {
            ClOrdId.Encode(pointer, current, clOrdId, out current);
        }
        else
        {
            ClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(OrigClOrdId.FixTag, out var origClOrdId))
        {
            OrigClOrdId.Encode(pointer, current, origClOrdId, out current);
        }
        else
        {
            OrigClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetLong(SecurityId.FixTag, out var securityId))
        {
            SecurityId.Encode(pointer, current, securityId, out current);
        }
        else
        {
            SecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ExecId.FixTag, out var execId))
        {
            ExecId.Encode(pointer, current, execId, out current);
        }
        else
        {
            ExecId.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(Price.FixTag, out var price))
        {
            Price.Encode(pointer, current, price, out current);
        }
        else
        {
            Price.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(StopPx.FixTag, out var stopPx))
        {
            StopPx.Encode(pointer, current, stopPx, out current);
        }
        else
        {
            StopPx.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(LeavesQty.FixTag, out var leavesQty))
        {
            LeavesQty.Encode(pointer, current, leavesQty, out current);
        }
        else
        {
            LeavesQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(CumQty.FixTag, out var cumQty))
        {
            CumQty.Encode(pointer, current, cumQty, out current);
        }
        else
        {
            CumQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(CxlQty.FixTag, out var cxlQty))
        {
            CxlQty.Encode(pointer, current, cxlQty, out current);
        }
        else
        {
            CxlQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(OrderQty.FixTag, out var orderQty))
        {
            OrderQty.Encode(pointer, current, orderQty, out current);
        }
        else
        {
            OrderQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(PartyIdClientId.FixTag, out var partyIdClientId))
        {
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);
        }
        else
        {
            PartyIdClientId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(PartyIdInvestmentDecisionMaker.FixTag, out var partyIdInvestmentDecisionMaker))
        {
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);
        }
        else
        {
            PartyIdInvestmentDecisionMaker.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ExecutingTrader.FixTag, out var executingTrader))
        {
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);
        }
        else
        {
            ExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExpireDate.FixTag, out var expireDate))
        {
            ExpireDate.Encode(pointer, current, (uint)expireDate, out current);
        }
        else
        {
            ExpireDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdSessionId.FixTag, out var partyIdSessionId))
        {
            PartyIdSessionId.Encode(pointer, current, (uint)partyIdSessionId, out current);
        }
        else
        {
            PartyIdSessionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdExecutingTrader.FixTag, out var partyIdExecutingTrader))
        {
            PartyIdExecutingTrader.Encode(pointer, current, (uint)partyIdExecutingTrader, out current);
        }
        else
        {
            PartyIdExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        var ordStatus = message.GetToken(OrdStatus.FixTag);
        OrdStatus.Encode(pointer, current, ordStatus, out current);

        var execType = message.GetToken(ExecType.FixTag);
        ExecType.Encode(pointer, current, execType, out current);

        if (message.TryGetInt(Side.FixTag, out var side))
        {
            Side.Encode(pointer, current, (byte)side, out current);
        }
        else
        {
            Side.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrdType.FixTag, out var ordType))
        {
            OrdType.Encode(pointer, current, (byte)ordType, out current);
        }
        else
        {
            OrdType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MatchType.FixTag, out var matchType))
        {
            MatchType.Encode(pointer, current, (byte)matchType, out current);
        }
        else
        {
            MatchType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
        {
            TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
        }
        else
        {
            TradingCapacity.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TimeInForce.FixTag, out var timeInForce))
        {
            TimeInForce.Encode(pointer, current, (byte)timeInForce, out current);
        }
        else
        {
            TimeInForce.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExecInst.FixTag, out var execInst))
        {
            ExecInst.Encode(pointer, current, (byte)execInst, out current);
        }
        else
        {
            ExecInst.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(Triggered.FixTag, out var triggered))
        {
            Triggered.Encode(pointer, current, (byte)triggered, out current);
        }
        else
        {
            Triggered.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradingSessionSubId.FixTag, out var tradingSessionSubId))
        {
            TradingSessionSubId.Encode(pointer, current, (byte)tradingSessionSubId, out current);
        }
        else
        {
            TradingSessionSubId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplSeqIndicator.FixTag, out var applSeqIndicator))
        {
            ApplSeqIndicator.Encode(pointer, current, (byte)applSeqIndicator, out current);
        }
        else
        {
            ApplSeqIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, out var partyIdInvestmentDecisionMakerQualifier))
        {
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, (byte)partyIdInvestmentDecisionMakerQualifier, out current);
        }
        else
        {
            PartyIdInvestmentDecisionMakerQualifier.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
        {
            ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
        }
        else
        {
            ExecutingTraderQualifier.SetNull(pointer, current, out current);
        }

        var isFillsGrpComp = message.TryGetGroup(NoFills.FixTag, out var fillsGrpComp) && fillsGrpComp.sectionList.Count > 0;
        if (isFillsGrpComp)
        {
            var noFills = (byte)fillsGrpComp.sectionList.Count;
            NoFills.Encode(pointer, current, noFills, out current);
        }
        else
        {
            NoFills.Zero(pointer, current, out current);
        }

        if (message.TryGetInt(CrossedIndicator.FixTag, out var crossedIndicator))
        {
            CrossedIndicator.Encode(pointer, current, (byte)crossedIndicator, out current);
        }
        else
        {
            CrossedIndicator.SetNull(pointer, current, out current);
        }

        var custOrderHandlingInst = message.GetToken(CustOrderHandlingInst.FixTag);
        CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

        if (message.TryGetString(FreeText1.FixTag, out var freeText1))
        {
            FreeText1.Encode(pointer, current, freeText1, out current);
        }
        else
        {
            FreeText1.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FreeText2.FixTag, out var freeText2))
        {
            FreeText2.Encode(pointer, current, freeText2, out current);
        }
        else
        {
            FreeText2.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FreeText3.FixTag, out var freeText3))
        {
            FreeText3.Encode(pointer, current, freeText3, out current);
        }
        else
        {
            FreeText3.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FixClOrdId.FixTag, out var fixClOrdId))
        {
            FixClOrdId.Encode(pointer, current, fixClOrdId, out current);
        }
        else
        {
            FixClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FixOrigClOrdId.FixTag, out var fixOrigClOrdId))
        {
            FixOrigClOrdId.Encode(pointer, current, fixOrigClOrdId, out current);
        }
        else
        {
            FixOrigClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
        {
            PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
        }
        else
        {
            PartyEndClientIdentification.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        if (isFillsGrpComp)
        {
            FillsGrpComp.Encode(pointer, current, fillsGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Order Exec Report Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = OrderExecReportBroadcast.Identifier;

        // --- decode order exec report broadcast message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (PartyIdExecutingUnit.TryDecode(pointer, current, out var partyIdExecutingUnit, out current))
        {
            message.AppendInt(PartyIdExecutingUnit.FixTag, (int)partyIdExecutingUnit);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        if (OrderId.TryDecode(pointer, current, out var orderId, out current))
        {
            message.AppendULong(OrderId.FixTag, orderId);
        }

        if (ClOrdId.TryDecode(pointer, current, out var clOrdId, out current))
        {
            message.AppendULong(ClOrdId.FixTag, clOrdId);
        }

        if (OrigClOrdId.TryDecode(pointer, current, out var origClOrdId, out current))
        {
            message.AppendULong(OrigClOrdId.FixTag, origClOrdId);
        }

        if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
        {
            message.AppendLong(SecurityId.FixTag, securityId);
        }

        if (ExecId.TryDecode(pointer, current, out var execId, out current))
        {
            message.AppendULong(ExecId.FixTag, execId);
        }

        if (Price.TryDecode(pointer, current, out var price, out current))
        {
            message.AppendDouble(Price.FixTag, price);
        }

        if (StopPx.TryDecode(pointer, current, out var stopPx, out current))
        {
            message.AppendDouble(StopPx.FixTag, stopPx);
        }

        if (LeavesQty.TryDecode(pointer, current, out var leavesQty, out current))
        {
            message.AppendDouble(LeavesQty.FixTag, leavesQty);
        }

        if (CumQty.TryDecode(pointer, current, out var cumQty, out current))
        {
            message.AppendDouble(CumQty.FixTag, cumQty);
        }

        if (CxlQty.TryDecode(pointer, current, out var cxlQty, out current))
        {
            message.AppendDouble(CxlQty.FixTag, cxlQty);
        }

        if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
        {
            message.AppendDouble(OrderQty.FixTag, orderQty);
        }

        if (PartyIdClientId.TryDecode(pointer, current, out var partyIdClientId, out current))
        {
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);
        }

        if (PartyIdInvestmentDecisionMaker.TryDecode(pointer, current, out var partyIdInvestmentDecisionMaker, out current))
        {
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);
        }

        if (ExecutingTrader.TryDecode(pointer, current, out var executingTrader, out current))
        {
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (ExpireDate.TryDecode(pointer, current, out var expireDate, out current))
        {
            message.AppendInt(ExpireDate.FixTag, (int)expireDate);
        }

        if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
        {
            message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
        }

        if (PartyIdExecutingTrader.TryDecode(pointer, current, out var partyIdExecutingTrader, out current))
        {
            message.AppendInt(PartyIdExecutingTrader.FixTag, (int)partyIdExecutingTrader);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        var ordStatus = OrdStatus.Decode(pointer, current, out current);
        message.AppendToken(OrdStatus.FixTag, ordStatus);

        var execType = ExecType.Decode(pointer, current, out current);
        message.AppendToken(ExecType.FixTag, execType);

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (OrdType.TryDecode(pointer, current, out var ordType, out current))
        {
            message.AppendInt(OrdType.FixTag, ordType);
        }

        if (MatchType.TryDecode(pointer, current, out var matchType, out current))
        {
            message.AppendInt(MatchType.FixTag, matchType);
        }

        if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
        {
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
        }

        if (TimeInForce.TryDecode(pointer, current, out var timeInForce, out current))
        {
            message.AppendInt(TimeInForce.FixTag, timeInForce);
        }

        if (ExecInst.TryDecode(pointer, current, out var execInst, out current))
        {
            message.AppendInt(ExecInst.FixTag, execInst);
        }

        if (Triggered.TryDecode(pointer, current, out var triggered, out current))
        {
            message.AppendInt(Triggered.FixTag, triggered);
        }

        if (TradingSessionSubId.TryDecode(pointer, current, out var tradingSessionSubId, out current))
        {
            message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);
        }

        if (ApplSeqIndicator.TryDecode(pointer, current, out var applSeqIndicator, out current))
        {
            message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);
        }

        if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
        {
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
        }

        if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
        {
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
        }

        var noFills = (int)NoFills.Decode(pointer, current, out current);

        if (CrossedIndicator.TryDecode(pointer, current, out var crossedIndicator, out current))
        {
            message.AppendInt(CrossedIndicator.FixTag, crossedIndicator);
        }

        var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
        message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

        if (FreeText1.TryDecode(pointer, current, out var freeText1, out current))
        {
            message.AppendString(FreeText1.FixTag, freeText1);
        }

        if (FreeText2.TryDecode(pointer, current, out var freeText2, out current))
        {
            message.AppendString(FreeText2.FixTag, freeText2);
        }

        if (FreeText3.TryDecode(pointer, current, out var freeText3, out current))
        {
            message.AppendString(FreeText3.FixTag, freeText3);
        }

        if (FixClOrdId.TryDecode(pointer, current, out var fixClOrdId, out current))
        {
            message.AppendString(FixClOrdId.FixTag, fixClOrdId);
        }

        if (FixOrigClOrdId.TryDecode(pointer, current, out var fixOrigClOrdId, out current))
        {
            message.AppendString(FixOrigClOrdId.FixTag, fixOrigClOrdId);
        }

        if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
        {
            message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
        }

        current += Pad7.Length;

        FillsGrpComp.Decode(ref message, pointer, current, noFills, out current);

        return FixErrorCode.None;
    }
}
