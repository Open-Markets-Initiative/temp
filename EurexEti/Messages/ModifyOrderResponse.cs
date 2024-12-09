using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Modify Order Response Message Methods
    /// </summary>

    public partial class ModifyOrderResponse
    {
        /// <summary>
        ///  Eti Identifier for Modify Order Response
        /// </summary>
        public const string Identifier = "10107";

        /// <summary>
        ///  Encode Modify Order Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ModifyOrderResponse, out current);

            // --- encode modify order response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

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

            var leavesQty = message.GetDouble(LeavesQty.FixTag);
            LeavesQty.Encode(pointer, current, leavesQty, out current);

            var cumQty = message.GetDouble(CumQty.FixTag);
            CumQty.Encode(pointer, current, cumQty, out current);

            var cxlQty = message.GetDouble(CxlQty.FixTag);
            CxlQty.Encode(pointer, current, cxlQty, out current);

            var trdRegTsTimePriority = message.GetULong(TrdRegTsTimePriority.FixTag);
            TrdRegTsTimePriority.Encode(pointer, current, trdRegTsTimePriority, out current);

            var ordStatus = message.GetToken(OrdStatus.FixTag);
            OrdStatus.Encode(pointer, current, ordStatus, out current);

            var execType = message.GetToken(ExecType.FixTag);
            ExecType.Encode(pointer, current, execType, out current);

            var execRestatementReason = (ushort)message.GetInt(ExecRestatementReason.FixTag);
            ExecRestatementReason.Encode(pointer, current, execRestatementReason, out current);

            var crossedIndicator = (byte)message.GetInt(CrossedIndicator.FixTag);
            CrossedIndicator.Encode(pointer, current, crossedIndicator, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var triggered = (byte)message.GetInt(Triggered.FixTag);
            Triggered.Encode(pointer, current, triggered, out current);

            var transactionDelayIndicator = (byte)message.GetInt(TransactionDelayIndicator.FixTag);
            TransactionDelayIndicator.Encode(pointer, current, transactionDelayIndicator, out current);

            var isOrderEventGrpComp = message.TryGetGroup(NoOrderEvents.FixTag, out var orderEventGrpComp) && OrderEventGrpComp.sectionList.Length > 0;
            if (isOrderEventGrpComp)
            {
                var noOrderEvents = (byte)orderEventGrpComp.sectionList.Length;
                NoOrderEvents.Encode(pointer, current, noOrderEvents, out current);
            }
            else
            {
                NoOrderEvents.Zero(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (isOrderEventGrpComp)
            {
                OrderEventGrpComp.Encode(pointer, current, orderEventGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Modify Order Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ModifyOrderResponse.Identifier;

            // --- decode modify order response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var trdRegTsTimeIn = TrdRegTsTimeIn.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var responseIn = ResponseIn.Decode(pointer, current, out current);
            message.AppendULong(ResponseIn.FixTag, responseIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

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

            var leavesQty = LeavesQty.Decode(pointer, current, out current);
            message.AppendDouble(LeavesQty.FixTag, leavesQty);

            var cumQty = CumQty.Decode(pointer, current, out current);
            message.AppendDouble(CumQty.FixTag, cumQty);

            var cxlQty = CxlQty.Decode(pointer, current, out current);
            message.AppendDouble(CxlQty.FixTag, cxlQty);

            var trdRegTsTimePriority = TrdRegTsTimePriority.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimePriority.FixTag, trdRegTsTimePriority);

            var ordStatus = OrdStatus.Decode(pointer, current, out current);
            message.AppendToken(OrdStatus.FixTag, ordStatus);

            var execType = ExecType.Decode(pointer, current, out current);
            message.AppendToken(ExecType.FixTag, execType);

            var execRestatementReason = (short)ExecRestatementReason.Decode(pointer, current, out current);
            message.AppendInt(ExecRestatementReason.FixTag, execRestatementReason);

            var crossedIndicator = CrossedIndicator.Decode(pointer, current, out current);
            message.AppendInt(CrossedIndicator.FixTag, crossedIndicator);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var triggered = Triggered.Decode(pointer, current, out current);
            message.AppendInt(Triggered.FixTag, triggered);

            var transactionDelayIndicator = TransactionDelayIndicator.Decode(pointer, current, out current);
            message.AppendInt(TransactionDelayIndicator.FixTag, transactionDelayIndicator);

            var noOrderEvents = (int)NoOrderEvents.Decode(pointer, current, out current);

            current += Pad7.Length;

            OrderEventGrpComp.Decode(ref message, pointer, current, noOrderEvents, out current);

            return FixErrorCode.None;
        }
    }
}