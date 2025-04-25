using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Negotiation Start Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class NegotiationStartTime
{
    /// <summary>
    ///  Fix Tag for Negotiation Start Time
    /// </summary>
    public const ushort FixTag = 28764;

    /// <summary>
    ///  Length of Negotiation Start Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Negotiation Start Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Negotiation Start Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + NegotiationStartTime.Length)
        {
            throw new System.Exception("Invalid Length for Negotiation Start Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Negotiation Start Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NegotiationStartTime.Length;
    }

    /// <summary>
    ///  Encode Negotiation Start Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Negotiation Start Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NegotiationStartTime.Length)
        {
            throw new System.Exception("Invalid Length for Negotiation Start Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Negotiation Start Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NegotiationStartTime.Length;
    }

    /// <summary>
    ///  Set Negotiation Start Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Negotiation Start Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + NegotiationStartTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Negotiation Start Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Negotiation Start Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NegotiationStartTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Negotiation Start Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
