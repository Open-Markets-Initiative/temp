using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Clip Execution Notification Message Methods
    /// </summary>

    public partial class ClipExecutionNotification
    {
        /// <summary>
        ///  Eti Identifier for Clip Execution Notification
        /// </summary>
        public const string Identifier = "Clip Execution Notification";

        /// <summary>
        ///  Encode Clip Execution Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ClipExecutionNotification, out current);

            // --- encode clip execution notification message ---

            var start = current;

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

            var execId = message.GetULong(ExecId.FixTag);
            ExecId.Encode(pointer, current, execId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var cxlQty = message.GetDouble(CxlQty.FixTag);
            CxlQty.Encode(pointer, current, cxlQty, out current);

            var leavesQty = message.GetDouble(LeavesQty.FixTag);
            LeavesQty.Encode(pointer, current, leavesQty, out current);

            var cumQty = message.GetDouble(CumQty.FixTag);
            CumQty.Encode(pointer, current, cumQty, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var execRestatementReason = (ushort)message.GetInt(ExecRestatementReason.FixTag);
            ExecRestatementReason.Encode(pointer, current, execRestatementReason, out current);

            var noLegExecs = (ushort)message.GetInt(NoLegExecs.FixTag);
            NoLegExecs.Encode(pointer, current, noLegExecs, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var ordStatus = message.GetToken(OrdStatus.FixTag);
            OrdStatus.Encode(pointer, current, ordStatus, out current);

            var execType = message.GetToken(ExecType.FixTag);
            ExecType.Encode(pointer, current, execType, out current);

            var matchType = (byte)message.GetInt(MatchType.FixTag);
            MatchType.Encode(pointer, current, matchType, out current);

            var noFills = (byte)message.GetInt(NoFills.FixTag);
            NoFills.Encode(pointer, current, noFills, out current);

            Pad2.Encode(pointer, current, out current);

            var fillPx = group.GetDouble(FillPx.FixTag);
            FillPx.Encode(pointer, current, fillPx, out current);

            var fillQty = group.GetDouble(FillQty.FixTag);
            FillQty.Encode(pointer, current, fillQty, out current);

            var fillMatchId = (uint)group.GetInt(FillMatchId.FixTag);
            FillMatchId.Encode(pointer, current, fillMatchId, out current);

            var fillExecId = group.GetInt(FillExecId.FixTag);
            FillExecId.Encode(pointer, current, fillExecId, out current);

            var fillLiquidityInd = (byte)group.GetInt(FillLiquidityInd.FixTag);
            FillLiquidityInd.Encode(pointer, current, fillLiquidityInd, out current);

            Pad7.Encode(pointer, current, out current);

            var legSecurityId = group.GetLong(LegSecurityId.FixTag);
            LegSecurityId.Encode(pointer, current, legSecurityId, out current);

            var legLastPx = group.GetDouble(LegLastPx.FixTag);
            LegLastPx.Encode(pointer, current, legLastPx, out current);

            var legLastQty = group.GetDouble(LegLastQty.FixTag);
            LegLastQty.Encode(pointer, current, legLastQty, out current);

            var legExecId = group.GetInt(LegExecId.FixTag);
            LegExecId.Encode(pointer, current, legExecId, out current);

            var legSide = (byte)group.GetInt(LegSide.FixTag);
            LegSide.Encode(pointer, current, legSide, out current);

            var fillRefId = (byte)group.GetInt(FillRefId.FixTag);
            FillRefId.Encode(pointer, current, fillRefId, out current);

            Pad2.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Clip Execution Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ClipExecutionNotification.Identifier;

            // --- decode clip execution notification message ---

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

            var execId = ExecId.Decode(pointer, current, out current);
            message.AppendULong(ExecId.FixTag, execId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var cxlQty = CxlQty.Decode(pointer, current, out current);
            message.AppendDouble(CxlQty.FixTag, cxlQty);

            var leavesQty = LeavesQty.Decode(pointer, current, out current);
            message.AppendDouble(LeavesQty.FixTag, leavesQty);

            var cumQty = CumQty.Decode(pointer, current, out current);
            message.AppendDouble(CumQty.FixTag, cumQty);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var execRestatementReason = (short)ExecRestatementReason.Decode(pointer, current, out current);
            message.AppendInt(ExecRestatementReason.FixTag, execRestatementReason);

            var noLegExecs = (short)NoLegExecs.Decode(pointer, current, out current);
            message.AppendInt(NoLegExecs.FixTag, noLegExecs);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var ordStatus = OrdStatus.Decode(pointer, current, out current);
            message.AppendToken(OrdStatus.FixTag, ordStatus);

            var execType = ExecType.Decode(pointer, current, out current);
            message.AppendToken(ExecType.FixTag, execType);

            var matchType = MatchType.Decode(pointer, current, out current);
            message.AppendInt(MatchType.FixTag, matchType);

            var noFills = NoFills.Decode(pointer, current, out current);
            message.AppendInt(NoFills.FixTag, noFills);

            current += Pad2.Length;

            var fillPx = FillPx.Decode(pointer, current, out current);
            message.AppendDouble(FillPx.FixTag, fillPx);

            var fillQty = FillQty.Decode(pointer, current, out current);
            message.AppendDouble(FillQty.FixTag, fillQty);

            var fillMatchId = (int)FillMatchId.Decode(pointer, current, out current);
            message.AppendInt(FillMatchId.FixTag, fillMatchId);

            var fillExecId = FillExecId.Decode(pointer, current, out current);
            message.AppendInt(FillExecId.FixTag, fillExecId);

            var fillLiquidityInd = FillLiquidityInd.Decode(pointer, current, out current);
            message.AppendInt(FillLiquidityInd.FixTag, fillLiquidityInd);

            current += Pad7.Length;

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legLastPx = LegLastPx.Decode(pointer, current, out current);
            message.AppendDouble(LegLastPx.FixTag, legLastPx);

            var legLastQty = LegLastQty.Decode(pointer, current, out current);
            message.AppendDouble(LegLastQty.FixTag, legLastQty);

            var legExecId = LegExecId.Decode(pointer, current, out current);
            message.AppendInt(LegExecId.FixTag, legExecId);

            var legSide = LegSide.Decode(pointer, current, out current);
            message.AppendInt(LegSide.FixTag, legSide);

            var fillRefId = FillRefId.Decode(pointer, current, out current);
            message.AppendInt(FillRefId.FixTag, fillRefId);

            current += Pad2.Length;

            return FixErrorCode.None;
        }
    }
}