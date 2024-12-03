using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Exec Report Broadcast Message Methods
    /// </summary>

    public partial class OrderExecReportBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Order Exec Report Broadcast
        /// </summary>
        public const string Identifier = "10117";

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

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var notificationIn = message.GetULong(NotificationIn.FixTag);
            NotificationIn.Encode(pointer, current, notificationIn, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var orderId = message.GetULong(OrderId.FixTag);
            OrderId.Encode(pointer, current, orderId, out current);

            var clOrdId = message.GetULong(ClOrdId.FixTag);
            ClOrdId.Encode(pointer, current, clOrdId, out current);

            var origClOrdId = message.GetULong(OrigClOrdId.FixTag);
            OrigClOrdId.Encode(pointer, current, origClOrdId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var execId = message.GetULong(ExecId.FixTag);
            ExecId.Encode(pointer, current, execId, out current);

            var trdRegTsEntryTime = message.GetULong(TrdRegTsEntryTime.FixTag);
            TrdRegTsEntryTime.Encode(pointer, current, trdRegTsEntryTime, out current);

            var trdRegTsTimePriority = message.GetULong(TrdRegTsTimePriority.FixTag);
            TrdRegTsTimePriority.Encode(pointer, current, trdRegTsTimePriority, out current);

            var price = message.GetDouble(Price.FixTag);
            Price.Encode(pointer, current, price, out current);

            var leavesQty = message.GetDouble(LeavesQty.FixTag);
            LeavesQty.Encode(pointer, current, leavesQty, out current);

            var cumQty = message.GetDouble(CumQty.FixTag);
            CumQty.Encode(pointer, current, cumQty, out current);

            var cxlQty = message.GetDouble(CxlQty.FixTag);
            CxlQty.Encode(pointer, current, cxlQty, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var stopPx = message.GetDouble(StopPx.FixTag);
            StopPx.Encode(pointer, current, stopPx, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var massOrderReportId = (uint)message.GetInt(MassOrderReportId.FixTag);
            MassOrderReportId.Encode(pointer, current, massOrderReportId, out current);

            var expireDate = (uint)message.GetInt(ExpireDate.FixTag);
            ExpireDate.Encode(pointer, current, expireDate, out current);

            var matchInstCrossId = (uint)message.GetInt(MatchInstCrossId.FixTag);
            MatchInstCrossId.Encode(pointer, current, matchInstCrossId, out current);

            var partyIdExecutingUnit = (uint)message.GetInt(PartyIdExecutingUnit.FixTag);
            PartyIdExecutingUnit.Encode(pointer, current, partyIdExecutingUnit, out current);

            var partyIdSessionId = (uint)message.GetInt(PartyIdSessionId.FixTag);
            PartyIdSessionId.Encode(pointer, current, partyIdSessionId, out current);

            var partyIdExecutingTrader = (uint)message.GetInt(PartyIdExecutingTrader.FixTag);
            PartyIdExecutingTrader.Encode(pointer, current, partyIdExecutingTrader, out current);

            var partyIdEnteringTrader = (uint)message.GetInt(PartyIdEnteringTrader.FixTag);
            PartyIdEnteringTrader.Encode(pointer, current, partyIdEnteringTrader, out current);

            var noLegExecs = (ushort)message.GetInt(NoLegExecs.FixTag);
            NoLegExecs.Encode(pointer, current, noLegExecs, out current);

            var execRestatementReason = (ushort)message.GetInt(ExecRestatementReason.FixTag);
            ExecRestatementReason.Encode(pointer, current, execRestatementReason, out current);

            var partyIdEnteringFirm = (byte)message.GetInt(PartyIdEnteringFirm.FixTag);
            PartyIdEnteringFirm.Encode(pointer, current, partyIdEnteringFirm, out current);

            var selfMatchPreventionInstruction = (byte)message.GetInt(SelfMatchPreventionInstruction.FixTag);
            SelfMatchPreventionInstruction.Encode(pointer, current, selfMatchPreventionInstruction, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var ordStatus = message.GetToken(OrdStatus.FixTag);
            OrdStatus.Encode(pointer, current, ordStatus, out current);

            var execType = message.GetToken(ExecType.FixTag);
            ExecType.Encode(pointer, current, execType, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var ordType = (byte)message.GetInt(OrdType.FixTag);
            OrdType.Encode(pointer, current, ordType, out current);

            var tradingCapacity = (byte)message.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var timeInForce = (byte)message.GetInt(TimeInForce.FixTag);
            TimeInForce.Encode(pointer, current, timeInForce, out current);

            var execInst = (byte)message.GetInt(ExecInst.FixTag);
            ExecInst.Encode(pointer, current, execInst, out current);

            var tradingSessionSubId = (byte)message.GetInt(TradingSessionSubId.FixTag);
            TradingSessionSubId.Encode(pointer, current, tradingSessionSubId, out current);

            var applSeqIndicator = (byte)message.GetInt(ApplSeqIndicator.FixTag);
            ApplSeqIndicator.Encode(pointer, current, applSeqIndicator, out current);

            if (message.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
            {
                PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
            }
            else
            {
                PartyIdPositionAccount.SetNull(pointer, current, out current);
            }

            var positionEffect = message.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            if (message.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
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

            var noFills = (byte)message.GetInt(NoFills.FixTag);
            NoFills.Encode(pointer, current, noFills, out current);

            var noLegOnbooks = (byte)message.GetInt(NoLegOnbooks.FixTag);
            NoLegOnbooks.Encode(pointer, current, noLegOnbooks, out current);

            var noOrderEvents = (byte)message.GetInt(NoOrderEvents.FixTag);
            NoOrderEvents.Encode(pointer, current, noOrderEvents, out current);

            var triggered = (byte)message.GetInt(Triggered.FixTag);
            Triggered.Encode(pointer, current, triggered, out current);

            var crossedIndicator = (byte)message.GetInt(CrossedIndicator.FixTag);
            CrossedIndicator.Encode(pointer, current, crossedIndicator, out current);

            Pad4.Encode(pointer, current, out current);

            var legOrdGrpComp = (byte)message.GetInt(LegOrdGrpComp.FixTag);
            LegOrdGrpComp.Encode(message, pointer, current, legOrdGrpComp, out current);

            var fillsGrpComp = (byte)message.GetInt(FillsGrpComp.FixTag);
            FillsGrpComp.Encode(message, pointer, current, fillsGrpComp, out current);

            var instrmntLegExecGrpComp = (byte)message.GetInt(InstrmntLegExecGrpComp.FixTag);
            InstrmntLegExecGrpComp.Encode(message, pointer, current, instrmntLegExecGrpComp, out current);

            var orderEventGrpComp = (byte)message.GetInt(OrderEventGrpComp.FixTag);
            OrderEventGrpComp.Encode(message, pointer, current, orderEventGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Order Exec Report Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = OrderExecReportBroadcast.Identifier;

            // --- decode order exec report broadcast message ---

            current += Pad2.Length;

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var notificationIn = NotificationIn.Decode(pointer, current, out current);
            message.AppendULong(NotificationIn.FixTag, notificationIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var orderId = OrderId.Decode(pointer, current, out current);
            message.AppendULong(OrderId.FixTag, orderId);

            var clOrdId = ClOrdId.Decode(pointer, current, out current);
            message.AppendULong(ClOrdId.FixTag, clOrdId);

            var origClOrdId = OrigClOrdId.Decode(pointer, current, out current);
            message.AppendULong(OrigClOrdId.FixTag, origClOrdId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var execId = ExecId.Decode(pointer, current, out current);
            message.AppendULong(ExecId.FixTag, execId);

            var trdRegTsEntryTime = TrdRegTsEntryTime.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsEntryTime.FixTag, trdRegTsEntryTime);

            var trdRegTsTimePriority = TrdRegTsTimePriority.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimePriority.FixTag, trdRegTsTimePriority);

            var price = Price.Decode(pointer, current, out current);
            message.AppendDouble(Price.FixTag, price);

            var leavesQty = LeavesQty.Decode(pointer, current, out current);
            message.AppendDouble(LeavesQty.FixTag, leavesQty);

            var cumQty = CumQty.Decode(pointer, current, out current);
            message.AppendDouble(CumQty.FixTag, cumQty);

            var cxlQty = CxlQty.Decode(pointer, current, out current);
            message.AppendDouble(CxlQty.FixTag, cxlQty);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var stopPx = StopPx.Decode(pointer, current, out current);
            message.AppendDouble(StopPx.FixTag, stopPx);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var massOrderReportId = (int)MassOrderReportId.Decode(pointer, current, out current);
            message.AppendInt(MassOrderReportId.FixTag, massOrderReportId);

            var expireDate = (int)ExpireDate.Decode(pointer, current, out current);
            message.AppendInt(ExpireDate.FixTag, expireDate);

            var matchInstCrossId = (int)MatchInstCrossId.Decode(pointer, current, out current);
            message.AppendInt(MatchInstCrossId.FixTag, matchInstCrossId);

            var partyIdExecutingUnit = (int)PartyIdExecutingUnit.Decode(pointer, current, out current);
            message.AppendInt(PartyIdExecutingUnit.FixTag, partyIdExecutingUnit);

            var partyIdSessionId = (int)PartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(PartyIdSessionId.FixTag, partyIdSessionId);

            var partyIdExecutingTrader = (int)PartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyIdExecutingTrader.FixTag, partyIdExecutingTrader);

            var partyIdEnteringTrader = (int)PartyIdEnteringTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringTrader.FixTag, partyIdEnteringTrader);

            var noLegExecs = (short)NoLegExecs.Decode(pointer, current, out current);
            message.AppendInt(NoLegExecs.FixTag, noLegExecs);

            var execRestatementReason = (short)ExecRestatementReason.Decode(pointer, current, out current);
            message.AppendInt(ExecRestatementReason.FixTag, execRestatementReason);

            var partyIdEnteringFirm = PartyIdEnteringFirm.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);

            var selfMatchPreventionInstruction = SelfMatchPreventionInstruction.Decode(pointer, current, out current);
            message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var ordStatus = OrdStatus.Decode(pointer, current, out current);
            message.AppendToken(OrdStatus.FixTag, ordStatus);

            var execType = ExecType.Decode(pointer, current, out current);
            message.AppendToken(ExecType.FixTag, execType);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var ordType = OrdType.Decode(pointer, current, out current);
            message.AppendInt(OrdType.FixTag, ordType);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var timeInForce = TimeInForce.Decode(pointer, current, out current);
            message.AppendInt(TimeInForce.FixTag, timeInForce);

            var execInst = ExecInst.Decode(pointer, current, out current);
            message.AppendInt(ExecInst.FixTag, execInst);

            var tradingSessionSubId = TradingSessionSubId.Decode(pointer, current, out current);
            message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);

            var applSeqIndicator = ApplSeqIndicator.Decode(pointer, current, out current);
            message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
            {
                message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
            }

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
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

            var noFills = NoFills.Decode(pointer, current, out current);
            message.AppendInt(NoFills.FixTag, noFills);

            var noLegOnbooks = NoLegOnbooks.Decode(pointer, current, out current);
            message.AppendInt(NoLegOnbooks.FixTag, noLegOnbooks);

            var noOrderEvents = NoOrderEvents.Decode(pointer, current, out current);
            message.AppendInt(NoOrderEvents.FixTag, noOrderEvents);

            var triggered = Triggered.Decode(pointer, current, out current);
            message.AppendInt(Triggered.FixTag, triggered);

            var crossedIndicator = CrossedIndicator.Decode(pointer, current, out current);
            message.AppendInt(CrossedIndicator.FixTag, crossedIndicator);

            current += Pad4.Length;

            LegOrdGrpComp.Decode(ref message, pointer, current, out current);

            FillsGrpComp.Decode(ref message, pointer, current, out current);

            InstrmntLegExecGrpComp.Decode(ref message, pointer, current, out current);

            OrderEventGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}