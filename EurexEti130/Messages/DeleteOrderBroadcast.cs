using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Delete Order Broadcast Message Methods
/// </summary>

public static partial class DeleteOrderBroadcast
{
    /// <summary>
    ///  Eti Identifier for Delete Order Broadcast
    /// </summary>
    public const string Identifier = "10112";

    /// <summary>
    ///  Encode Delete Order Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.DeleteOrderBroadcast, out current);

        // --- encode delete order broadcast message ---

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

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdEnteringTrader.FixTag, out var partyIdEnteringTrader))
        {
            PartyIdEnteringTrader.Encode(pointer, current, (uint)partyIdEnteringTrader, out current);
        }
        else
        {
            PartyIdEnteringTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdSessionId.FixTag, out var partyIdSessionId))
        {
            PartyIdSessionId.Encode(pointer, current, (uint)partyIdSessionId, out current);
        }
        else
        {
            PartyIdSessionId.SetNull(pointer, current, out current);
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

        var ordStatus = message.GetToken(OrdStatus.FixTag);
        OrdStatus.Encode(pointer, current, ordStatus, out current);

        var execType = message.GetToken(ExecType.FixTag);
        ExecType.Encode(pointer, current, execType, out current);

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(Side.FixTag, out var side))
        {
            Side.Encode(pointer, current, (byte)side, out current);
        }
        else
        {
            Side.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FixClOrdId.FixTag, out var fixClOrdId))
        {
            FixClOrdId.Encode(pointer, current, fixClOrdId, out current);
        }
        else
        {
            FixClOrdId.SetNull(pointer, current, out current);
        }

        Pad1.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Delete Order Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = DeleteOrderBroadcast.Identifier;

        // --- decode delete order broadcast message ---

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

        if (CumQty.TryDecode(pointer, current, out var cumQty, out current))
        {
            message.AppendDouble(CumQty.FixTag, cumQty);
        }

        if (CxlQty.TryDecode(pointer, current, out var cxlQty, out current))
        {
            message.AppendDouble(CxlQty.FixTag, cxlQty);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (PartyIdEnteringTrader.TryDecode(pointer, current, out var partyIdEnteringTrader, out current))
        {
            message.AppendInt(PartyIdEnteringTrader.FixTag, (int)partyIdEnteringTrader);
        }

        if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
        {
            message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
        }

        if (ExecRestatementReason.TryDecode(pointer, current, out var execRestatementReason, out current))
        {
            message.AppendInt(ExecRestatementReason.FixTag, (short)execRestatementReason);
        }

        if (PartyIdEnteringFirm.TryDecode(pointer, current, out var partyIdEnteringFirm, out current))
        {
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);
        }

        var ordStatus = OrdStatus.Decode(pointer, current, out current);
        message.AppendToken(OrdStatus.FixTag, ordStatus);

        var execType = ExecType.Decode(pointer, current, out current);
        message.AppendToken(ExecType.FixTag, execType);

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (FixClOrdId.TryDecode(pointer, current, out var fixClOrdId, out current))
        {
            message.AppendString(FixClOrdId.FixTag, fixClOrdId);
        }

        current += Pad1.Length;

        return FixErrorCode.None;
    }
}
