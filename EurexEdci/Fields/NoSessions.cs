using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  No Sessions: Runtime Count Field
/// </summary>

public static class NoSessions
{
    /// <summary>
    ///  Fix Tag for No Sessions
    /// </summary>
    public const ushort FixTag = 28734;

    /// <summary>
    ///  Length of No Sessions in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Sessions
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoSessions.Length)
        {
            throw new System.Exception("Invalid Length for No Sessions");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Sessions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoSessions.Length;
    }

    /// <summary>
    ///  Encode No Sessions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Sessions to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoSessions.Length)
        {
            throw new System.Exception("Invalid Length for No Sessions");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Sessions to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoSessions.Length;
    }

    /// <summary>
    ///  Set No Sessions to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Sessions
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoSessions.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Sessions
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Sessions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoSessions.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Sessions
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
