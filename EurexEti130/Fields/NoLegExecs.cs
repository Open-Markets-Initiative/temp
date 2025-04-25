using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Leg Execs: Runtime Count Field
/// </summary>

public static class NoLegExecs
{
    /// <summary>
    ///  Fix Tag for No Leg Execs
    /// </summary>
    public const ushort FixTag = 30555;

    /// <summary>
    ///  Length of No Leg Execs in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Leg Execs
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoLegExecs.Length)
        {
            throw new System.Exception("Invalid Length for No Leg Execs");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Leg Execs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoLegExecs.Length;
    }

    /// <summary>
    ///  Encode No Leg Execs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Leg Execs to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoLegExecs.Length)
        {
            throw new System.Exception("Invalid Length for No Leg Execs");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Leg Execs to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoLegExecs.Length;
    }

    /// <summary>
    ///  Set No Leg Execs to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Leg Execs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoLegExecs.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Leg Execs
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Leg Execs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoLegExecs.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Leg Execs
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
