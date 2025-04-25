using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Order Entries: Runtime Count Field
/// </summary>

public static class NoOrderEntries
{
    /// <summary>
    ///  Fix Tag for No Order Entries
    /// </summary>
    public const ushort FixTag = 2428;

    /// <summary>
    ///  Length of No Order Entries in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Order Entries
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoOrderEntries.Length)
        {
            throw new System.Exception("Invalid Length for No Order Entries");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Order Entries
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoOrderEntries.Length;
    }

    /// <summary>
    ///  Encode No Order Entries
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Order Entries to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoOrderEntries.Length)
        {
            throw new System.Exception("Invalid Length for No Order Entries");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Order Entries to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoOrderEntries.Length;
    }

    /// <summary>
    ///  Set No Order Entries to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Order Entries
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoOrderEntries.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Order Entries
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Order Entries
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoOrderEntries.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Order Entries
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
