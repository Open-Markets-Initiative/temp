using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Low Limit Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class LowLimitPrice
{
    /// <summary>
    ///  Fix Tag for Low Limit Price
    /// </summary>
    public const ushort FixTag = 1148;

    /// <summary>
    ///  Length of Low Limit Price in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Low Limit Price
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Low Limit Price
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Low Limit Price
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + LowLimitPrice.Length)
        {
            throw new System.Exception("Invalid Length for Low Limit Price");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Low Limit Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + LowLimitPrice.Length;
    }

    /// <summary>
    ///  Check available length and set Low Limit Price to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LowLimitPrice.Length)
        {
            throw new System.Exception("Invalid Length for Low Limit Price");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Low Limit Price to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LowLimitPrice.Length;
    }

    /// <summary>
    ///  Set Low Limit Price to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Low Limit Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + LowLimitPrice.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Low Limit Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + LowLimitPrice.Length;

        return result;
    }

    /// <summary>
    ///  Decode Low Limit Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LowLimitPrice.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Low Limit Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
