using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Side Allocs: Runtime Count Field
/// </summary>

public static class NoSideAllocs
{
    /// <summary>
    ///  Fix Tag for No Side Allocs
    /// </summary>
    public const ushort FixTag = 28709;

    /// <summary>
    ///  Length of No Side Allocs in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Side Allocs
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoSideAllocs.Length)
        {
            throw new System.Exception("Invalid Length for No Side Allocs");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Side Allocs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoSideAllocs.Length;
    }

    /// <summary>
    ///  Encode No Side Allocs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Side Allocs to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoSideAllocs.Length)
        {
            throw new System.Exception("Invalid Length for No Side Allocs");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Side Allocs to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoSideAllocs.Length;
    }

    /// <summary>
    ///  Set No Side Allocs to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Side Allocs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoSideAllocs.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Side Allocs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Side Allocs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoSideAllocs.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Side Allocs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
