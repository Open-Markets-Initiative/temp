using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Stop Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class StopPx
{
    /// <summary>
    ///  Fix Tag for Stop Px
    /// </summary>
    public const ushort FixTag = 99;

    /// <summary>
    ///  Length of Stop Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Stop Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Stop Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Stop Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + StopPx.Length)
        {
            throw new System.Exception("Invalid Length for Stop Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Stop Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + StopPx.Length;
    }

    /// <summary>
    ///  Check available length and set Stop Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + StopPx.Length)
        {
            throw new System.Exception("Invalid Length for Stop Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Stop Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + StopPx.Length;
    }

    /// <summary>
    ///  Set Stop Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Stop Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + StopPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Stop Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + StopPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Stop Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + StopPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Stop Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
