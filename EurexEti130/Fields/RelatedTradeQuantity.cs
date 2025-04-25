using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Related Trade Quantity: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class RelatedTradeQuantity
{
    /// <summary>
    ///  Fix Tag for Related Trade Quantity
    /// </summary>
    public const ushort FixTag = 1860;

    /// <summary>
    ///  Length of Related Trade Quantity in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Related Trade Quantity
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Related Trade Quantity
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Related Trade Quantity
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + RelatedTradeQuantity.Length)
        {
            throw new System.Exception("Invalid Length for Related Trade Quantity");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Related Trade Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + RelatedTradeQuantity.Length;
    }

    /// <summary>
    ///  Check available length and set Related Trade Quantity to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RelatedTradeQuantity.Length)
        {
            throw new System.Exception("Invalid Length for Related Trade Quantity");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Related Trade Quantity to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RelatedTradeQuantity.Length;
    }

    /// <summary>
    ///  Set Related Trade Quantity to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Related Trade Quantity
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + RelatedTradeQuantity.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Related Trade Quantity
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + RelatedTradeQuantity.Length;

        return result;
    }

    /// <summary>
    ///  Decode Related Trade Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RelatedTradeQuantity.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Related Trade Quantity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
