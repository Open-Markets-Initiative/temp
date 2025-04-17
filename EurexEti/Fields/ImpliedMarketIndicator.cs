using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Implied Market Indicator: Enum
/// </summary>

public static class ImpliedMarketIndicator
{
    /// <summary>
    ///  Not implied
    /// </summary>
    public const byte Notimplied = 0;

    /// <summary>
    ///  Both Implied-in and Implied-out
    /// </summary>
    public const byte Impliedinout = 3;

    /// <summary>
    ///  Fix Tag for Implied Market Indicator
    /// </summary>
    public const ushort FixTag = 1144;

    /// <summary>
    ///  Length of Implied Market Indicator in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Implied Market Indicator
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Implied Market Indicator
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ImpliedMarketIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Implied Market Indicator");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Implied Market Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ImpliedMarketIndicator.Length;
    }

    /// <summary>
    ///  Check available length and set Implied Market Indicator to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ImpliedMarketIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Implied Market Indicator");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Implied Market Indicator to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ImpliedMarketIndicator.Length;
    }

    /// <summary>
    ///  Set Implied Market Indicator to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Implied Market Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ImpliedMarketIndicator.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Implied Market Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Implied Market Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ImpliedMarketIndicator.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Implied Market Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
