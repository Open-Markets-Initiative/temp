using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Vega: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class Vega
{
    /// <summary>
    ///  Fix Tag for Vega
    /// </summary>
    public const ushort FixTag = 7968;

    /// <summary>
    ///  Length of Vega in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Vega
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Vega
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Vega
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + Vega.Length)
        {
            throw new System.Exception("Invalid Length for Vega");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Vega
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + Vega.Length;
    }

    /// <summary>
    ///  Check available length and set Vega to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + Vega.Length)
        {
            throw new System.Exception("Invalid Length for Vega");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Vega to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + Vega.Length;
    }

    /// <summary>
    ///  Set Vega to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Vega
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + Vega.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Vega
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + Vega.Length;

        return result;
    }

    /// <summary>
    ///  Decode Vega
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Vega.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Vega
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
