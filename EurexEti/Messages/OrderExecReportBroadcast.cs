using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Exec Report Broadcast Message Methods
    /// </summary>

    public static partial class OrderExecReportBroadcast
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

            if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
            {
                TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
            }
            else
            {
                TrdRegTsTimeOut.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(NotificationIn.FixTag, out var notificationIn))
            {
                NotificationIn.Encode(pointer, current, notificationIn, out current);
            }
            else
            {
                NotificationIn.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            if (message.TryGetInt(ApplSubId.FixTag, out var applSubId))
            {
                ApplSubId.Encode(pointer, current, (uint)applSubId, out current);
            }
            else
            {
                ApplSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
            {
                ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
            }
            else
            {
                ApplResendFlag.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

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

            if (message.TryGetULong(TrdRegTsEntryTime.FixTag, out var trdRegTsEntryTime))
            {
                TrdRegTsEntryTime.Encode(pointer, current, trdRegTsEntryTime, out current);
            }
            else
            {
                TrdRegTsEntryTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TrdRegTsTimePriority.FixTag, out var trdRegTsTimePriority))
            {
                TrdRegTsTimePriority.Encode(pointer, current, trdRegTsTimePriority, out current);
            }
            else
            {
                TrdRegTsTimePriority.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(Price.FixTag, out var price))
            {
                Price.Encode(pointer, current, price, out current);
            }
            else
            {
                Price.SetNull(pointer, current, out current);
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

            if (message.TryGetDouble(StopPx.FixTag, out var stopPx))
            {
                StopPx.Encode(pointer, current, stopPx, out current);
            }
            else
            {
                StopPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MassOrderReportId.FixTag, out var massOrderReportId))
            {
                MassOrderReportId.Encode(pointer, current, (uint)massOrderReportId, out current);
            }
            else
            {
                MassOrderReportId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ExpireDate.FixTag, out var expireDate))
            {
                ExpireDate.Encode(pointer, current, (uint)expireDate, out current);
            }
            else
            {
                ExpireDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MatchInstCrossId.FixTag, out var matchInstCrossId))
            {
                MatchInstCrossId.Encode(pointer, current, (uint)matchInstCrossId, out current);
            }
            else
            {
                MatchInstCrossId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdExecutingUnit.FixTag, out var partyIdExecutingUnit))
            {
                PartyIdExecutingUnit.Encode(pointer, current, (uint)partyIdExecutingUnit, out current);
            }
            else
            {
                PartyIdExecutingUnit.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(PartyIdEnteringTrader.FixTag, out var partyIdEnteringTrader))
            {
                PartyIdEnteringTrader.Encode(pointer, current, (uint)partyIdEnteringTrader, out current);
            }
            else
            {
                PartyIdEnteringTrader.SetNull(pointer, current, out current);
            }

            var isInstrmntLegExecGrpComp = message.TryGetGroup(NoLegExecs.FixTag, out var instrmntLegExecGrpComp) && instrmntLegExecGrpComp.sectionList.Count > 0;
            if (isInstrmntLegExecGrpComp)
            {
                var noLegExecs = (ushort)instrmntLegExecGrpComp.sectionList.Count;
                NoLegExecs.Encode(pointer, current, noLegExecs, out current);
            }
            else
            {
                NoLegExecs.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(ExecRestatementReason.FixTag, out var execRestatementReason))
            {
                ExecRestatementReason.Encode(pointer, current, (ushort)execRestatementReason, out current);
            }
            else
            {
                ExecRestatementReason.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdEnteringFirm.FixTag, out var partyIdEnteringFirm))
            {
                PartyIdEnteringFirm.Encode(pointer, current, (byte)partyIdEnteringFirm, out current);
            }
            else
            {
                PartyIdEnteringFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SelfMatchPreventionInstruction.FixTag, out var selfMatchPreventionInstruction))
            {
                SelfMatchPreventionInstruction.Encode(pointer, current, (byte)selfMatchPreventionInstruction, out current);
            }
            else
            {
                SelfMatchPreventionInstruction.SetNull(pointer, current, out current);
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

            var isLegOrdGrpComp = message.TryGetGroup(NoLegOnbooks.FixTag, out var legOrdGrpComp) && legOrdGrpComp.sectionList.Count > 0;
            if (isLegOrdGrpComp)
            {
                var noLegOnbooks = (byte)legOrdGrpComp.sectionList.Count;
                NoLegOnbooks.Encode(pointer, current, noLegOnbooks, out current);
            }
            else
            {
                NoLegOnbooks.Zero(pointer, current, out current);
            }

            var isOrderEventGrpComp = message.TryGetGroup(NoOrderEvents.FixTag, out var orderEventGrpComp) && orderEventGrpComp.sectionList.Count > 0;
            if (isOrderEventGrpComp)
            {
                var noOrderEvents = (byte)orderEventGrpComp.sectionList.Count;
                NoOrderEvents.Encode(pointer, current, noOrderEvents, out current);
            }
            else
            {
                NoOrderEvents.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(Triggered.FixTag, out var triggered))
            {
                Triggered.Encode(pointer, current, (byte)triggered, out current);
            }
            else
            {
                Triggered.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(CrossedIndicator.FixTag, out var crossedIndicator))
            {
                CrossedIndicator.Encode(pointer, current, (byte)crossedIndicator, out current);
            }
            else
            {
                CrossedIndicator.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            if (isLegOrdGrpComp)
            {
                LegOrdGrpComp.Encode(pointer, current, legOrdGrpComp, out current);
            }

            if (isFillsGrpComp)
            {
                FillsGrpComp.Encode(pointer, current, fillsGrpComp, out current);
            }

            if (isInstrmntLegExecGrpComp)
            {
                InstrmntLegExecGrpComp.Encode(pointer, current, instrmntLegExecGrpComp, out current);
            }

            if (isOrderEventGrpComp)
            {
                OrderEventGrpComp.Encode(pointer, current, orderEventGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Order Exec Report Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = OrderExecReportBroadcast.Identifier;

            // --- decode order exec report broadcast message ---

            current += Pad2.Length;

            if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
            {
                message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
            }

            if (NotificationIn.TryDecode(pointer, current, out var notificationIn, out current))
            {
                message.AppendULong(NotificationIn.FixTag, notificationIn);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
            {
                message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad7.Length;

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

            if (TrdRegTsEntryTime.TryDecode(pointer, current, out var trdRegTsEntryTime, out current))
            {
                message.AppendULong(TrdRegTsEntryTime.FixTag, trdRegTsEntryTime);
            }

            if (TrdRegTsTimePriority.TryDecode(pointer, current, out var trdRegTsTimePriority, out current))
            {
                message.AppendULong(TrdRegTsTimePriority.FixTag, trdRegTsTimePriority);
            }

            if (Price.TryDecode(pointer, current, out var price, out current))
            {
                message.AppendDouble(Price.FixTag, price);
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

            if (StopPx.TryDecode(pointer, current, out var stopPx, out current))
            {
                message.AppendDouble(StopPx.FixTag, stopPx);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (MassOrderReportId.TryDecode(pointer, current, out var massOrderReportId, out current))
            {
                message.AppendInt(MassOrderReportId.FixTag, (int)massOrderReportId);
            }

            if (ExpireDate.TryDecode(pointer, current, out var expireDate, out current))
            {
                message.AppendInt(ExpireDate.FixTag, (int)expireDate);
            }

            if (MatchInstCrossId.TryDecode(pointer, current, out var matchInstCrossId, out current))
            {
                message.AppendInt(MatchInstCrossId.FixTag, (int)matchInstCrossId);
            }

            if (PartyIdExecutingUnit.TryDecode(pointer, current, out var partyIdExecutingUnit, out current))
            {
                message.AppendInt(PartyIdExecutingUnit.FixTag, (int)partyIdExecutingUnit);
            }

            if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
            {
                message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
            }

            if (PartyIdExecutingTrader.TryDecode(pointer, current, out var partyIdExecutingTrader, out current))
            {
                message.AppendInt(PartyIdExecutingTrader.FixTag, (int)partyIdExecutingTrader);
            }

            if (PartyIdEnteringTrader.TryDecode(pointer, current, out var partyIdEnteringTrader, out current))
            {
                message.AppendInt(PartyIdEnteringTrader.FixTag, (int)partyIdEnteringTrader);
            }

            var noLegExecs = (int)NoLegExecs.Decode(pointer, current, out current);

            if (ExecRestatementReason.TryDecode(pointer, current, out var execRestatementReason, out current))
            {
                message.AppendInt(ExecRestatementReason.FixTag, (short)execRestatementReason);
            }

            if (PartyIdEnteringFirm.TryDecode(pointer, current, out var partyIdEnteringFirm, out current))
            {
                message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);
            }

            if (SelfMatchPreventionInstruction.TryDecode(pointer, current, out var selfMatchPreventionInstruction, out current))
            {
                message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);
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

            if (TradingSessionSubId.TryDecode(pointer, current, out var tradingSessionSubId, out current))
            {
                message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);
            }

            if (ApplSeqIndicator.TryDecode(pointer, current, out var applSeqIndicator, out current))
            {
                message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);
            }

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

            var noFills = (int)NoFills.Decode(pointer, current, out current);

            var noLegOnbooks = (int)NoLegOnbooks.Decode(pointer, current, out current);

            var noOrderEvents = (int)NoOrderEvents.Decode(pointer, current, out current);

            if (Triggered.TryDecode(pointer, current, out var triggered, out current))
            {
                message.AppendInt(Triggered.FixTag, triggered);
            }

            if (CrossedIndicator.TryDecode(pointer, current, out var crossedIndicator, out current))
            {
                message.AppendInt(CrossedIndicator.FixTag, crossedIndicator);
            }

            current += Pad4.Length;

            LegOrdGrpComp.Decode(ref message, pointer, current, noLegOnbooks, out current);

            FillsGrpComp.Decode(ref message, pointer, current, noFills, out current);

            InstrmntLegExecGrpComp.Decode(ref message, pointer, current, noLegExecs, out current);

            OrderEventGrpComp.Decode(ref message, pointer, current, noOrderEvents, out current);

            return FixErrorCode.None;
        }
    }
}