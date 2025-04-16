namespace SRFixBase;

public static partial class Edci130
{
    /// <summary>
    ///  Encode Payload
    /// </summary>
    public unsafe static void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        switch (message.msgType)
        {
            case Eurex.Edci.v130.DeleteOrderBroadcast.Identifier:
                Eurex.Edci.v130.DeleteOrderBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.ForcedLogoutNotification.Identifier:
                Eurex.Edci.v130.ForcedLogoutNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.Heartbeat.Identifier:
                Eurex.Edci.v130.Heartbeat.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.HeartbeatNotification.Identifier:
                Eurex.Edci.v130.HeartbeatNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.LogonRequest.Identifier:
                Eurex.Edci.v130.LogonRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.LogonResponse.Identifier:
                Eurex.Edci.v130.LogonResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.LogoutRequest.Identifier:
                Eurex.Edci.v130.LogoutRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.LogoutResponse.Identifier:
                Eurex.Edci.v130.LogoutResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.OrderExecReportBroadcast.Identifier:
                Eurex.Edci.v130.OrderExecReportBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.PartitionListNotification.Identifier:
                Eurex.Edci.v130.PartitionListNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.Reject.Identifier:
                Eurex.Edci.v130.Reject.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.SessionListNotification.Identifier:
                Eurex.Edci.v130.SessionListNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.Edci.v130.SessionStatusBroadcast.Identifier:
                Eurex.Edci.v130.SessionStatusBroadcast.Encode(message, pointer, current, out current);
                break;

            default:
                throw new System.Exception("Unknown Edci Message Type");
        }
    }
};
