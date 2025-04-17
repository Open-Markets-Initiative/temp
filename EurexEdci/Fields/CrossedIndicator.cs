using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Crossed Indicator: Enum
/// </summary>

public static class CrossedIndicator
{
    /// <summary>
    ///  No crossing (Order not subject to crossing)
    /// </summary>
    public const byte Nocrossing = 0;

    /// <summary>
    ///  Cross rejected (Order subject to crossing and match prevented)
    /// </summary>
    public const byte Crossrejected = 1;

    /// <summary>
    ///  Fix Tag for Crossed Indicator
    /// </summary>
    public const ushort FixTag = 2523;

    /// <summary>
    ///  Length of Crossed Indicator in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Crossed Indicator
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Crossed Indicator
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + CrossedIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Crossed Indicator");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Crossed Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + CrossedIndicator.Length;
    }

    /// <summary>
    ///  Check available length and set Crossed Indicator to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + CrossedIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Crossed Indicator");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Crossed Indicator to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + CrossedIndicator.Length;
    }

    /// <summary>
    ///  Set Crossed Indicator to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Crossed Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + CrossedIndicator.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Crossed Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Crossed Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + CrossedIndicator.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Crossed Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
