using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Update Remaining Risk Allowance Base Request Message Methods
/// </summary>

public static partial class UpdateRemainingRiskAllowanceBaseRequest
{
    /// <summary>
    ///  Eti Identifier for Update Remaining Risk Allowance Base Request
    /// </summary>
    public const string Identifier = "10325";

    /// <summary>
    ///  Encode Update Remaining Risk Allowance Base Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.UpdateRemainingRiskAllowanceBaseRequest, out current);

        // --- encode update remaining risk allowance base request message ---

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

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        var isRraUpdateBasePartyGrpComp = message.TryGetGroup(NoPartyRiskLimits.FixTag, out var rraUpdateBasePartyGrpComp) && rraUpdateBasePartyGrpComp.sectionList.Count > 0;
        if (isRraUpdateBasePartyGrpComp)
        {
            var noPartyRiskLimits = (ushort)rraUpdateBasePartyGrpComp.sectionList.Count;
            NoPartyRiskLimits.Encode(pointer, current, noPartyRiskLimits, out current);
        }
        else
        {
            NoPartyRiskLimits.Zero(pointer, current, out current);
        }

        Pad4.Encode(pointer, current, out current);

        if (isRraUpdateBasePartyGrpComp)
        {
            RraUpdateBasePartyGrpComp.Encode(pointer, current, rraUpdateBasePartyGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Update Remaining Risk Allowance Base Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = UpdateRemainingRiskAllowanceBaseRequest.Identifier;

        // --- decode update remaining risk allowance base request message ---

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

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        var noPartyRiskLimits = (int)NoPartyRiskLimits.Decode(pointer, current, out current);

        current += Pad4.Length;

        RraUpdateBasePartyGrpComp.Decode(ref message, pointer, current, noPartyRiskLimits, out current);

        return FixErrorCode.None;
    }
}
