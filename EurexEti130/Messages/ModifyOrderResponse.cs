using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Modify Order Response Message Methods
/// </summary>

public static partial class ModifyOrderResponse
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

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeIn.FixTag, out var trdRegTsTimeIn))
        {
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);
        }
        else
        {
            TrdRegTsTimeIn.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
        {
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
        }
        else
        {
            TrdRegTsTimeOut.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ResponseIn.FixTag, out var responseIn))
        {
            ResponseIn.Encode(pointer, current, responseIn, out current);
        }
        else
        {
            ResponseIn.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

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

        var applMsgId = message.GetData(ApplMsgId.FixTag);
        ApplMsgId.Encode(pointer, current, applMsgId, out current);

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

        if (message.TryGetULong(TrdRegTsTimePriority.FixTag, out var trdRegTsTimePriority))
        {
            TrdRegTsTimePriority.Encode(pointer, current, trdRegTsTimePriority, out current);
        }
        else
        {
            TrdRegTsTimePriority.SetNull(pointer, current, out current);
        }

        var ordStatus = message.GetToken(OrdStatus.FixTag);
        OrdStatus.Encode(pointer, current, ordStatus, out current);

        var execType = message.GetToken(ExecType.FixTag);
        ExecType.Encode(pointer, current, execType, out current);

        if (message.TryGetInt(ExecRestatementReason.FixTag, out var execRestatementReason))
        {
            ExecRestatementReason.Encode(pointer, current, (ushort)execRestatementReason, out current);
        }
        else
        {
            ExecRestatementReason.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(CrossedIndicator.FixTag, out var crossedIndicator))
        {
            CrossedIndicator.Encode(pointer, current, (byte)crossedIndicator, out current);
        }
        else
        {
            CrossedIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(Triggered.FixTag, out var triggered))
        {
            Triggered.Encode(pointer, current, (byte)triggered, out current);
        }
        else
        {
            Triggered.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TransactionDelayIndicator.FixTag, out var transactionDelayIndicator))
        {
            TransactionDelayIndicator.Encode(pointer, current, (byte)transactionDelayIndicator, out current);
        }
        else
        {
            TransactionDelayIndicator.SetNull(pointer, current, out current);
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
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ModifyOrderResponse.Identifier;

        // --- decode modify order response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (TrdRegTsTimeIn.TryDecode(pointer, current, out var trdRegTsTimeIn, out current))
        {
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);
        }

        if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
        {
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
        }

        if (ResponseIn.TryDecode(pointer, current, out var responseIn, out current))
        {
            message.AppendULong(ResponseIn.FixTag, responseIn);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        var applMsgId = ApplMsgId.Decode(pointer, current, out current);
        message.AppendData(ApplMsgId.FixTag, applMsgId);

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

        if (TrdRegTsTimePriority.TryDecode(pointer, current, out var trdRegTsTimePriority, out current))
        {
            message.AppendULong(TrdRegTsTimePriority.FixTag, trdRegTsTimePriority);
        }

        var ordStatus = OrdStatus.Decode(pointer, current, out current);
        message.AppendToken(OrdStatus.FixTag, ordStatus);

        var execType = ExecType.Decode(pointer, current, out current);
        message.AppendToken(ExecType.FixTag, execType);

        if (ExecRestatementReason.TryDecode(pointer, current, out var execRestatementReason, out current))
        {
            message.AppendInt(ExecRestatementReason.FixTag, (short)execRestatementReason);
        }

        if (CrossedIndicator.TryDecode(pointer, current, out var crossedIndicator, out current))
        {
            message.AppendInt(CrossedIndicator.FixTag, crossedIndicator);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        if (Triggered.TryDecode(pointer, current, out var triggered, out current))
        {
            message.AppendInt(Triggered.FixTag, triggered);
        }

        if (TransactionDelayIndicator.TryDecode(pointer, current, out var transactionDelayIndicator, out current))
        {
            message.AppendInt(TransactionDelayIndicator.FixTag, transactionDelayIndicator);
        }

        var noOrderEvents = (int)NoOrderEvents.Decode(pointer, current, out current);

        current += Pad7.Length;

        OrderEventGrpComp.Decode(ref message, pointer, current, noOrderEvents, out current);

        return FixErrorCode.None;
    }
}
