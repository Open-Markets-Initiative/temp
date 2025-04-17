using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Last Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class LastPx
{
    /// <summary>
    ///  Fix Tag for Last Px
    /// </summary>
    public const ushort FixTag = 31;

    /// <summary>
    ///  Length of Last Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Last Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Last Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Last Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + LastPx.Length)
        {
            throw new System.Exception("Invalid Length for Last Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Last Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + LastPx.Length;
    }

    /// <summary>
    ///  Check available length and set Last Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LastPx.Length)
        {
            throw new System.Exception("Invalid Length for Last Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Last Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LastPx.Length;
    }

    /// <summary>
    ///  Set Last Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Last Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + LastPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Last Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + LastPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Last Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LastPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Last Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
