using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Inquire Pre Trade Risk Limits Request Message Methods
/// </summary>

public static partial class InquirePreTradeRiskLimitsRequest
{
    /// <summary>
    ///  Eti Identifier for Inquire Pre Trade Risk Limits Request
    /// </summary>
    public const string Identifier = "10311";

    /// <summary>
    ///  Encode Inquire Pre Trade Risk Limits Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.InquirePreTradeRiskLimitsRequest, out current);

        // --- encode inquire pre trade risk limits request message ---

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

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RiskLimitPlatform.FixTag, out var riskLimitPlatform))
        {
            RiskLimitPlatform.Encode(pointer, current, (byte)riskLimitPlatform, out current);
        }
        else
        {
            RiskLimitPlatform.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyExecutingUnit.FixTag, out var partyExecutingUnit))
        {
            PartyExecutingUnit.Encode(pointer, current, partyExecutingUnit, out current);
        }
        else
        {
            PartyExecutingUnit.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RiskLimitGroup.FixTag, out var riskLimitGroup))
        {
            RiskLimitGroup.Encode(pointer, current, riskLimitGroup, out current);
        }
        else
        {
            RiskLimitGroup.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Inquire Pre Trade Risk Limits Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = InquirePreTradeRiskLimitsRequest.Identifier;

        // --- decode inquire pre trade risk limits request message ---

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

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (RiskLimitPlatform.TryDecode(pointer, current, out var riskLimitPlatform, out current))
        {
            message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);
        }

        if (PartyExecutingUnit.TryDecode(pointer, current, out var partyExecutingUnit, out current))
        {
            message.AppendString(PartyExecutingUnit.FixTag, partyExecutingUnit);
        }

        if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
        {
            message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
        }

        current += Pad3.Length;

        return FixErrorCode.None;
    }
}
