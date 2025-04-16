namespace SRFixBase;

public static partial class Edci130
{
    /// <summary>
    ///  Decode Edci Binary to Fix Binary
    /// </summary>
    public unsafe static FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- eti message header ---

        var bodyLen = (int)Eurex.Edci.v130.BodyLen.Decode(pointer, current, out current);

        if (bodyLen + offset > length)
        {
            return FixErrorCode.PartialMessage;
        }

        var templateId = Eurex.Edci.v130.TemplateId.Decode(pointer, current, out current);

        switch (templateId)
        {
            case Eurex.Edci.v130.TemplateId.DeleteOrderBroadcast:
                return Eurex.Edci.v130.DeleteOrderBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.ForcedLogoutNotification:
                return Eurex.Edci.v130.ForcedLogoutNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.Heartbeat:
                return Eurex.Edci.v130.Heartbeat.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.HeartbeatNotification:
                return Eurex.Edci.v130.HeartbeatNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.LogonRequest:
                return Eurex.Edci.v130.LogonRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.LogonResponse:
                return Eurex.Edci.v130.LogonResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.LogoutRequest:
                return Eurex.Edci.v130.LogoutRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.LogoutResponse:
                return Eurex.Edci.v130.LogoutResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.OrderExecReportBroadcast:
                return Eurex.Edci.v130.OrderExecReportBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.PartitionListNotification:
                return Eurex.Edci.v130.PartitionListNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.Reject:
                return Eurex.Edci.v130.Reject.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.SessionListNotification:
                return Eurex.Edci.v130.SessionListNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v130.TemplateId.SessionStatusBroadcast:
                return Eurex.Edci.v130.SessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            default:
                return FixErrorCode.Decode;
        }
    }
};
