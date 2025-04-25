using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Margin Based Risk Limit Long: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class MarginBasedRiskLimitLong
{
    /// <summary>
    ///  Fix Tag for Margin Based Risk Limit Long
    /// </summary>
    public const ushort FixTag = 36531;

    /// <summary>
    ///  Length of Margin Based Risk Limit Long in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Margin Based Risk Limit Long
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Margin Based Risk Limit Long
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Margin Based Risk Limit Long
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + MarginBasedRiskLimitLong.Length)
        {
            throw new System.Exception("Invalid Length for Margin Based Risk Limit Long");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Margin Based Risk Limit Long
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + MarginBasedRiskLimitLong.Length;
    }

    /// <summary>
    ///  Check available length and set Margin Based Risk Limit Long to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MarginBasedRiskLimitLong.Length)
        {
            throw new System.Exception("Invalid Length for Margin Based Risk Limit Long");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Margin Based Risk Limit Long to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MarginBasedRiskLimitLong.Length;
    }

    /// <summary>
    ///  Set Margin Based Risk Limit Long to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Margin Based Risk Limit Long
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + MarginBasedRiskLimitLong.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Margin Based Risk Limit Long
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + MarginBasedRiskLimitLong.Length;

        return result;
    }

    /// <summary>
    ///  Decode Margin Based Risk Limit Long
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MarginBasedRiskLimitLong.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Margin Based Risk Limit Long
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
