using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Approve Reverse Tes Trade Request Message Methods
    /// </summary>

    public static partial class ApproveReverseTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Approve Reverse Tes Trade Request
        /// </summary>
        public const string Identifier = "10631";

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

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PackageId.FixTag, out var packageId))
            {
                PackageId.Encode(pointer, current, (uint)packageId, out current);
            }
            else
            {
                PackageId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(AllocId.FixTag, out var allocId))
            {
                AllocId.Encode(pointer, current, (uint)allocId, out current);
            }
            else
            {
                AllocId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TesExecId.FixTag, out var tesExecId))
            {
                TesExecId.Encode(pointer, current, (uint)tesExecId, out current);
            }
            else
            {
                TesExecId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RelatedMarketSegmentId.FixTag, out var relatedMarketSegmentId))
            {
                RelatedMarketSegmentId.Encode(pointer, current, relatedMarketSegmentId, out current);
            }
            else
            {
                RelatedMarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TrdType.FixTag, out var trdType))
            {
                TrdType.Encode(pointer, current, (ushort)trdType, out current);
            }
            else
            {
                TrdType.SetNull(pointer, current, out current);
            }

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

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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

            if (PackageId.TryDecode(pointer, current, out var packageId, out current))
            {
                message.AppendInt(PackageId.FixTag, (int)packageId);
            }

            if (AllocId.TryDecode(pointer, current, out var allocId, out current))
            {
                message.AppendInt(AllocId.FixTag, (int)allocId);
            }

            if (TesExecId.TryDecode(pointer, current, out var tesExecId, out current))
            {
                message.AppendInt(TesExecId.FixTag, (int)tesExecId);
            }

            if (RelatedMarketSegmentId.TryDecode(pointer, current, out var relatedMarketSegmentId, out current))
            {
                message.AppendInt(RelatedMarketSegmentId.FixTag, relatedMarketSegmentId);
            }

            if (TrdType.TryDecode(pointer, current, out var trdType, out current))
            {
                message.AppendInt(TrdType.FixTag, (short)trdType);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}