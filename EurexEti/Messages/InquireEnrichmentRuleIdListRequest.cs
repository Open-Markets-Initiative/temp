using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Inquire Enrichment Rule Id List Request Message Methods
    /// </summary>

    public partial class InquireEnrichmentRuleIdListRequest
    {
        /// <summary>
        ///  Eti Identifier for Inquire Enrichment Rule Id List Request
        /// </summary>
        public const string Identifier = "10040";

        /// <summary>
        ///  Encode Inquire Enrichment Rule Id List Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireEnrichmentRuleIdListRequest, out current);

            // --- encode inquire enrichment rule id list request message ---

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

            var lastEntityProcessed = message.GetData(LastEntityProcessed.FixTag);
            LastEntityProcessed.Encode(pointer, current, lastEntityProcessed, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Inquire Enrichment Rule Id List Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireEnrichmentRuleIdListRequest.Identifier;

            // --- decode inquire enrichment rule id list request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubId = senderSubId.ToString();

            var lastEntityProcessed = LastEntityProcessed.Decode(pointer, current, out current);
            message.AppendData(LastEntityProcessed.FixTag, lastEntityProcessed);

            return FixErrorCode.None;
        }
    }
}