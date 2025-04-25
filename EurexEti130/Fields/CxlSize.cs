using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Cxl Size: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class CxlSize
{
    /// <summary>
    ///  Fix Tag for Cxl Size
    /// </summary>
    public const ushort FixTag = 28788;

    /// <summary>
    ///  Length of Cxl Size in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Cxl Size
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Cxl Size
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Cxl Size
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + CxlSize.Length)
        {
            throw new System.Exception("Invalid Length for Cxl Size");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Cxl Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + CxlSize.Length;
    }

    /// <summary>
    ///  Check available length and set Cxl Size to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + CxlSize.Length)
        {
            throw new System.Exception("Invalid Length for Cxl Size");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Cxl Size to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + CxlSize.Length;
    }

    /// <summary>
    ///  Set Cxl Size to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Cxl Size
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + CxlSize.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Cxl Size
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + CxlSize.Length;

        return result;
    }

    /// <summary>
    ///  Decode Cxl Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + CxlSize.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Cxl Size
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
