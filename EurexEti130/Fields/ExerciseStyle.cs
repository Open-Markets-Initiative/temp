using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Exercise Style: Enum
/// </summary>

public static class ExerciseStyle
{
    /// <summary>
    ///  European
    /// </summary>
    public const byte European = 0;

    /// <summary>
    ///  American
    /// </summary>
    public const byte American = 1;

    /// <summary>
    ///  Fix Tag for Exercise Style
    /// </summary>
    public const ushort FixTag = 1194;

    /// <summary>
    ///  Length of Exercise Style in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Exercise Style
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Exercise Style
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ExerciseStyle.Length)
        {
            throw new System.Exception("Invalid Length for Exercise Style");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Exercise Style
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ExerciseStyle.Length;
    }

    /// <summary>
    ///  Check available length and set Exercise Style to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExerciseStyle.Length)
        {
            throw new System.Exception("Invalid Length for Exercise Style");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Exercise Style to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExerciseStyle.Length;
    }

    /// <summary>
    ///  Set Exercise Style to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Exercise Style
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ExerciseStyle.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Exercise Style
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Exercise Style
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExerciseStyle.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Exercise Style
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
