using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Quote Cancel Reason: Enum
/// </summary>

public static class QuoteCancelReason
{
    /// <summary>
    ///  Expired
    /// </summary>
    public const byte Expired = 5;

    /// <summary>
    ///  Fix Tag for Quote Cancel Reason
    /// </summary>
    public const ushort FixTag = 28747;

    /// <summary>
    ///  Length of Quote Cancel Reason in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Quote Cancel Reason
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Quote Cancel Reason
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + QuoteCancelReason.Length)
        {
            throw new System.Exception("Invalid Length for Quote Cancel Reason");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Quote Cancel Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + QuoteCancelReason.Length;
    }

    /// <summary>
    ///  Check available length and set Quote Cancel Reason to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + QuoteCancelReason.Length)
        {
            throw new System.Exception("Invalid Length for Quote Cancel Reason");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Quote Cancel Reason to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + QuoteCancelReason.Length;
    }

    /// <summary>
    ///  Set Quote Cancel Reason to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Quote Cancel Reason
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + QuoteCancelReason.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Quote Cancel Reason
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Quote Cancel Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + QuoteCancelReason.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Quote Cancel Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
