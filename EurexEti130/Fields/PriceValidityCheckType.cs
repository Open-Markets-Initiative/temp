using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Price Validity Check Type: Enum
/// </summary>

public static class PriceValidityCheckType
{
    /// <summary>
    ///  None
    /// </summary>
    public const byte None = 0;

    /// <summary>
    ///  Optional
    /// </summary>
    public const byte Optional = 1;

    /// <summary>
    ///  Mandatory
    /// </summary>
    public const byte Mandatory = 2;

    /// <summary>
    ///  Fix Tag for Price Validity Check Type
    /// </summary>
    public const ushort FixTag = 28710;

    /// <summary>
    ///  Length of Price Validity Check Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Price Validity Check Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Price Validity Check Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + PriceValidityCheckType.Length)
        {
            throw new System.Exception("Invalid Length for Price Validity Check Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Price Validity Check Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + PriceValidityCheckType.Length;
    }

    /// <summary>
    ///  Check available length and set Price Validity Check Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PriceValidityCheckType.Length)
        {
            throw new System.Exception("Invalid Length for Price Validity Check Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Price Validity Check Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + PriceValidityCheckType.Length;
    }

    /// <summary>
    ///  Set Price Validity Check Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Price Validity Check Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + PriceValidityCheckType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Price Validity Check Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Price Validity Check Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PriceValidityCheckType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Price Validity Check Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
