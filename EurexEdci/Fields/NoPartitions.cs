using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  No Partitions: Runtime Count Field
/// </summary>

public static class NoPartitions
{
    /// <summary>
    ///  Fix Tag for No Partitions
    /// </summary>
    public const ushort FixTag = 28735;

    /// <summary>
    ///  Length of No Partitions in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Partitions
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoPartitions.Length)
        {
            throw new System.Exception("Invalid Length for No Partitions");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Partitions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoPartitions.Length;
    }

    /// <summary>
    ///  Encode No Partitions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Partitions to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoPartitions.Length)
        {
            throw new System.Exception("Invalid Length for No Partitions");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Partitions to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoPartitions.Length;
    }

    /// <summary>
    ///  Set No Partitions to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Partitions
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoPartitions.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Partitions
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Partitions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoPartitions.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Partitions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
