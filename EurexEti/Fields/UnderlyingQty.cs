using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Underlying Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class UnderlyingQty
{
    /// <summary>
    ///  Fix Tag for Underlying Qty
    /// </summary>
    public const ushort FixTag = 879;

    /// <summary>
    ///  Length of Underlying Qty in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Underlying Qty
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Underlying Qty
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Underlying Qty
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + UnderlyingQty.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Qty");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Underlying Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + UnderlyingQty.Length;
    }

    /// <summary>
    ///  Check available length and set Underlying Qty to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + UnderlyingQty.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Qty");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Underlying Qty to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + UnderlyingQty.Length;
    }

    /// <summary>
    ///  Set Underlying Qty to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Underlying Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + UnderlyingQty.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Underlying Qty
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + UnderlyingQty.Length;

        return result;
    }

    /// <summary>
    ///  Decode Underlying Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + UnderlyingQty.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Underlying Qty
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
