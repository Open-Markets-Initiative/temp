using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Strike Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class StrikePrice
{
    /// <summary>
    ///  Fix Tag for Strike Price
    /// </summary>
    public const ushort FixTag = 202;

    /// <summary>
    ///  Length of Strike Price in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Strike Price
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Strike Price
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Strike Price
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + StrikePrice.Length)
        {
            throw new System.Exception("Invalid Length for Strike Price");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Strike Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + StrikePrice.Length;
    }

    /// <summary>
    ///  Check available length and set Strike Price to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + StrikePrice.Length)
        {
            throw new System.Exception("Invalid Length for Strike Price");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Strike Price to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + StrikePrice.Length;
    }

    /// <summary>
    ///  Set Strike Price to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Strike Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + StrikePrice.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Strike Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + StrikePrice.Length;

        return result;
    }

    /// <summary>
    ///  Decode Strike Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + StrikePrice.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Strike Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
