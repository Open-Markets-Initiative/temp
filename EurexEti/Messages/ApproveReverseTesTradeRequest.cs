using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Approve Reverse Tes Trade Request Message Methods
    /// </summary>

    public partial class ApproveReverseTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Approve Reverse Tes Trade Request
        /// </summary>
        public const string Identifier = "Approve Reverse Tes Trade Request";

        /// <summary>
        ///  Encode Approve Reverse Tes Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ApproveReverseTesTradeRequest, out current);

            // --- encode approve reverse tes trade request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = (uint)message.GetInt(SenderSubId.FixTag);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var packageId = (uint)message.GetInt(PackageId.FixTag);
            PackageId.Encode(pointer, current, packageId, out current);

            var allocId = (uint)message.GetInt(AllocId.FixTag);
            AllocId.Encode(pointer, current, allocId, out current);

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

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, current - offset);
        }

        /// <summary>
        ///  Decode Approve Reverse Tes Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ApproveReverseTesTradeRequest.Identifier;

            // --- decode approve reverse tes trade request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var packageId = (int)PackageId.Decode(pointer, current, out current);
            message.AppendInt(PackageId.FixTag, packageId);

            var allocId = (int)AllocId.Decode(pointer, current, out current);
            message.AppendInt(AllocId.FixTag, allocId);

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

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}