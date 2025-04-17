using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Legs: Runtime Count Field
/// </summary>

public static class NoLegs
{
    /// <summary>
    ///  Fix Tag for No Legs
    /// </summary>
    public const ushort FixTag = 555;

    /// <summary>
    ///  Length of No Legs in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Legs
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoLegs.Length)
        {
            throw new System.Exception("Invalid Length for No Legs");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoLegs.Length;
    }

    /// <summary>
    ///  Encode No Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Legs to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoLegs.Length)
        {
            throw new System.Exception("Invalid Length for No Legs");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Legs to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoLegs.Length;
    }

    /// <summary>
    ///  Set No Legs to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Legs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoLegs.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Legs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoLegs.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
