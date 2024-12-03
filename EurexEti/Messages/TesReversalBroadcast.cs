using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Tes Reversal Broadcast Message Methods
    /// </summary>

    public partial class TesReversalBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Tes Reversal Broadcast
        /// </summary>
        public const string Identifier = "10632";

        /// <summary>
        ///  Encode Tes Reversal Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.TesReversalBroadcast, out current);

            // --- encode tes reversal broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSeqNum = message.GetULong(ApplSeqNum.FixTag);
            ApplSeqNum.Encode(pointer, current, applSeqNum, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var reversalInitiationTime = message.GetULong(ReversalInitiationTime.FixTag);
            ReversalInitiationTime.Encode(pointer, current, reversalInitiationTime, out current);

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

            var trdRptStatus = (byte)message.GetInt(TrdRptStatus.FixTag);
            TrdRptStatus.Encode(pointer, current, trdRptStatus, out current);

            var reversalCancellationReason = (byte)message.GetInt(ReversalCancellationReason.FixTag);
            ReversalCancellationReason.Encode(pointer, current, reversalCancellationReason, out current);

            var noSideAllocs = (byte)message.GetInt(NoSideAllocs.FixTag);
            NoSideAllocs.Encode(pointer, current, noSideAllocs, out current);

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

            Pad3.Encode(pointer, current, out current);

            var sideAllocGrpBcComp = (byte)message.GetInt(SideAllocGrpBcComp.FixTag);
            SideAllocGrpBcComp.Encode(message, pointer, current, sideAllocGrpBcComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Tes Reversal Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = TesReversalBroadcast.Identifier;

            // --- decode tes reversal broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var applSeqNum = ApplSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplSeqNum.FixTag, applSeqNum);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var reversalInitiationTime = ReversalInitiationTime.Decode(pointer, current, out current);
            message.AppendULong(ReversalInitiationTime.FixTag, reversalInitiationTime);

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

            var trdRptStatus = TrdRptStatus.Decode(pointer, current, out current);
            message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);

            var reversalCancellationReason = ReversalCancellationReason.Decode(pointer, current, out current);
            message.AppendInt(ReversalCancellationReason.FixTag, reversalCancellationReason);

            var noSideAllocs = NoSideAllocs.Decode(pointer, current, out current);
            message.AppendInt(NoSideAllocs.FixTag, noSideAllocs);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (ReversalReasonText.TryDecode(pointer, current, out var reversalReasonText, out current))
            {
                message.AppendString(ReversalReasonText.FixTag, reversalReasonText);
            }

            current += Pad3.Length;

            SideAllocGrpBcComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}