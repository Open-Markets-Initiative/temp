using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Quote Events Index: Optional 1 Byte Fixed Width Integer
/// </summary>

public static class NoQuoteEventsIndex
{
    /// <summary>
    ///  Fix Tag for No Quote Events Index
    /// </summary>
    public const ushort FixTag = 25011;

    /// <summary>
    ///  Length of No Quote Events Index in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for No Quote Events Index
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode No Quote Events Index
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoQuoteEventsIndex.Length)
        {
            throw new System.Exception("Invalid Length for No Quote Events Index");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Quote Events Index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoQuoteEventsIndex.Length;
    }

    /// <summary>
    ///  Encode No Quote Events Index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Quote Events Index to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoQuoteEventsIndex.Length)
        {
            throw new System.Exception("Invalid Length for No Quote Events Index");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Quote Events Index to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NoQuoteEventsIndex.Length;
    }

    /// <summary>
    ///  Set No Quote Events Index to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode No Quote Events Index
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoQuoteEventsIndex.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Quote Events Index
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode No Quote Events Index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoQuoteEventsIndex.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Quote Events Index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
