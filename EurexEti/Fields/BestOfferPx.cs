using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Best Offer Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class BestOfferPx
{
    /// <summary>
    ///  Fix Tag for Best Offer Px
    /// </summary>
    public const ushort FixTag = 25133;

    /// <summary>
    ///  Length of Best Offer Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Best Offer Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Best Offer Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Best Offer Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + BestOfferPx.Length)
        {
            throw new System.Exception("Invalid Length for Best Offer Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Best Offer Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + BestOfferPx.Length;
    }

    /// <summary>
    ///  Check available length and set Best Offer Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + BestOfferPx.Length)
        {
            throw new System.Exception("Invalid Length for Best Offer Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Best Offer Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + BestOfferPx.Length;
    }

    /// <summary>
    ///  Set Best Offer Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Best Offer Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + BestOfferPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Best Offer Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + BestOfferPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Best Offer Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + BestOfferPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Best Offer Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
