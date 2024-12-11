using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Tes Reversal Broadcast Message Methods
    /// </summary>

    public static partial class TesReversalBroadcast
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

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            if (message.TryGetULong(ApplSeqNum.FixTag, out var applSeqNum))
            {
                ApplSeqNum.Encode(pointer, current, applSeqNum, out current);
            }
            else
            {
                ApplSeqNum.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplSubId.FixTag, out var applSubId))
            {
                ApplSubId.Encode(pointer, current, (uint)applSubId, out current);
            }
            else
            {
                ApplSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
            {
                ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
            }
            else
            {
                ApplResendFlag.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (message.TryGetULong(ReversalInitiationTime.FixTag, out var reversalInitiationTime))
            {
                ReversalInitiationTime.Encode(pointer, current, reversalInitiationTime, out current);
            }
            else
            {
                ReversalInitiationTime.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(TrdRptStatus.FixTag, out var trdRptStatus))
            {
                TrdRptStatus.Encode(pointer, current, (byte)trdRptStatus, out current);
            }
            else
            {
                TrdRptStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ReversalCancellationReason.FixTag, out var reversalCancellationReason))
            {
                ReversalCancellationReason.Encode(pointer, current, (byte)reversalCancellationReason, out current);
            }
            else
            {
                ReversalCancellationReason.SetNull(pointer, current, out current);
            }

            var isSideAllocGrpBcComp = message.TryGetGroup(NoSideAllocs.FixTag, out var sideAllocGrpBcComp) && sideAllocGrpBcComp.sectionList.Count > 0;
            if (isSideAllocGrpBcComp)
            {
                var noSideAllocs = (byte)sideAllocGrpBcComp.sectionList.Count;
                NoSideAllocs.Encode(pointer, current, noSideAllocs, out current);
            }
            else
            {
                NoSideAllocs.Zero(pointer, current, out current);
            }

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

            if (isSideAllocGrpBcComp)
            {
                SideAllocGrpBcComp.Encode(pointer, current, sideAllocGrpBcComp, out current);
            }

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

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSeqNum.TryDecode(pointer, current, out var applSeqNum, out current))
            {
                message.AppendULong(ApplSeqNum.FixTag, applSeqNum);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
            {
                message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
            }

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad7.Length;

            if (ReversalInitiationTime.TryDecode(pointer, current, out var reversalInitiationTime, out current))
            {
                message.AppendULong(ReversalInitiationTime.FixTag, reversalInitiationTime);
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

            if (TrdRptStatus.TryDecode(pointer, current, out var trdRptStatus, out current))
            {
                message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);
            }

            if (ReversalCancellationReason.TryDecode(pointer, current, out var reversalCancellationReason, out current))
            {
                message.AppendInt(ReversalCancellationReason.FixTag, reversalCancellationReason);
            }

            var noSideAllocs = (int)NoSideAllocs.Decode(pointer, current, out current);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (ReversalReasonText.TryDecode(pointer, current, out var reversalReasonText, out current))
            {
                message.AppendString(ReversalReasonText.FixTag, reversalReasonText);
            }

            current += Pad3.Length;

            SideAllocGrpBcComp.Decode(ref message, pointer, current, noSideAllocs, out current);

            return FixErrorCode.None;
        }
    }
}