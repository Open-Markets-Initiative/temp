using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Quote Ref Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class QuoteRefPrice
{
    /// <summary>
    ///  Fix Tag for Quote Ref Price
    /// </summary>
    public const ushort FixTag = 28759;

    /// <summary>
    ///  Length of Quote Ref Price in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Quote Ref Price
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Quote Ref Price
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Quote Ref Price
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + QuoteRefPrice.Length)
        {
            throw new System.Exception("Invalid Length for Quote Ref Price");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Quote Ref Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + QuoteRefPrice.Length;
    }

    /// <summary>
    ///  Check available length and set Quote Ref Price to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + QuoteRefPrice.Length)
        {
            throw new System.Exception("Invalid Length for Quote Ref Price");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Quote Ref Price to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + QuoteRefPrice.Length;
    }

    /// <summary>
    ///  Set Quote Ref Price to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Quote Ref Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + QuoteRefPrice.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Quote Ref Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + QuoteRefPrice.Length;

        return result;
    }

    /// <summary>
    ///  Decode Quote Ref Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + QuoteRefPrice.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Quote Ref Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
