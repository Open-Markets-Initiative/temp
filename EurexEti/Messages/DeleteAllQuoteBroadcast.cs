using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Delete All Quote Broadcast Message Methods
/// </summary>

public static partial class DeleteAllQuoteBroadcast
{
    /// <summary>
    ///  Eti Identifier for Delete All Quote Broadcast
    /// </summary>
    public const string Identifier = "10410";

    /// <summary>
    ///  Encode Delete All Quote Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.DeleteAllQuoteBroadcast, out current);

        // --- encode delete all quote broadcast message ---

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

        if (message.TryGetInt(PartyIdEnteringTrader.FixTag, out var partyIdEnteringTrader))
        {
            PartyIdEnteringTrader.Encode(pointer, current, (uint)partyIdEnteringTrader, out current);
        }
        else
        {
            PartyIdEnteringTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TargetPartyIdExecutingTrader.FixTag, out var targetPartyIdExecutingTrader))
        {
            TargetPartyIdExecutingTrader.Encode(pointer, current, (uint)targetPartyIdExecutingTrader, out current);
        }
        else
        {
            TargetPartyIdExecutingTrader.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(MassActionReason.FixTag, out var massActionReason))
        {
            MassActionReason.Encode(pointer, current, (byte)massActionReason, out current);
        }
        else
        {
            MassActionReason.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdEnteringFirm.FixTag, out var partyIdEnteringFirm))
        {
            PartyIdEnteringFirm.Encode(pointer, current, (byte)partyIdEnteringFirm, out current);
        }
        else
        {
            PartyIdEnteringFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(TargetPartyIdDeskId.FixTag, out var targetPartyIdDeskId))
        {
            TargetPartyIdDeskId.Encode(pointer, current, targetPartyIdDeskId, out current);
        }
        else
        {
            TargetPartyIdDeskId.SetNull(pointer, current, out current);
        }

        Pad1.Encode(pointer, current, out current);

        if (isNotAffectedSecuritiesGrpComp)
        {
            NotAffectedSecuritiesGrpComp.Encode(pointer, current, notAffectedSecuritiesGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Delete All Quote Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = DeleteAllQuoteBroadcast.Identifier;

        // --- decode delete all quote broadcast message ---

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

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (TargetPartyIdSessionId.TryDecode(pointer, current, out var targetPartyIdSessionId, out current))
        {
            message.AppendInt(TargetPartyIdSessionId.FixTag, (int)targetPartyIdSessionId);
        }

        if (PartyIdEnteringTrader.TryDecode(pointer, current, out var partyIdEnteringTrader, out current))
        {
            message.AppendInt(PartyIdEnteringTrader.FixTag, (int)partyIdEnteringTrader);
        }

        if (TargetPartyIdExecutingTrader.TryDecode(pointer, current, out var targetPartyIdExecutingTrader, out current))
        {
            message.AppendInt(TargetPartyIdExecutingTrader.FixTag, (int)targetPartyIdExecutingTrader);
        }

        var noNotAffectedSecurities = (int)NoNotAffectedSecurities.Decode(pointer, current, out current);

        if (MassActionReason.TryDecode(pointer, current, out var massActionReason, out current))
        {
            message.AppendInt(MassActionReason.FixTag, massActionReason);
        }

        if (PartyIdEnteringFirm.TryDecode(pointer, current, out var partyIdEnteringFirm, out current))
        {
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);
        }

        if (TargetPartyIdDeskId.TryDecode(pointer, current, out var targetPartyIdDeskId, out current))
        {
            message.AppendString(TargetPartyIdDeskId.FixTag, targetPartyIdDeskId);
        }

        current += Pad1.Length;

        NotAffectedSecuritiesGrpComp.Decode(ref message, pointer, current, noNotAffectedSecurities, out current);

        return FixErrorCode.None;
    }
}
