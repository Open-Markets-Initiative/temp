using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Netting Coefficient: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class NettingCoefficient
{
    /// <summary>
    ///  Fix Tag for Netting Coefficient
    /// </summary>
    public const ushort FixTag = 25205;

    /// <summary>
    ///  Length of Netting Coefficient in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Netting Coefficient
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Netting Coefficient
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Netting Coefficient
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + NettingCoefficient.Length)
        {
            throw new System.Exception("Invalid Length for Netting Coefficient");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Netting Coefficient
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + NettingCoefficient.Length;
    }

    /// <summary>
    ///  Check available length and set Netting Coefficient to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NettingCoefficient.Length)
        {
            throw new System.Exception("Invalid Length for Netting Coefficient");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Netting Coefficient to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NettingCoefficient.Length;
    }

    /// <summary>
    ///  Set Netting Coefficient to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Netting Coefficient
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + NettingCoefficient.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Netting Coefficient
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + NettingCoefficient.Length;

        return result;
    }

    /// <summary>
    ///  Decode Netting Coefficient
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NettingCoefficient.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Netting Coefficient
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
