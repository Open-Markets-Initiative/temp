using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Activation Notification Message Methods
    /// </summary>

    public partial class QuoteActivationNotification
    {
        /// <summary>
        ///  Eti Identifier for Quote Activation Notification
        /// </summary>
        public const string Identifier = "Quote Activation Notification";

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

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var notificationIn = message.GetULong(NotificationIn.FixTag);
            NotificationIn.Encode(pointer, current, notificationIn, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
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

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var partyIdEnteringTrader = (uint)message.GetInt(PartyIdEnteringTrader.FixTag);
            PartyIdEnteringTrader.Encode(pointer, current, partyIdEnteringTrader, out current);

            var noNotAffectedSecurities = (ushort)message.GetInt(NoNotAffectedSecurities.FixTag);
            NoNotAffectedSecurities.Encode(pointer, current, noNotAffectedSecurities, out current);

            var partyIdEnteringFirm = (byte)message.GetInt(PartyIdEnteringFirm.FixTag);
            PartyIdEnteringFirm.Encode(pointer, current, partyIdEnteringFirm, out current);

            var massActionType = (byte)message.GetInt(MassActionType.FixTag);
            MassActionType.Encode(pointer, current, massActionType, out current);

            var massActionSubType = (byte)message.GetInt(MassActionSubType.FixTag);
            MassActionSubType.Encode(pointer, current, massActionSubType, out current);

            var massActionReason = (byte)message.GetInt(MassActionReason.FixTag);
            MassActionReason.Encode(pointer, current, massActionReason, out current);

            Pad2.Encode(pointer, current, out current);

            var notAffectedSecurityId = group.GetULong(NotAffectedSecurityId.FixTag);
            NotAffectedSecurityId.Encode(pointer, current, notAffectedSecurityId, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
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

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var notificationIn = NotificationIn.Decode(pointer, current, out current);
            message.AppendULong(NotificationIn.FixTag, notificationIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

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

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var partyIdEnteringTrader = (int)PartyIdEnteringTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringTrader.FixTag, partyIdEnteringTrader);

            var noNotAffectedSecurities = (short)NoNotAffectedSecurities.Decode(pointer, current, out current);
            message.AppendInt(NoNotAffectedSecurities.FixTag, noNotAffectedSecurities);

            var partyIdEnteringFirm = PartyIdEnteringFirm.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);

            var massActionType = MassActionType.Decode(pointer, current, out current);
            message.AppendInt(MassActionType.FixTag, massActionType);

            var massActionSubType = MassActionSubType.Decode(pointer, current, out current);
            message.AppendInt(MassActionSubType.FixTag, massActionSubType);

            var massActionReason = MassActionReason.Decode(pointer, current, out current);
            message.AppendInt(MassActionReason.FixTag, massActionReason);

            current += Pad2.Length;

            var notAffectedSecurityId = NotAffectedSecurityId.Decode(pointer, current, out current);
            message.AppendULong(NotAffectedSecurityId.FixTag, notAffectedSecurityId);

            return FixErrorCode.None;
        }
    }
}