using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Notification In: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class NotificationIn
{
    /// <summary>
    ///  Fix Tag for Notification In
    /// </summary>
    public const ushort FixTag = 25043;

    /// <summary>
    ///  Length of Notification In in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Notification In
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Notification In
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + NotificationIn.Length)
        {
            throw new System.Exception("Invalid Length for Notification In");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Notification In
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NotificationIn.Length;
    }

    /// <summary>
    ///  Encode Notification In
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Notification In to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NotificationIn.Length)
        {
            throw new System.Exception("Invalid Length for Notification In");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Notification In to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NotificationIn.Length;
    }

    /// <summary>
    ///  Set Notification In to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Notification In
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + NotificationIn.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Notification In
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Notification In
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NotificationIn.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Notification In
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
