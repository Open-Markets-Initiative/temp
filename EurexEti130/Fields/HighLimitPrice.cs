using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  High Limit Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class HighLimitPrice
{
    /// <summary>
    ///  Fix Tag for High Limit Price
    /// </summary>
    public const ushort FixTag = 1149;

    /// <summary>
    ///  Length of High Limit Price in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for High Limit Price
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for High Limit Price
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode High Limit Price
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + HighLimitPrice.Length)
        {
            throw new System.Exception("Invalid Length for High Limit Price");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode High Limit Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + HighLimitPrice.Length;
    }

    /// <summary>
    ///  Check available length and set High Limit Price to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + HighLimitPrice.Length)
        {
            throw new System.Exception("Invalid Length for High Limit Price");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set High Limit Price to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + HighLimitPrice.Length;
    }

    /// <summary>
    ///  Set High Limit Price to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode High Limit Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + HighLimitPrice.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode High Limit Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + HighLimitPrice.Length;

        return result;
    }

    /// <summary>
    ///  Decode High Limit Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + HighLimitPrice.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode High Limit Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
