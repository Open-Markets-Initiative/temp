using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Reverse Tes Trade Request Message Methods
    /// </summary>

    public static partial class ReverseTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Reverse Tes Trade Request
        /// </summary>
        public const string Identifier = "10630";

        /// <summary>
        ///  Encode Reverse Tes Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ReverseTesTradeRequest, out current);

            // --- encode reverse tes trade request message ---

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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var packageId = (uint)message.GetInt(PackageId.FixTag);
            PackageId.Encode(pointer, current, packageId, out current);

            var tesExecId = (uint)message.GetInt(TesExecId.FixTag);
            TesExecId.Encode(pointer, current, tesExecId, out current);

            var relatedMarketSegmentId = message.GetInt(RelatedMarketSegmentId.FixTag);
            RelatedMarketSegmentId.Encode(pointer, current, relatedMarketSegmentId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ReversalReasonText.FixTag, out var reversalReasonText))
            {
                ReversalReasonText.Encode(pointer, current, reversalReasonText, out current);
            }
            else
            {
                ReversalReasonText.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Reverse Tes Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ReverseTesTradeRequest.Identifier;

            // --- decode reverse tes trade request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var packageId = (int)PackageId.Decode(pointer, current, out current);
            message.AppendInt(PackageId.FixTag, packageId);

            var tesExecId = (int)TesExecId.Decode(pointer, current, out current);
            message.AppendInt(TesExecId.FixTag, tesExecId);

            var relatedMarketSegmentId = RelatedMarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(RelatedMarketSegmentId.FixTag, relatedMarketSegmentId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (ReversalReasonText.TryDecode(pointer, current, out var reversalReasonText, out current))
            {
                message.AppendString(ReversalReasonText.FixTag, reversalReasonText);
            }

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}