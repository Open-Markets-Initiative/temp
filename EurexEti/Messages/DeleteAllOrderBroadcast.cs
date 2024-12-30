using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delete All Order Broadcast Message Methods
    /// </summary>

    public static partial class DeleteAllOrderBroadcast
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

            if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
            {
                TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
            }
            else
            {
                TrdRegTsTimeOut.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(NotificationIn.FixTag, out var notificationIn))
            {
                NotificationIn.Encode(pointer, current, notificationIn, out current);
            }
            else
            {
                NotificationIn.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

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

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
            {
                ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
            }
            else
            {
                ApplResendFlag.SetNull(pointer, current, out current);
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

            if (message.TryGetULong(MassActionReportId.FixTag, out var massActionReportId))
            {
                MassActionReportId.Encode(pointer, current, massActionReportId, out current);
            }
            else
            {
                MassActionReportId.SetNull(pointer, current, out current);
            }

            if (message.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(Price.FixTag, out var price))
            {
                Price.Encode(pointer, current, price, out current);
            }
            else
            {
                Price.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TargetPartyIdSessionId.FixTag, out var targetPartyIdSessionId))
            {
                TargetPartyIdSessionId.Encode(pointer, current, (uint)targetPartyIdSessionId, out current);
            }
            else
            {
                TargetPartyIdSessionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TargetPartyIdExecutingTrader.FixTag, out var targetPartyIdExecutingTrader))
            {
                TargetPartyIdExecutingTrader.Encode(pointer, current, (uint)targetPartyIdExecutingTrader, out current);
            }
            else
            {
                TargetPartyIdExecutingTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdEnteringTrader.FixTag, out var partyIdEnteringTrader))
            {
                PartyIdEnteringTrader.Encode(pointer, current, (uint)partyIdEnteringTrader, out current);
            }
            else
            {
                PartyIdEnteringTrader.SetNull(pointer, current, out current);
            }

            var isNotAffectedOrdersGrpComp = message.TryGetGroup(NoNotAffectedOrders.FixTag, out var notAffectedOrdersGrpComp) && notAffectedOrdersGrpComp.sectionList.Count > 0;
            if (isNotAffectedOrdersGrpComp)
            {
                var noNotAffectedOrders = (ushort)notAffectedOrdersGrpComp.sectionList.Count;
                NoNotAffectedOrders.Encode(pointer, current, noNotAffectedOrders, out current);
            }
            else
            {
                NoNotAffectedOrders.Zero(pointer, current, out current);
            }

            var isAffectedOrderRequestsGrpComp = message.TryGetGroup(NoAffectedOrderRequests.FixTag, out var affectedOrderRequestsGrpComp) && affectedOrderRequestsGrpComp.sectionList.Count > 0;
            if (isAffectedOrderRequestsGrpComp)
            {
                var noAffectedOrderRequests = (ushort)affectedOrderRequestsGrpComp.sectionList.Count;
                NoAffectedOrderRequests.Encode(pointer, current, noAffectedOrderRequests, out current);
            }
            else
            {
                NoAffectedOrderRequests.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdEnteringFirm.FixTag, out var partyIdEnteringFirm))
            {
                PartyIdEnteringFirm.Encode(pointer, current, (byte)partyIdEnteringFirm, out current);
            }
            else
            {
                PartyIdEnteringFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MassActionReason.FixTag, out var massActionReason))
            {
                MassActionReason.Encode(pointer, current, (byte)massActionReason, out current);
            }
            else
            {
                MassActionReason.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ExecInst.FixTag, out var execInst))
            {
                ExecInst.Encode(pointer, current, (byte)execInst, out current);
            }
            else
            {
                ExecInst.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(Side.FixTag, out var side))
            {
                Side.Encode(pointer, current, (byte)side, out current);
            }
            else
            {
                Side.SetNull(pointer, current, out current);
            }

            if (isNotAffectedOrdersGrpComp)
            {
                NotAffectedOrdersGrpComp.Encode(pointer, current, notAffectedOrdersGrpComp, out current);
            }

            if (isAffectedOrderRequestsGrpComp)
            {
                AffectedOrderRequestsGrpComp.Encode(pointer, current, affectedOrderRequestsGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Delete All Order Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = DeleteAllOrderBroadcast.Identifier;

            // --- decode delete all order broadcast message ---

            current += Pad2.Length;

            if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
            {
                message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
            }

            if (NotificationIn.TryDecode(pointer, current, out var notificationIn, out current))
            {
                message.AppendULong(NotificationIn.FixTag, notificationIn);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
            {
                message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad7.Length;

            if (MassActionReportId.TryDecode(pointer, current, out var massActionReportId, out current))
            {
                message.AppendULong(MassActionReportId.FixTag, massActionReportId);
            }

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (Price.TryDecode(pointer, current, out var price, out current))
            {
                message.AppendDouble(Price.FixTag, price);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (TargetPartyIdSessionId.TryDecode(pointer, current, out var targetPartyIdSessionId, out current))
            {
                message.AppendInt(TargetPartyIdSessionId.FixTag, (int)targetPartyIdSessionId);
            }

            if (TargetPartyIdExecutingTrader.TryDecode(pointer, current, out var targetPartyIdExecutingTrader, out current))
            {
                message.AppendInt(TargetPartyIdExecutingTrader.FixTag, (int)targetPartyIdExecutingTrader);
            }

            if (PartyIdEnteringTrader.TryDecode(pointer, current, out var partyIdEnteringTrader, out current))
            {
                message.AppendInt(PartyIdEnteringTrader.FixTag, (int)partyIdEnteringTrader);
            }

            var noNotAffectedOrders = (int)NoNotAffectedOrders.Decode(pointer, current, out current);

            var noAffectedOrderRequests = (int)NoAffectedOrderRequests.Decode(pointer, current, out current);

            if (PartyIdEnteringFirm.TryDecode(pointer, current, out var partyIdEnteringFirm, out current))
            {
                message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);
            }

            if (MassActionReason.TryDecode(pointer, current, out var massActionReason, out current))
            {
                message.AppendInt(MassActionReason.FixTag, massActionReason);
            }

            if (ExecInst.TryDecode(pointer, current, out var execInst, out current))
            {
                message.AppendInt(ExecInst.FixTag, execInst);
            }

            if (Side.TryDecode(pointer, current, out var side, out current))
            {
                message.AppendInt(Side.FixTag, side);
            }

            NotAffectedOrdersGrpComp.Decode(ref message, pointer, current, noNotAffectedOrders, out current);

            AffectedOrderRequestsGrpComp.Decode(ref message, pointer, current, noAffectedOrderRequests, out current);

            return FixErrorCode.None;
        }
    }
}