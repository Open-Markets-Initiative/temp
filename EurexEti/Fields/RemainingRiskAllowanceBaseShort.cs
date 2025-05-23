using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Remaining Risk Allowance Base Short: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class RemainingRiskAllowanceBaseShort
{
    /// <summary>
    ///  Fix Tag for Remaining Risk Allowance Base Short
    /// </summary>
    public const ushort FixTag = 35531;

    /// <summary>
    ///  Length of Remaining Risk Allowance Base Short in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Remaining Risk Allowance Base Short
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Remaining Risk Allowance Base Short
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Remaining Risk Allowance Base Short
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + RemainingRiskAllowanceBaseShort.Length)
        {
            throw new System.Exception("Invalid Length for Remaining Risk Allowance Base Short");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Remaining Risk Allowance Base Short
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + RemainingRiskAllowanceBaseShort.Length;
    }

    /// <summary>
    ///  Check available length and set Remaining Risk Allowance Base Short to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RemainingRiskAllowanceBaseShort.Length)
        {
            throw new System.Exception("Invalid Length for Remaining Risk Allowance Base Short");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Remaining Risk Allowance Base Short to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RemainingRiskAllowanceBaseShort.Length;
    }

    /// <summary>
    ///  Set Remaining Risk Allowance Base Short to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Remaining Risk Allowance Base Short
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + RemainingRiskAllowanceBaseShort.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Remaining Risk Allowance Base Short
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + RemainingRiskAllowanceBaseShort.Length;

        return result;
    }

    /// <summary>
    ///  Decode Remaining Risk Allowance Base Short
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RemainingRiskAllowanceBaseShort.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Remaining Risk Allowance Base Short
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
