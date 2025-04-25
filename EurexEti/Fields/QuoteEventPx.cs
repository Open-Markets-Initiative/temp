using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Quote Event Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class QuoteEventPx
{
    /// <summary>
    ///  Fix Tag for Quote Event Px
    /// </summary>
    public const ushort FixTag = 28553;

    /// <summary>
    ///  Length of Quote Event Px in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Quote Event Px
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Quote Event Px
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Quote Event Px
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + QuoteEventPx.Length)
        {
            throw new System.Exception("Invalid Length for Quote Event Px");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Quote Event Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + QuoteEventPx.Length;
    }

    /// <summary>
    ///  Check available length and set Quote Event Px to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + QuoteEventPx.Length)
        {
            throw new System.Exception("Invalid Length for Quote Event Px");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Quote Event Px to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + QuoteEventPx.Length;
    }

    /// <summary>
    ///  Set Quote Event Px to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Quote Event Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + QuoteEventPx.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Quote Event Px
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + QuoteEventPx.Length;

        return result;
    }

    /// <summary>
    ///  Decode Quote Event Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + QuoteEventPx.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Quote Event Px
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
