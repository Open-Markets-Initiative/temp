using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Order Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class OrderQty
{
    /// <summary>
    ///  Fix Tag for Order Qty
    /// </summary>
    public const ushort FixTag = 38;

    /// <summary>
    ///  Length of Order Qty in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Order Qty
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Order Qty
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Order Qty
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + OrderQty.Length)
        {
            throw new System.Exception("Invalid Length for Order Qty");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Order Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + OrderQty.Length;
    }

    /// <summary>
    ///  Check available length and set Order Qty to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrderQty.Length)
        {
            throw new System.Exception("Invalid Length for Order Qty");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Order Qty to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrderQty.Length;
    }

    /// <summary>
    ///  Set Order Qty to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Order Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + OrderQty.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Order Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + OrderQty.Length;

        return result;
    }

    /// <summary>
    ///  Decode Order Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrderQty.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Order Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
