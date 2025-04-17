using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Multileg Price Model: Enum
/// </summary>

public static class MultilegPriceModel
{
    /// <summary>
    ///  leg level prices provided by system
    /// </summary>
    public const byte Standard = 0;

    /// <summary>
    ///  leg level prices provided by user
    /// </summary>
    public const byte UserDefined = 1;

    /// <summary>
    ///  Fix Tag for Multileg Price Model
    /// </summary>
    public const ushort FixTag = 28750;

    /// <summary>
    ///  Length of Multileg Price Model in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Multileg Price Model
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Multileg Price Model
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + MultilegPriceModel.Length)
        {
            throw new System.Exception("Invalid Length for Multileg Price Model");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Multileg Price Model
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + MultilegPriceModel.Length;
    }

    /// <summary>
    ///  Check available length and set Multileg Price Model to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MultilegPriceModel.Length)
        {
            throw new System.Exception("Invalid Length for Multileg Price Model");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Multileg Price Model to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MultilegPriceModel.Length;
    }

    /// <summary>
    ///  Set Multileg Price Model to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Multileg Price Model
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + MultilegPriceModel.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Multileg Price Model
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Multileg Price Model
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MultilegPriceModel.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Multileg Price Model
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
