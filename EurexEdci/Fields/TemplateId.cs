using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Template Id: Enum
/// </summary>

public static class TemplateId
{
    /// <summary>
    ///  Delete Order Broadcast TemplateId
    /// </summary>
    public const ushort DeleteOrderBroadcast = 10902;

    /// <summary>
    ///  Forced Logout Notification TemplateId
    /// </summary>
    public const ushort ForcedLogoutNotification = 10012;

    /// <summary>
    ///  Heartbeat TemplateId
    /// </summary>
    public const ushort Heartbeat = 10011;

    /// <summary>
    ///  Heartbeat Notification TemplateId
    /// </summary>
    public const ushort HeartbeatNotification = 10023;

    /// <summary>
    ///  Logon Request TemplateId
    /// </summary>
    public const ushort LogonRequest = 10000;

    /// <summary>
    ///  Logon Response TemplateId
    /// </summary>
    public const ushort LogonResponse = 10001;

    /// <summary>
    ///  Logout Request TemplateId
    /// </summary>
    public const ushort LogoutRequest = 10002;

    /// <summary>
    ///  Logout Response TemplateId
    /// </summary>
    public const ushort LogoutResponse = 10003;

    /// <summary>
    ///  Order Exec Report Broadcast TemplateId
    /// </summary>
    public const ushort OrderExecReportBroadcast = 10901;

    /// <summary>
    ///  Partition List Notification TemplateId
    /// </summary>
    public const ushort PartitionListNotification = 10037;

    /// <summary>
    ///  Reject TemplateId
    /// </summary>
    public const ushort Reject = 10010;

    /// <summary>
    ///  Session List Notification TemplateId
    /// </summary>
    public const ushort SessionListNotification = 10036;

    /// <summary>
    ///  Session Status Broadcast TemplateId
    /// </summary>
    public const ushort SessionStatusBroadcast = 10903;

    /// <summary>
    ///  Fix Tag for Template Id
    /// </summary>
    public const ushort FixTag = 28500;

    /// <summary>
    ///  Length of Template Id in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Template Id
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Template Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + TemplateId.Length)
        {
            throw new System.Exception("Invalid Length for Template Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Template Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        *(ushort*) (pointer + offset) = value;

        current = offset + TemplateId.Length;
    }

    /// <summary>
    ///  Check available length and set Template Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TemplateId.Length)
        {
            throw new System.Exception("Invalid Length for Template Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Template Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TemplateId.Length;
    }

    /// <summary>
    ///  Set Template Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Template Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + TemplateId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Template Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Template Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TemplateId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Template Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
