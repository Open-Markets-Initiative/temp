using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Inquire Margin Based Risk Limit Request Message Methods
    /// </summary>

    public partial class InquireMarginBasedRiskLimitRequest
    {
        /// <summary>
        ///  Eti Identifier for Inquire Margin Based Risk Limit Request
        /// </summary>
        public const string Identifier = "10323";

        /// <summary>
        ///  Encode Inquire Margin Based Risk Limit Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireMarginBasedRiskLimitRequest, out current);

            // --- encode inquire margin based risk limit request message ---

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

            var senderSubId = uint.Parse(message.sendersubid);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            if (message.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
            {
                PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
            }
            else
            {
                PartyDetailExecutingUnit.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Inquire Margin Based Risk Limit Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireMarginBasedRiskLimitRequest.Identifier;

            // --- decode inquire margin based risk limit request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubId = senderSubId.ToString();

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}