using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Md Sub Book Type: Enum
/// </summary>

public static class MdSubBookType
{
    /// <summary>
    ///  Implied
    /// </summary>
    public const byte Implied = 1;

    /// <summary>
    ///  Volume Weighted Average
    /// </summary>
    public const byte VolumeWeightedAverage = 2;

    /// <summary>
    ///  Fix Tag for Md Sub Book Type
    /// </summary>
    public const ushort FixTag = 1173;

    /// <summary>
    ///  Length of Md Sub Book Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Md Sub Book Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Md Sub Book Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + MdSubBookType.Length)
        {
            throw new System.Exception("Invalid Length for Md Sub Book Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Md Sub Book Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + MdSubBookType.Length;
    }

    /// <summary>
    ///  Check available length and set Md Sub Book Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MdSubBookType.Length)
        {
            throw new System.Exception("Invalid Length for Md Sub Book Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Md Sub Book Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MdSubBookType.Length;
    }

    /// <summary>
    ///  Set Md Sub Book Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Md Sub Book Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + MdSubBookType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Md Sub Book Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Md Sub Book Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MdSubBookType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Md Sub Book Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
