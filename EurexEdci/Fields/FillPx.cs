using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  Fill Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class FillPx
{
    /// <summary>
    ///  Fix Tag for Fill Px
    /// </summary>
    public const ushort FixTag = 1364;

    /// <summary>
    ///  Length of Fill Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Fill Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Fill Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Fill Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + FillPx.Length)
        {
            throw new System.Exception("Invalid Length for Fill Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fill Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + FillPx.Length;
    }

    /// <summary>
    ///  Check available length and set Fill Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FillPx.Length)
        {
            throw new System.Exception("Invalid Length for Fill Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fill Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FillPx.Length;
    }

    /// <summary>
    ///  Set Fill Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Fill Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + FillPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fill Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + FillPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Fill Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FillPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fill Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
