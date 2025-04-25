using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Reversal Initiation Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ReversalInitiationTime
{
    /// <summary>
    ///  Fix Tag for Reversal Initiation Time
    /// </summary>
    public const ushort FixTag = 25197;

    /// <summary>
    ///  Length of Reversal Initiation Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Reversal Initiation Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Reversal Initiation Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ReversalInitiationTime.Length)
        {
            throw new System.Exception("Invalid Length for Reversal Initiation Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Reversal Initiation Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ReversalInitiationTime.Length;
    }

    /// <summary>
    ///  Encode Reversal Initiation Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Reversal Initiation Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ReversalInitiationTime.Length)
        {
            throw new System.Exception("Invalid Length for Reversal Initiation Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Reversal Initiation Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ReversalInitiationTime.Length;
    }

    /// <summary>
    ///  Set Reversal Initiation Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Reversal Initiation Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ReversalInitiationTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Reversal Initiation Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Reversal Initiation Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ReversalInitiationTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Reversal Initiation Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
