using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Modify Tes Trade Request Message Methods
    /// </summary>

    public static partial class ModifyTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Modify Tes Trade Request
        /// </summary>
        public const string Identifier = "10601";

        /// <summary>
        ///  Encode Modify Tes Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ModifyTesTradeRequest, out current);

            // --- encode modify tes trade request message ---

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

            if (message.TryGetDouble(LastPx.FixTag, out var lastPx))
            {
                LastPx.Encode(pointer, current, lastPx, out current);
            }
            else
            {
                LastPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TransBkdTime.FixTag, out var transBkdTime))
            {
                TransBkdTime.Encode(pointer, current, transBkdTime, out current);
            }
            else
            {
                TransBkdTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(RelatedClosePrice.FixTag, out var relatedClosePrice))
            {
                RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);
            }
            else
            {
                RelatedClosePrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(RelatedPx.FixTag, out var relatedPx))
            {
                RelatedPx.Encode(pointer, current, relatedPx, out current);
            }
            else
            {
                RelatedPx.SetNull(pointer, current, out current);
            }

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

            if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
            {
                TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
            }
            else
            {
                TradeReportType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradePublishIndicator.FixTag, out var tradePublishIndicator))
            {
                TradePublishIndicator.Encode(pointer, current, (byte)tradePublishIndicator, out current);
            }
            else
            {
                TradePublishIndicator.SetNull(pointer, current, out current);
            }

            var isSideAllocGrpComp = message.TryGetGroup(NoSideAllocs.FixTag, out var sideAllocGrpComp) && sideAllocGrpComp.sectionList.Count > 0;
            if (isSideAllocGrpComp)
            {
                var noSideAllocs = (byte)sideAllocGrpComp.sectionList.Count;
                NoSideAllocs.Encode(pointer, current, noSideAllocs, out current);
            }
            else
            {
                NoSideAllocs.Zero(pointer, current, out current);
            }

            var isTrdInstrmntLegGrpComp = message.TryGetGroup(NoLegs.FixTag, out var trdInstrmntLegGrpComp) && trdInstrmntLegGrpComp.sectionList.Count > 0;
            if (isTrdInstrmntLegGrpComp)
            {
                var noLegs = (byte)trdInstrmntLegGrpComp.sectionList.Count;
                NoLegs.Encode(pointer, current, noLegs, out current);
            }
            else
            {
                NoLegs.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(SwapClearer.FixTag, out var swapClearer))
            {
                SwapClearer.Encode(pointer, current, (byte)swapClearer, out current);
            }
            else
            {
                SwapClearer.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(TradeReportText.FixTag, out var tradeReportText))
            {
                TradeReportText.Encode(pointer, current, tradeReportText, out current);
            }
            else
            {
                TradeReportText.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            if (isSideAllocGrpComp)
            {
                SideAllocGrpComp.Encode(pointer, current, sideAllocGrpComp, out current);
            }

            if (isTrdInstrmntLegGrpComp)
            {
                TrdInstrmntLegGrpComp.Encode(pointer, current, trdInstrmntLegGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Modify Tes Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = ModifyTesTradeRequest.Identifier;

            // --- decode modify tes trade request message ---

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

            if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
            {
                message.AppendDouble(LastPx.FixTag, lastPx);
            }

            if (TransBkdTime.TryDecode(pointer, current, out var transBkdTime, out current))
            {
                message.AppendULong(TransBkdTime.FixTag, transBkdTime);
            }

            if (RelatedClosePrice.TryDecode(pointer, current, out var relatedClosePrice, out current))
            {
                message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);
            }

            if (RelatedPx.TryDecode(pointer, current, out var relatedPx, out current))
            {
                message.AppendDouble(RelatedPx.FixTag, relatedPx);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (PackageId.TryDecode(pointer, current, out var packageId, out current))
            {
                message.AppendInt(PackageId.FixTag, (int)packageId);
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

            if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
            {
                message.AppendInt(TradeReportType.FixTag, tradeReportType);
            }

            if (TradePublishIndicator.TryDecode(pointer, current, out var tradePublishIndicator, out current))
            {
                message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);
            }

            var noSideAllocs = (int)NoSideAllocs.Decode(pointer, current, out current);

            var noLegs = (int)NoLegs.Decode(pointer, current, out current);

            if (SwapClearer.TryDecode(pointer, current, out var swapClearer, out current))
            {
                message.AppendInt(SwapClearer.FixTag, swapClearer);
            }

            if (TradeReportText.TryDecode(pointer, current, out var tradeReportText, out current))
            {
                message.AppendString(TradeReportText.FixTag, tradeReportText);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            current += Pad1.Length;

            SideAllocGrpComp.Decode(ref message, pointer, current, noSideAllocs, out current);

            TrdInstrmntLegGrpComp.Decode(ref message, pointer, current, noLegs, out current);

            return FixErrorCode.None;
        }
    }
}