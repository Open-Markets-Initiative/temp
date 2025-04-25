using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Bid Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class BidPx
{
    /// <summary>
    ///  Fix Tag for Bid Px
    /// </summary>
    public const ushort FixTag = 132;

    /// <summary>
    ///  Length of Bid Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Bid Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Bid Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Bid Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + BidPx.Length)
        {
            throw new System.Exception("Invalid Length for Bid Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Bid Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + BidPx.Length;
    }

    /// <summary>
    ///  Check available length and set Bid Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + BidPx.Length)
        {
            throw new System.Exception("Invalid Length for Bid Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Bid Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + BidPx.Length;
    }

    /// <summary>
    ///  Set Bid Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Bid Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + BidPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Bid Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + BidPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Bid Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + BidPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Bid Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
