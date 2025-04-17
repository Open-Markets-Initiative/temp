namespace SRFixBase;

public static partial class Edci131
{
    /// <summary>
    ///  Decode Edci Binary to Fix Binary
    /// </summary>
    public unsafe static FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- eti message header ---

        var bodyLen = (int)Eurex.Edci.v131.BodyLen.Decode(pointer, current, out current);

        if (bodyLen + offset > length)
        {
            return FixErrorCode.PartialMessage;
        }

        var templateId = Eurex.Edci.v131.TemplateId.Decode(pointer, current, out current);

        switch (templateId)
        {
            case Eurex.Edci.v131.TemplateId.DeleteOrderBroadcast:
                return Eurex.Edci.v131.DeleteOrderBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.ForcedLogoutNotification:
                return Eurex.Edci.v131.ForcedLogoutNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.Heartbeat:
                return Eurex.Edci.v131.Heartbeat.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.HeartbeatNotification:
                return Eurex.Edci.v131.HeartbeatNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.LogonRequest:
                return Eurex.Edci.v131.LogonRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.LogonResponse:
                return Eurex.Edci.v131.LogonResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.LogoutRequest:
                return Eurex.Edci.v131.LogoutRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.LogoutResponse:
                return Eurex.Edci.v131.LogoutResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.OrderExecReportBroadcast:
                return Eurex.Edci.v131.OrderExecReportBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.PartitionListNotification:
                return Eurex.Edci.v131.PartitionListNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.Reject:
                return Eurex.Edci.v131.Reject.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.SessionListNotification:
                return Eurex.Edci.v131.SessionListNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Edci.v131.TemplateId.SessionStatusBroadcast:
                return Eurex.Edci.v131.SessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            default:
                return FixErrorCode.Decode;
        }
    }
};
