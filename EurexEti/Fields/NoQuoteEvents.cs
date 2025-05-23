using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Quote Events: Runtime Count Field
/// </summary>

public static class NoQuoteEvents
{
    /// <summary>
    ///  Fix Tag for No Quote Events
    /// </summary>
    public const ushort FixTag = 28706;

    /// <summary>
    ///  Length of No Quote Events in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Quote Events
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoQuoteEvents.Length)
        {
            throw new System.Exception("Invalid Length for No Quote Events");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Quote Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoQuoteEvents.Length;
    }

    /// <summary>
    ///  Encode No Quote Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Quote Events to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoQuoteEvents.Length)
        {
            throw new System.Exception("Invalid Length for No Quote Events");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Quote Events to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoQuoteEvents.Length;
    }

    /// <summary>
    ///  Set No Quote Events to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Quote Events
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoQuoteEvents.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Quote Events
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Quote Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoQuoteEvents.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Quote Events
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
