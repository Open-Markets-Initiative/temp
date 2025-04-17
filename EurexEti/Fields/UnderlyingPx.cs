using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Underlying Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class UnderlyingPx
{
    /// <summary>
    ///  Fix Tag for Underlying Px
    /// </summary>
    public const ushort FixTag = 810;

    /// <summary>
    ///  Length of Underlying Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Underlying Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Underlying Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Underlying Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + UnderlyingPx.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Underlying Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + UnderlyingPx.Length;
    }

    /// <summary>
    ///  Check available length and set Underlying Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + UnderlyingPx.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Underlying Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + UnderlyingPx.Length;
    }

    /// <summary>
    ///  Set Underlying Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Underlying Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + UnderlyingPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Underlying Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + UnderlyingPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Underlying Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + UnderlyingPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Underlying Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
