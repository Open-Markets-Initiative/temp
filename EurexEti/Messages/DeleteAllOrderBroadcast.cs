using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delete All Order Broadcast Message Methods
    /// </summary>

    public partial class DeleteAllOrderBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Delete All Order Broadcast
        /// </summary>
        public const string Identifier = "10122";

        /// <summary>
        ///  Encode Delete All Order Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.DeleteAllOrderBroadcast, out current);

            // --- encode delete all order broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var notificationIn = message.GetULong(NotificationIn.FixTag);
            NotificationIn.Encode(pointer, current, notificationIn, out current);

            var sendingTime = message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var massActionReportId = message.GetULong(MassActionReportId.FixTag);
            MassActionReportId.Encode(pointer, current, massActionReportId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var price = message.GetDouble(Price.FixTag);
            Price.Encode(pointer, current, price, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var targetPartyIdSessionId = (uint)message.GetInt(TargetPartyIdSessionId.FixTag);
            TargetPartyIdSessionId.Encode(pointer, current, targetPartyIdSessionId, out current);

            var targetPartyIdExecutingTrader = (uint)message.GetInt(TargetPartyIdExecutingTrader.FixTag);
            TargetPartyIdExecutingTrader.Encode(pointer, current, targetPartyIdExecutingTrader, out current);

            var partyIdEnteringTrader = (uint)message.GetInt(PartyIdEnteringTrader.FixTag);
            PartyIdEnteringTrader.Encode(pointer, current, partyIdEnteringTrader, out current);

            var noNotAffectedOrders = (ushort)message.GetInt(NoNotAffectedOrders.FixTag);
            NoNotAffectedOrders.Encode(pointer, current, noNotAffectedOrders, out current);

            var noAffectedOrderRequests = (ushort)message.GetInt(NoAffectedOrderRequests.FixTag);
            NoAffectedOrderRequests.Encode(pointer, current, noAffectedOrderRequests, out current);

            var partyIdEnteringFirm = (byte)message.GetInt(PartyIdEnteringFirm.FixTag);
            PartyIdEnteringFirm.Encode(pointer, current, partyIdEnteringFirm, out current);

            var massActionReason = (byte)message.GetInt(MassActionReason.FixTag);
            MassActionReason.Encode(pointer, current, massActionReason, out current);

            var execInst = (byte)message.GetInt(ExecInst.FixTag);
            ExecInst.Encode(pointer, current, execInst, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var notAffectedOrdersGrpComp = (byte)message.GetInt(NotAffectedOrdersGrpComp.FixTag);
            NotAffectedOrdersGrpComp.Encode(message, pointer, current, notAffectedOrdersGrpComp, out current);

            var affectedOrderRequestsGrpComp = (byte)message.GetInt(AffectedOrderRequestsGrpComp.FixTag);
            AffectedOrderRequestsGrpComp.Encode(message, pointer, current, affectedOrderRequestsGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Delete All Order Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = DeleteAllOrderBroadcast.Identifier;

            // --- decode delete all order broadcast message ---

            current += Pad2.Length;

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var notificationIn = NotificationIn.Decode(pointer, current, out current);
            message.AppendULong(NotificationIn.FixTag, notificationIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new DateTime((long)sendingTime);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var massActionReportId = MassActionReportId.Decode(pointer, current, out current);
            message.AppendULong(MassActionReportId.FixTag, massActionReportId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var price = Price.Decode(pointer, current, out current);
            message.AppendDouble(Price.FixTag, price);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var targetPartyIdSessionId = (int)TargetPartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdSessionId.FixTag, targetPartyIdSessionId);

            var targetPartyIdExecutingTrader = (int)TargetPartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdExecutingTrader.FixTag, targetPartyIdExecutingTrader);

            var partyIdEnteringTrader = (int)PartyIdEnteringTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringTrader.FixTag, partyIdEnteringTrader);

            var noNotAffectedOrders = (short)NoNotAffectedOrders.Decode(pointer, current, out current);
            message.AppendInt(NoNotAffectedOrders.FixTag, noNotAffectedOrders);

            var noAffectedOrderRequests = (short)NoAffectedOrderRequests.Decode(pointer, current, out current);
            message.AppendInt(NoAffectedOrderRequests.FixTag, noAffectedOrderRequests);

            var partyIdEnteringFirm = PartyIdEnteringFirm.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);

            var massActionReason = MassActionReason.Decode(pointer, current, out current);
            message.AppendInt(MassActionReason.FixTag, massActionReason);

            var execInst = ExecInst.Decode(pointer, current, out current);
            message.AppendInt(ExecInst.FixTag, execInst);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            NotAffectedOrdersGrpComp.Decode(ref message, pointer, current, out current);

            AffectedOrderRequestsGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}