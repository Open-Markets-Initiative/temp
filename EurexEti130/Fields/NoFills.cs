using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Fills: Runtime Count Field
/// </summary>

public static class NoFills
{
    /// <summary>
    ///  Fix Tag for No Fills
    /// </summary>
    public const ushort FixTag = 1362;

    /// <summary>
    ///  Length of No Fills in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Fills
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoFills.Length)
        {
            throw new System.Exception("Invalid Length for No Fills");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Fills
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoFills.Length;
    }

    /// <summary>
    ///  Encode No Fills
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Fills to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoFills.Length)
        {
            throw new System.Exception("Invalid Length for No Fills");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Fills to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoFills.Length;
    }

    /// <summary>
    ///  Set No Fills to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Fills
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoFills.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Fills
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Fills
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoFills.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Fills
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
