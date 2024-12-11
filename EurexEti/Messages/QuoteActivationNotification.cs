using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Activation Notification Message Methods
    /// </summary>

    public static partial class QuoteActivationNotification
    {
        /// <summary>
        ///  Eti Identifier for Quote Activation Notification
        /// </summary>
        public const string Identifier = "10411";

        /// <summary>
        ///  Encode Quote Activation Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.QuoteActivationNotification, out current);

            // --- encode quote activation notification message ---

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

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdEnteringTrader.FixTag, out var partyIdEnteringTrader))
            {
                PartyIdEnteringTrader.Encode(pointer, current, (uint)partyIdEnteringTrader, out current);
            }
            else
            {
                PartyIdEnteringTrader.SetNull(pointer, current, out current);
            }

            var isNotAffectedSecuritiesGrpComp = message.TryGetGroup(NoNotAffectedSecurities.FixTag, out var notAffectedSecuritiesGrpComp) && notAffectedSecuritiesGrpComp.sectionList.Count > 0;
            if (isNotAffectedSecuritiesGrpComp)
            {
                var noNotAffectedSecurities = (ushort)notAffectedSecuritiesGrpComp.sectionList.Count;
                NoNotAffectedSecurities.Encode(pointer, current, noNotAffectedSecurities, out current);
            }
            else
            {
                NoNotAffectedSecurities.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdEnteringFirm.FixTag, out var partyIdEnteringFirm))
            {
                PartyIdEnteringFirm.Encode(pointer, current, (byte)partyIdEnteringFirm, out current);
            }
            else
            {
                PartyIdEnteringFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MassActionType.FixTag, out var massActionType))
            {
                MassActionType.Encode(pointer, current, (byte)massActionType, out current);
            }
            else
            {
                MassActionType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MassActionSubType.FixTag, out var massActionSubType))
            {
                MassActionSubType.Encode(pointer, current, (byte)massActionSubType, out current);
            }
            else
            {
                MassActionSubType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MassActionReason.FixTag, out var massActionReason))
            {
                MassActionReason.Encode(pointer, current, (byte)massActionReason, out current);
            }
            else
            {
                MassActionReason.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            if (isNotAffectedSecuritiesGrpComp)
            {
                NotAffectedSecuritiesGrpComp.Encode(pointer, current, notAffectedSecuritiesGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Quote Activation Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = QuoteActivationNotification.Identifier;

            // --- decode quote activation notification message ---

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

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (PartyIdEnteringTrader.TryDecode(pointer, current, out var partyIdEnteringTrader, out current))
            {
                message.AppendInt(PartyIdEnteringTrader.FixTag, (int)partyIdEnteringTrader);
            }

            var noNotAffectedSecurities = (int)NoNotAffectedSecurities.Decode(pointer, current, out current);

            if (PartyIdEnteringFirm.TryDecode(pointer, current, out var partyIdEnteringFirm, out current))
            {
                message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);
            }

            if (MassActionType.TryDecode(pointer, current, out var massActionType, out current))
            {
                message.AppendInt(MassActionType.FixTag, massActionType);
            }

            if (MassActionSubType.TryDecode(pointer, current, out var massActionSubType, out current))
            {
                message.AppendInt(MassActionSubType.FixTag, massActionSubType);
            }

            if (MassActionReason.TryDecode(pointer, current, out var massActionReason, out current))
            {
                message.AppendInt(MassActionReason.FixTag, massActionReason);
            }

            current += Pad2.Length;

            NotAffectedSecuritiesGrpComp.Decode(ref message, pointer, current, noNotAffectedSecurities, out current);

            return FixErrorCode.None;
        }
    }
}