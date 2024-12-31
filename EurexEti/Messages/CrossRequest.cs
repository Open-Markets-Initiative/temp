using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Request Message Methods
    /// </summary>

    public static partial class CrossRequest
    {
        /// <summary>
        ///  Eti Identifier for Cross Request
        /// </summary>
        public const string Identifier = "10118";

        /// <summary>
        ///  Encode Cross Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.CrossRequest, out current);

            // --- encode cross request message ---

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

            if (message.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OrderQty.FixTag, out var orderQty))
            {
                OrderQty.Encode(pointer, current, orderQty, out current);
            }
            else
            {
                OrderQty.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Cross Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = CrossRequest.Identifier;

            // --- decode cross request message ---

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

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
            {
                message.AppendDouble(OrderQty.FixTag, orderQty);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            return FixErrorCode.None;
        }
    }
}