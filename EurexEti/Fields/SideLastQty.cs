using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Side Last Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class SideLastQty
{
    /// <summary>
    ///  Fix Tag for Side Last Qty
    /// </summary>
    public const ushort FixTag = 1009;

    /// <summary>
    ///  Length of Side Last Qty in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Side Last Qty
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Side Last Qty
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Side Last Qty
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + SideLastQty.Length)
        {
            throw new System.Exception("Invalid Length for Side Last Qty");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Side Last Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + SideLastQty.Length;
    }

    /// <summary>
    ///  Check available length and set Side Last Qty to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SideLastQty.Length)
        {
            throw new System.Exception("Invalid Length for Side Last Qty");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Side Last Qty to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SideLastQty.Length;
    }

    /// <summary>
    ///  Set Side Last Qty to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Side Last Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + SideLastQty.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Side Last Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + SideLastQty.Length;

        return result;
    }

    /// <summary>
    ///  Decode Side Last Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SideLastQty.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Side Last Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
