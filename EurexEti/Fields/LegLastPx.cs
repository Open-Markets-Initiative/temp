using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Leg Last Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class LegLastPx
{
    /// <summary>
    ///  Fix Tag for Leg Last Px
    /// </summary>
    public const ushort FixTag = 637;

    /// <summary>
    ///  Length of Leg Last Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Leg Last Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Leg Last Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Leg Last Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + LegLastPx.Length)
        {
            throw new System.Exception("Invalid Length for Leg Last Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Leg Last Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + LegLastPx.Length;
    }

    /// <summary>
    ///  Check available length and set Leg Last Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LegLastPx.Length)
        {
            throw new System.Exception("Invalid Length for Leg Last Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Leg Last Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LegLastPx.Length;
    }

    /// <summary>
    ///  Set Leg Last Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Leg Last Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + LegLastPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Leg Last Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + LegLastPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Leg Last Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LegLastPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Leg Last Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
