using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Basket Execution Broadcast Message Methods
/// </summary>

public static partial class BasketExecutionBroadcast
{
    /// <summary>
    ///  Eti Identifier for Basket Execution Broadcast
    /// </summary>
    public const string Identifier = "10628";

    /// <summary>
    ///  Encode Basket Execution Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.BasketExecutionBroadcast, out current);

        // --- encode basket execution broadcast message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetULong(ApplSeqNum.FixTag, out var applSeqNum))
        {
            ApplSeqNum.Encode(pointer, current, applSeqNum, out current);
        }
        else
        {
            ApplSeqNum.SetNull(pointer, current, out current);
        }

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

        if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
        {
            ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
        }
        else
        {
            ApplResendFlag.SetNull(pointer, current, out current);
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

        Pad7.Encode(pointer, current, out current);

        if (message.TryGetULong(BasketTrdMatchId.FixTag, out var basketTrdMatchId))
        {
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);
        }
        else
        {
            BasketTrdMatchId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(OrigBasketTrdMatchId.FixTag, out var origBasketTrdMatchId))
        {
            OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);
        }
        else
        {
            OrigBasketTrdMatchId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
        {
            TransactTime.Encode(pointer, current, transactTime, out current);
        }
        else
        {
            TransactTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketExecId.FixTag, out var basketExecId))
        {
            BasketExecId.Encode(pointer, current, (uint)basketExecId, out current);
        }
        else
        {
            BasketExecId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketProfileId.FixTag, out var basketProfileId))
        {
            BasketProfileId.Encode(pointer, current, (uint)basketProfileId, out current);
        }
        else
        {
            BasketProfileId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TrdType.FixTag, out var trdType))
        {
            TrdType.Encode(pointer, current, (ushort)trdType, out current);
        }
        else
        {
            TrdType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OptionalEarlyTerminationIndicator.FixTag, out var optionalEarlyTerminationIndicator))
        {
            OptionalEarlyTerminationIndicator.Encode(pointer, current, (byte)optionalEarlyTerminationIndicator, out current);
        }
        else
        {
            OptionalEarlyTerminationIndicator.SetNull(pointer, current, out current);
        }

        var isBasketExecGrpComp = message.TryGetGroup(NoInstrmtMatchSides.FixTag, out var basketExecGrpComp) && basketExecGrpComp.sectionList.Count > 0;
        if (isBasketExecGrpComp)
        {
            var noInstrmtMatchSides = (byte)basketExecGrpComp.sectionList.Count;
            NoInstrmtMatchSides.Encode(pointer, current, noInstrmtMatchSides, out current);
        }
        else
        {
            NoInstrmtMatchSides.Zero(pointer, current, out current);
        }

        var messageEventSource = message.GetToken(MessageEventSource.FixTag);
        MessageEventSource.Encode(pointer, current, messageEventSource, out current);

        if (message.TryGetString(BasketSideTradeReportId.FixTag, out var basketSideTradeReportId))
        {
            BasketSideTradeReportId.Encode(pointer, current, basketSideTradeReportId, out current);
        }
        else
        {
            BasketSideTradeReportId.SetNull(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        if (isBasketExecGrpComp)
        {
            BasketExecGrpComp.Encode(pointer, current, basketExecGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Basket Execution Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = BasketExecutionBroadcast.Identifier;

        // --- decode basket execution broadcast message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (ApplSeqNum.TryDecode(pointer, current, out var applSeqNum, out current))
        {
            message.AppendULong(ApplSeqNum.FixTag, applSeqNum);
        }

        if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
        {
            message.AppendInt(ApplSubId.FixTag, (int)applSubId);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
        {
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad7.Length;

        if (BasketTrdMatchId.TryDecode(pointer, current, out var basketTrdMatchId, out current))
        {
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);
        }

        if (OrigBasketTrdMatchId.TryDecode(pointer, current, out var origBasketTrdMatchId, out current))
        {
            message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);
        }

        if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
        {
            message.AppendULong(TransactTime.FixTag, transactTime);
        }

        if (BasketExecId.TryDecode(pointer, current, out var basketExecId, out current))
        {
            message.AppendInt(BasketExecId.FixTag, (int)basketExecId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (BasketProfileId.TryDecode(pointer, current, out var basketProfileId, out current))
        {
            message.AppendInt(BasketProfileId.FixTag, (int)basketProfileId);
        }

        if (TrdType.TryDecode(pointer, current, out var trdType, out current))
        {
            message.AppendInt(TrdType.FixTag, (short)trdType);
        }

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        if (OptionalEarlyTerminationIndicator.TryDecode(pointer, current, out var optionalEarlyTerminationIndicator, out current))
        {
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);
        }

        var noInstrmtMatchSides = (int)NoInstrmtMatchSides.Decode(pointer, current, out current);

        var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
        message.AppendToken(MessageEventSource.FixTag, messageEventSource);

        if (BasketSideTradeReportId.TryDecode(pointer, current, out var basketSideTradeReportId, out current))
        {
            message.AppendString(BasketSideTradeReportId.FixTag, basketSideTradeReportId);
        }

        current += Pad2.Length;

        BasketExecGrpComp.Decode(ref message, pointer, current, noInstrmtMatchSides, out current);

        return FixErrorCode.None;
    }
}
