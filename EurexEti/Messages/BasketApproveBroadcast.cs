using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Basket Approve Broadcast Message Methods
/// </summary>

public static partial class BasketApproveBroadcast
{
    /// <summary>
    ///  Eti Identifier for Basket Approve Broadcast
    /// </summary>
    public const string Identifier = "10627";

    /// <summary>
    ///  Encode Basket Approve Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.BasketApproveBroadcast, out current);

        // --- encode basket approve broadcast message ---

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

        var isBasketSideAllocExtBcGrpComp = message.TryGetGroup(NoBasketSideAlloc.FixTag, out var basketSideAllocExtBcGrpComp) && basketSideAllocExtBcGrpComp.sectionList.Count > 0;
        if (isBasketSideAllocExtBcGrpComp)
        {
            var noBasketSideAlloc = (ushort)basketSideAllocExtBcGrpComp.sectionList.Count;
            NoBasketSideAlloc.Encode(pointer, current, noBasketSideAlloc, out current);
        }
        else
        {
            NoBasketSideAlloc.Zero(pointer, current, out current);
        }

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketTradeReportType.FixTag, out var basketTradeReportType))
        {
            BasketTradeReportType.Encode(pointer, current, (byte)basketTradeReportType, out current);
        }
        else
        {
            BasketTradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OptionalEarlyTerminationIndicator.FixTag, out var optionalEarlyTerminationIndicator))
        {
            OptionalEarlyTerminationIndicator.Encode(pointer, current, (byte)optionalEarlyTerminationIndicator, out current);
        }
        else
        {
            OptionalEarlyTerminationIndicator.SetNull(pointer, current, out current);
        }

        var messageEventSource = message.GetToken(MessageEventSource.FixTag);
        MessageEventSource.Encode(pointer, current, messageEventSource, out current);

        var isBasketRootPartyGrpComp = message.TryGetGroup(NoBasketRootPartyGrps.FixTag, out var basketRootPartyGrpComp) && basketRootPartyGrpComp.sectionList.Count > 0;
        if (isBasketRootPartyGrpComp)
        {
            var noBasketRootPartyGrps = (byte)basketRootPartyGrpComp.sectionList.Count;
            NoBasketRootPartyGrps.Encode(pointer, current, noBasketRootPartyGrps, out current);
        }
        else
        {
            NoBasketRootPartyGrps.Zero(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdEnteringFirm.FixTag, out var partyIdEnteringFirm))
        {
            PartyIdEnteringFirm.Encode(pointer, current, (byte)partyIdEnteringFirm, out current);
        }
        else
        {
            PartyIdEnteringFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyEnteringTrader.FixTag, out var partyEnteringTrader))
        {
            PartyEnteringTrader.Encode(pointer, current, partyEnteringTrader, out current);
        }
        else
        {
            PartyEnteringTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketTradeReportText.FixTag, out var basketTradeReportText))
        {
            BasketTradeReportText.Encode(pointer, current, basketTradeReportText, out current);
        }
        else
        {
            BasketTradeReportText.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
        {
            TradeReportId.Encode(pointer, current, tradeReportId, out current);
        }
        else
        {
            TradeReportId.SetNull(pointer, current, out current);
        }

        Pad4.Encode(pointer, current, out current);

        if (isBasketRootPartyGrpComp)
        {
            BasketRootPartyGrpComp.Encode(pointer, current, basketRootPartyGrpComp, out current);
        }

        if (isBasketSideAllocExtBcGrpComp)
        {
            BasketSideAllocExtBcGrpComp.Encode(pointer, current, basketSideAllocExtBcGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Basket Approve Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = BasketApproveBroadcast.Identifier;

        // --- decode basket approve broadcast message ---

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

        var noBasketSideAlloc = (int)NoBasketSideAlloc.Decode(pointer, current, out current);

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        if (BasketTradeReportType.TryDecode(pointer, current, out var basketTradeReportType, out current))
        {
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);
        }

        if (OptionalEarlyTerminationIndicator.TryDecode(pointer, current, out var optionalEarlyTerminationIndicator, out current))
        {
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);
        }

        var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
        message.AppendToken(MessageEventSource.FixTag, messageEventSource);

        var noBasketRootPartyGrps = (int)NoBasketRootPartyGrps.Decode(pointer, current, out current);

        if (PartyIdEnteringFirm.TryDecode(pointer, current, out var partyIdEnteringFirm, out current))
        {
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);
        }

        if (PartyEnteringTrader.TryDecode(pointer, current, out var partyEnteringTrader, out current))
        {
            message.AppendString(PartyEnteringTrader.FixTag, partyEnteringTrader);
        }

        if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
        {
            message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
        }

        if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
        {
            message.AppendString(TradeReportId.FixTag, tradeReportId);
        }

        current += Pad4.Length;

        BasketRootPartyGrpComp.Decode(ref message, pointer, current, noBasketRootPartyGrps, out current);

        BasketSideAllocExtBcGrpComp.Decode(ref message, pointer, current, noBasketSideAlloc, out current);

        return FixErrorCode.None;
    }
}
