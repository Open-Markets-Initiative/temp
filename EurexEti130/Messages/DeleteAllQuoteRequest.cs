using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Delete All Quote Request Message Methods
/// </summary>

public static partial class DeleteAllQuoteRequest
{
    /// <summary>
    ///  Eti Identifier for Delete All Quote Request
    /// </summary>
    public const string Identifier = "10408";

    /// <summary>
    ///  Encode Delete All Quote Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.DeleteAllQuoteRequest, out current);

        // --- encode delete all quote request message ---

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

        if (message.TryGetInt(TargetPartyIdSessionId.FixTag, out var targetPartyIdSessionId))
        {
            TargetPartyIdSessionId.Encode(pointer, current, (uint)targetPartyIdSessionId, out current);
        }
        else
        {
            TargetPartyIdSessionId.SetNull(pointer, current, out current);
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

        Pad6.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Delete All Quote Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = DeleteAllQuoteRequest.Identifier;

        // --- decode delete all quote request message ---

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

        if (TargetPartyIdSessionId.TryDecode(pointer, current, out var targetPartyIdSessionId, out current))
        {
            message.AppendInt(TargetPartyIdSessionId.FixTag, (int)targetPartyIdSessionId);
        }

        if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
        {
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
        }

        if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
        {
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
        }

        current += Pad6.Length;

        return FixErrorCode.None;
    }
}
