using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  Cxl Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class CxlQty
{
    /// <summary>
    ///  Fix Tag for Cxl Qty
    /// </summary>
    public const ushort FixTag = 84;

    /// <summary>
    ///  Length of Cxl Qty in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Cxl Qty
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Cxl Qty
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Cxl Qty
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + CxlQty.Length)
        {
            throw new System.Exception("Invalid Length for Cxl Qty");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Cxl Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + CxlQty.Length;
    }

    /// <summary>
    ///  Check available length and set Cxl Qty to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + CxlQty.Length)
        {
            throw new System.Exception("Invalid Length for Cxl Qty");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Cxl Qty to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + CxlQty.Length;
    }

    /// <summary>
    ///  Set Cxl Qty to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Cxl Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + CxlQty.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Cxl Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + CxlQty.Length;

        return result;
    }

    /// <summary>
    ///  Decode Cxl Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + CxlQty.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Cxl Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
