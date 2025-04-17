using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Events: Runtime Count Field
/// </summary>

public static class NoEvents
{
    /// <summary>
    ///  Fix Tag for No Events
    /// </summary>
    public const ushort FixTag = 864;

    /// <summary>
    ///  Length of No Events in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Events
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoEvents.Length)
        {
            throw new System.Exception("Invalid Length for No Events");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoEvents.Length;
    }

    /// <summary>
    ///  Encode No Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Events to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoEvents.Length)
        {
            throw new System.Exception("Invalid Length for No Events");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Events to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoEvents.Length;
    }

    /// <summary>
    ///  Set No Events to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Events
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoEvents.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Events
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoEvents.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
