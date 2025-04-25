using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Opt Attribute: Optional 1 Byte Fixed Width Integer
/// </summary>

public static class OptAttribute
{
    /// <summary>
    ///  Fix Tag for Opt Attribute
    /// </summary>
    public const ushort FixTag = 206;

    /// <summary>
    ///  Length of Opt Attribute in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Opt Attribute
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Opt Attribute
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + OptAttribute.Length)
        {
            throw new System.Exception("Invalid Length for Opt Attribute");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Opt Attribute
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + OptAttribute.Length;
    }

    /// <summary>
    ///  Encode Opt Attribute
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Opt Attribute to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OptAttribute.Length)
        {
            throw new System.Exception("Invalid Length for Opt Attribute");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Opt Attribute to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OptAttribute.Length;
    }

    /// <summary>
    ///  Set Opt Attribute to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Opt Attribute
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + OptAttribute.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Opt Attribute
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Opt Attribute
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OptAttribute.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Opt Attribute
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
