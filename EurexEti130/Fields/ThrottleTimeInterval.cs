using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Throttle Time Interval: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ThrottleTimeInterval
{
    /// <summary>
    ///  Fix Tag for Throttle Time Interval
    /// </summary>
    public const ushort FixTag = 1614;

    /// <summary>
    ///  Length of Throttle Time Interval in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Throttle Time Interval
    /// </summary>
    public const long NoValue = unchecked((long)0x8000000000000000);

    /// <summary>
    ///  Encode Throttle Time Interval
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
    {
        if (length > offset + ThrottleTimeInterval.Length)
        {
            throw new System.Exception("Invalid Length for Throttle Time Interval");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Throttle Time Interval
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ThrottleTimeInterval.Length;
    }

    /// <summary>
    ///  Encode Throttle Time Interval
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value)
    {
        *(long*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Throttle Time Interval to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ThrottleTimeInterval.Length)
        {
            throw new System.Exception("Invalid Length for Throttle Time Interval");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Throttle Time Interval to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ThrottleTimeInterval.Length;
    }

    /// <summary>
    ///  Set Throttle Time Interval to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(long*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Throttle Time Interval
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
    {
        if (length > offset + ThrottleTimeInterval.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Throttle Time Interval
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out long value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Throttle Time Interval
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ThrottleTimeInterval.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Throttle Time Interval
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset)
    {
        return *(long*) (pointer + offset);
    }
}
