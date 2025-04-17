using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Approve Tes Trade Request Message Methods
/// </summary>

public static partial class ApproveTesTradeRequest
{
    /// <summary>
    ///  Eti Identifier for Approve Tes Trade Request
    /// </summary>
    public const string Identifier = "10603";

    /// <summary>
    ///  Encode Approve Tes Trade Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.ApproveTesTradeRequest, out current);

        // --- encode approve tes trade request message ---

        if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
        {
            NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
        }
        else
        {
            NetworkMsgId.SetNull(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        if (uint.TryParse(message.senderSubID, out var senderSubId))
        {
            SenderSubId.Encode(pointer, current, senderSubId, out current);
        }
        else
        {
            SenderSubId.SetNull(pointer, current, out current);
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

        if (message.TryGetDouble(AllocQty.FixTag, out var allocQty))
        {
            AllocQty.Encode(pointer, current, allocQty, out current);
        }
        else
        {
            AllocQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PackageId.FixTag, out var packageId))
        {
            PackageId.Encode(pointer, current, (uint)packageId, out current);
        }
        else
        {
            PackageId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(AllocId.FixTag, out var allocId))
        {
            AllocId.Encode(pointer, current, (uint)allocId, out current);
        }
        else
        {
            AllocId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TesExecId.FixTag, out var tesExecId))
        {
            TesExecId.Encode(pointer, current, (uint)tesExecId, out current);
        }
        else
        {
            TesExecId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RelatedMarketSegmentId.FixTag, out var relatedMarketSegmentId))
        {
            RelatedMarketSegmentId.Encode(pointer, current, relatedMarketSegmentId, out current);
        }
        else
        {
            RelatedMarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TrdType.FixTag, out var trdType))
        {
            TrdType.Encode(pointer, current, (ushort)trdType, out current);
        }
        else
        {
            TrdType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
        {
            TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
        }
        else
        {
            TradingCapacity.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(Side.FixTag, out var side))
        {
            Side.Encode(pointer, current, (byte)side, out current);
        }
        else
        {
            Side.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
        {
            OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
        }
        else
        {
            OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(OrderAttributeRiskReduction.FixTag, out var orderAttributeRiskReduction))
        {
            OrderAttributeRiskReduction.Encode(pointer, current, (byte)orderAttributeRiskReduction, out current);
        }
        else
        {
            OrderAttributeRiskReduction.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderOrigination.FixTag, out var orderOrigination))
        {
            OrderOrigination.Encode(pointer, current, (byte)orderOrigination, out current);
        }
        else
        {
            OrderOrigination.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
        {
            TradeReportId.Encode(pointer, current, tradeReportId, out current);
        }
        else
        {
            TradeReportId.SetNull(pointer, current, out current);
        }

        var positionEffect = message.GetToken(PositionEffect.FixTag);
        PositionEffect.Encode(pointer, current, positionEffect, out current);

        if (message.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
        {
            PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
        }
        else
        {
            PartyExecutingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
        {
            PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
        }
        else
        {
            PartyExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(Account.FixTag, out var account))
        {
            Account.Encode(pointer, current, account, out current);
        }
        else
        {
            Account.SetNull(pointer, current, out current);
        }

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

        if (message.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
        {
            PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
        }
        else
        {
            PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
        {
            PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
        }
        else
        {
            PartyIdPositionAccount.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
        {
            PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
        }
        else
        {
            PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
        {
            PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
        }
        else
        {
            PartyIdBeneficiary.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
        {
            PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
        }
        else
        {
            PartyIdLocationId.SetNull(pointer, current, out current);
        }

        var custOrderHandlingInst = message.GetToken(CustOrderHandlingInst.FixTag);
        CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

        if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
        {
            ComplianceText.Encode(pointer, current, complianceText, out current);
        }
        else
        {
            ComplianceText.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
        {
            PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
        }
        else
        {
            PartyEndClientIdentification.SetNull(pointer, current, out current);
        }

        Pad4.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Approve Tes Trade Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ApproveTesTradeRequest.Identifier;

        // --- decode approve tes trade request message ---

        if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
        {
            message.AppendString(NetworkMsgId.FixTag, networkMsgId);
        }

        current += Pad2.Length;

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
        {
            message.senderSubID = senderSubId.ToString();
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

        if (AllocQty.TryDecode(pointer, current, out var allocQty, out current))
        {
            message.AppendDouble(AllocQty.FixTag, allocQty);
        }

        if (PackageId.TryDecode(pointer, current, out var packageId, out current))
        {
            message.AppendInt(PackageId.FixTag, (int)packageId);
        }

        if (AllocId.TryDecode(pointer, current, out var allocId, out current))
        {
            message.AppendInt(AllocId.FixTag, (int)allocId);
        }

        if (TesExecId.TryDecode(pointer, current, out var tesExecId, out current))
        {
            message.AppendInt(TesExecId.FixTag, (int)tesExecId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (RelatedMarketSegmentId.TryDecode(pointer, current, out var relatedMarketSegmentId, out current))
        {
            message.AppendInt(RelatedMarketSegmentId.FixTag, relatedMarketSegmentId);
        }

        if (TrdType.TryDecode(pointer, current, out var trdType, out current))
        {
            message.AppendInt(TrdType.FixTag, (short)trdType);
        }

        if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
        {
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
        }

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
        {
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
        }

        if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
        {
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
        }

        if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
        {
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
        }

        if (OrderAttributeRiskReduction.TryDecode(pointer, current, out var orderAttributeRiskReduction, out current))
        {
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);
        }

        if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
        {
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);
        }

        if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
        {
            message.AppendString(TradeReportId.FixTag, tradeReportId);
        }

        var positionEffect = PositionEffect.Decode(pointer, current, out current);
        message.AppendToken(PositionEffect.FixTag, positionEffect);

        if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
        {
            message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
        }

        if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
        {
            message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
        }

        if (Account.TryDecode(pointer, current, out var account, out current))
        {
            message.AppendString(Account.FixTag, account);
        }

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

        if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
        {
            message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
        }

        if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
        {
            message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
        }

        if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
        {
            message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
        }

        if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
        {
            message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
        }

        if (PartyIdLocationId.TryDecode(pointer, current, out var partyIdLocationId, out current))
        {
            message.AppendString(PartyIdLocationId.FixTag, partyIdLocationId);
        }

        var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
        message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

        if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
        {
            message.AppendString(ComplianceText.FixTag, complianceText);
        }

        if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
        {
            message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
        }

        current += Pad4.Length;

        return FixErrorCode.None;
    }
}
