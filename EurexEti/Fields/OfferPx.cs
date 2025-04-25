using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Offer Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class OfferPx
{
    /// <summary>
    ///  Fix Tag for Offer Px
    /// </summary>
    public const ushort FixTag = 133;

    /// <summary>
    ///  Length of Offer Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Offer Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Offer Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Offer Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + OfferPx.Length)
        {
            throw new System.Exception("Invalid Length for Offer Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Offer Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + OfferPx.Length;
    }

    /// <summary>
    ///  Check available length and set Offer Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OfferPx.Length)
        {
            throw new System.Exception("Invalid Length for Offer Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Offer Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OfferPx.Length;
    }

    /// <summary>
    ///  Set Offer Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Offer Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + OfferPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Offer Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + OfferPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Offer Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OfferPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Offer Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
