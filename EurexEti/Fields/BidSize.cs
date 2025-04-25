using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Bid Size: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class BidSize
{
    /// <summary>
    ///  Fix Tag for Bid Size
    /// </summary>
    public const ushort FixTag = 134;

    /// <summary>
    ///  Length of Bid Size in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Bid Size
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Bid Size
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Bid Size
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + BidSize.Length)
        {
            throw new System.Exception("Invalid Length for Bid Size");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + BidSize.Length;
    }

    /// <summary>
    ///  Check available length and set Bid Size to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + BidSize.Length)
        {
            throw new System.Exception("Invalid Length for Bid Size");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Bid Size to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + BidSize.Length;
    }

    /// <summary>
    ///  Set Bid Size to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Bid Size
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + BidSize.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Bid Size
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + BidSize.Length;

        return result;
    }

    /// <summary>
    ///  Decode Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + BidSize.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Bid Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
