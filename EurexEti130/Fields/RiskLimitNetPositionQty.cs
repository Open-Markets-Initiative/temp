using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Risk Limit Net Position Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class RiskLimitNetPositionQty
{
    /// <summary>
    ///  Fix Tag for Risk Limit Net Position Qty
    /// </summary>
    public const ushort FixTag = 28780;

    /// <summary>
    ///  Length of Risk Limit Net Position Qty in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Risk Limit Net Position Qty
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Risk Limit Net Position Qty
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Risk Limit Net Position Qty
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + RiskLimitNetPositionQty.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Net Position Qty");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Risk Limit Net Position Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + RiskLimitNetPositionQty.Length;
    }

    /// <summary>
    ///  Check available length and set Risk Limit Net Position Qty to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RiskLimitNetPositionQty.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Net Position Qty");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Risk Limit Net Position Qty to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RiskLimitNetPositionQty.Length;
    }

    /// <summary>
    ///  Set Risk Limit Net Position Qty to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Risk Limit Net Position Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + RiskLimitNetPositionQty.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Risk Limit Net Position Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + RiskLimitNetPositionQty.Length;

        return result;
    }

    /// <summary>
    ///  Decode Risk Limit Net Position Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RiskLimitNetPositionQty.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Risk Limit Net Position Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
