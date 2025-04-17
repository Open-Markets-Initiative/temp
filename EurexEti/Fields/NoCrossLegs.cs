using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Cross Legs: Runtime Count Field
/// </summary>

public static class NoCrossLegs
{
    /// <summary>
    ///  Fix Tag for No Cross Legs
    /// </summary>
    public const ushort FixTag = 1829;

    /// <summary>
    ///  Length of No Cross Legs in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Cross Legs
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoCrossLegs.Length)
        {
            throw new System.Exception("Invalid Length for No Cross Legs");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Cross Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoCrossLegs.Length;
    }

    /// <summary>
    ///  Encode No Cross Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Cross Legs to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoCrossLegs.Length)
        {
            throw new System.Exception("Invalid Length for No Cross Legs");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Cross Legs to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoCrossLegs.Length;
    }

    /// <summary>
    ///  Set No Cross Legs to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Cross Legs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoCrossLegs.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Cross Legs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Cross Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoCrossLegs.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Cross Legs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
