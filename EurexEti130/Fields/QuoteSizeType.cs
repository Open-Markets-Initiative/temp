using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Quote Size Type: Enum
/// </summary>

public static class QuoteSizeType
{
    /// <summary>
    ///  Total Size (Quote Modification)
    /// </summary>
    public const byte TotalSize = 1;

    /// <summary>
    ///  Open Size(Quote Entry)
    /// </summary>
    public const byte OpenSize = 2;

    /// <summary>
    ///  Fix Tag for Quote Size Type
    /// </summary>
    public const ushort FixTag = 28723;

    /// <summary>
    ///  Length of Quote Size Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Quote Size Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Quote Size Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + QuoteSizeType.Length)
        {
            throw new System.Exception("Invalid Length for Quote Size Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Quote Size Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + QuoteSizeType.Length;
    }

    /// <summary>
    ///  Check available length and set Quote Size Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + QuoteSizeType.Length)
        {
            throw new System.Exception("Invalid Length for Quote Size Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Quote Size Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + QuoteSizeType.Length;
    }

    /// <summary>
    ///  Set Quote Size Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Quote Size Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + QuoteSizeType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Quote Size Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Quote Size Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + QuoteSizeType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Quote Size Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
