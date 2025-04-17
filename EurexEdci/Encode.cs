namespace SRFixBase;

public static partial class Edci131
{
    /// <summary>
    ///  Encode Payload
    /// </summary>
    public unsafe static void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        switch (message.msgType)
        {
            case Eurex.Edci.v131.DeleteOrderBroadcast.Identifier:
                Eurex.Edci.v131.DeleteOrderBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.ForcedLogoutNotification.Identifier:
                Eurex.Edci.v131.ForcedLogoutNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.Heartbeat.Identifier:
                Eurex.Edci.v131.Heartbeat.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.HeartbeatNotification.Identifier:
                Eurex.Edci.v131.HeartbeatNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.LogonRequest.Identifier:
                Eurex.Edci.v131.LogonRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.LogonResponse.Identifier:
                Eurex.Edci.v131.LogonResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.LogoutRequest.Identifier:
                Eurex.Edci.v131.LogoutRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.LogoutResponse.Identifier:
                Eurex.Edci.v131.LogoutResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.OrderExecReportBroadcast.Identifier:
                Eurex.Edci.v131.OrderExecReportBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.PartitionListNotification.Identifier:
                Eurex.Edci.v131.PartitionListNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.Reject.Identifier:
                Eurex.Edci.v131.Reject.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.SessionListNotification.Identifier:
                Eurex.Edci.v131.SessionListNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Edci.v131.SessionStatusBroadcast.Identifier:
                Eurex.Edci.v131.SessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            default:
                throw new System.Exception("Unknown Edci Message Type");
        }
    }
};
