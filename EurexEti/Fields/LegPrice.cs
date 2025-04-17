using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Leg Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class LegPrice
{
    /// <summary>
    ///  Fix Tag for Leg Price
    /// </summary>
    public const ushort FixTag = 566;

    /// <summary>
    ///  Length of Leg Price in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Leg Price
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Leg Price
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Leg Price
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + LegPrice.Length)
        {
            throw new System.Exception("Invalid Length for Leg Price");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Leg Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + LegPrice.Length;
    }

    /// <summary>
    ///  Check available length and set Leg Price to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LegPrice.Length)
        {
            throw new System.Exception("Invalid Length for Leg Price");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Leg Price to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LegPrice.Length;
    }

    /// <summary>
    ///  Set Leg Price to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Leg Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + LegPrice.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Leg Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + LegPrice.Length;

        return result;
    }

    /// <summary>
    ///  Decode Leg Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LegPrice.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Leg Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
