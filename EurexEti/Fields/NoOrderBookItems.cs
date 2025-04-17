using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Order Book Items: Runtime Count Field
/// </summary>

public static class NoOrderBookItems
{
    /// <summary>
    ///  Fix Tag for No Order Book Items
    /// </summary>
    public const ushort FixTag = 28769;

    /// <summary>
    ///  Length of No Order Book Items in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Order Book Items
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoOrderBookItems.Length)
        {
            throw new System.Exception("Invalid Length for No Order Book Items");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Order Book Items
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoOrderBookItems.Length;
    }

    /// <summary>
    ///  Encode No Order Book Items
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Order Book Items to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoOrderBookItems.Length)
        {
            throw new System.Exception("Invalid Length for No Order Book Items");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Order Book Items to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoOrderBookItems.Length;
    }

    /// <summary>
    ///  Set No Order Book Items to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Order Book Items
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoOrderBookItems.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Order Book Items
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Order Book Items
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoOrderBookItems.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Order Book Items
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
