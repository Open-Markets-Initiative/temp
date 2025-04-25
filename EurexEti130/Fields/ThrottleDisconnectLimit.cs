using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Throttle Disconnect Limit: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class ThrottleDisconnectLimit
{
    /// <summary>
    ///  Fix Tag for Throttle Disconnect Limit
    /// </summary>
    public const ushort FixTag = 25002;

    /// <summary>
    ///  Length of Throttle Disconnect Limit in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Throttle Disconnect Limit
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Throttle Disconnect Limit
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + ThrottleDisconnectLimit.Length)
        {
            throw new System.Exception("Invalid Length for Throttle Disconnect Limit");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Throttle Disconnect Limit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ThrottleDisconnectLimit.Length;
    }

    /// <summary>
    ///  Encode Throttle Disconnect Limit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Throttle Disconnect Limit to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ThrottleDisconnectLimit.Length)
        {
            throw new System.Exception("Invalid Length for Throttle Disconnect Limit");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Throttle Disconnect Limit to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ThrottleDisconnectLimit.Length;
    }

    /// <summary>
    ///  Set Throttle Disconnect Limit to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Throttle Disconnect Limit
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + ThrottleDisconnectLimit.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Throttle Disconnect Limit
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Throttle Disconnect Limit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ThrottleDisconnectLimit.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Throttle Disconnect Limit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
