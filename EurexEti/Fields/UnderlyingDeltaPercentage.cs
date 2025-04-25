using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Underlying Delta Percentage: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class UnderlyingDeltaPercentage
{
    /// <summary>
    ///  Fix Tag for Underlying Delta Percentage
    /// </summary>
    public const ushort FixTag = 25149;

    /// <summary>
    ///  Length of Underlying Delta Percentage in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Underlying Delta Percentage
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Underlying Delta Percentage
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Underlying Delta Percentage
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + UnderlyingDeltaPercentage.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Delta Percentage");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Underlying Delta Percentage
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + UnderlyingDeltaPercentage.Length;
    }

    /// <summary>
    ///  Check available length and set Underlying Delta Percentage to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + UnderlyingDeltaPercentage.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Delta Percentage");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Underlying Delta Percentage to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + UnderlyingDeltaPercentage.Length;
    }

    /// <summary>
    ///  Set Underlying Delta Percentage to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Underlying Delta Percentage
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + UnderlyingDeltaPercentage.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Underlying Delta Percentage
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + UnderlyingDeltaPercentage.Length;

        return result;
    }

    /// <summary>
    ///  Decode Underlying Delta Percentage
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + UnderlyingDeltaPercentage.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Underlying Delta Percentage
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
