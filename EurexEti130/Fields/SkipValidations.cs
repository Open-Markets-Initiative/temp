using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Skip Validations: Enum
/// </summary>

public static class SkipValidations
{
    /// <summary>
    ///  False
    /// </summary>
    public const byte False = 0;

    /// <summary>
    ///  True
    /// </summary>
    public const byte True = 1;

    /// <summary>
    ///  Fix Tag for Skip Validations
    /// </summary>
    public const ushort FixTag = 25034;

    /// <summary>
    ///  Length of Skip Validations in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Skip Validations
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Skip Validations
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + SkipValidations.Length)
        {
            throw new System.Exception("Invalid Length for Skip Validations");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Skip Validations
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + SkipValidations.Length;
    }

    /// <summary>
    ///  Check available length and set Skip Validations to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SkipValidations.Length)
        {
            throw new System.Exception("Invalid Length for Skip Validations");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Skip Validations to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SkipValidations.Length;
    }

    /// <summary>
    ///  Set Skip Validations to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Skip Validations
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + SkipValidations.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Skip Validations
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Skip Validations
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SkipValidations.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Skip Validations
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
