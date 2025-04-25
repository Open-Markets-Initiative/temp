using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Related Product Complex: Enum
/// </summary>

public static class RelatedProductComplex
{
    /// <summary>
    ///  Standard Option Strategy
    /// </summary>
    public const byte Standardoptionstrategy = 2;

    /// <summary>
    ///  Non-Standard Option Strategy
    /// </summary>
    public const byte Nonstandardoptionstrategy = 3;

    /// <summary>
    ///  Volatility Strategy
    /// </summary>
    public const byte Volatilitystrategy = 4;

    /// <summary>
    ///  Futures Spread
    /// </summary>
    public const byte FuturesSpread = 5;

    /// <summary>
    ///  Inter-Product Spread
    /// </summary>
    public const byte Interproductspread = 6;

    /// <summary>
    ///  Standard Future Strategy
    /// </summary>
    public const byte Standardfuturestrategy = 7;

    /// <summary>
    ///  Pack and Bundle
    /// </summary>
    public const byte Packandbundle = 8;

    /// <summary>
    ///  Strip
    /// </summary>
    public const byte Strip = 9;

    /// <summary>
    ///  Commodity Strip
    /// </summary>
    public const byte Commoditystrip = 11;

    /// <summary>
    ///  Scaled Simple Instrument
    /// </summary>
    public const byte Scaledsimpleinstrument = 12;

    /// <summary>
    ///  Non-Standard Volatility Strategy
    /// </summary>
    public const byte Nonstandardvolatilitystrategy = 13;

    /// <summary>
    ///  Fix Tag for Related Product Complex
    /// </summary>
    public const ushort FixTag = 28587;

    /// <summary>
    ///  Length of Related Product Complex in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Related Product Complex
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Related Product Complex
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + RelatedProductComplex.Length)
        {
            throw new System.Exception("Invalid Length for Related Product Complex");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Related Product Complex
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + RelatedProductComplex.Length;
    }

    /// <summary>
    ///  Check available length and set Related Product Complex to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RelatedProductComplex.Length)
        {
            throw new System.Exception("Invalid Length for Related Product Complex");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Related Product Complex to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RelatedProductComplex.Length;
    }

    /// <summary>
    ///  Set Related Product Complex to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Related Product Complex
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + RelatedProductComplex.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Related Product Complex
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Related Product Complex
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RelatedProductComplex.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Related Product Complex
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
