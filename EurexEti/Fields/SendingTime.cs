using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Sending Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class SendingTime
{
    /// <summary>
    ///  Fix Tag for Sending Time
    /// </summary>
    public const ushort FixTag = 52;

    /// <summary>
    ///  Length of Sending Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Sending Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Sending Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + SendingTime.Length)
        {
            throw new System.Exception("Invalid Length for Sending Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Sending Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SendingTime.Length;
    }

    /// <summary>
    ///  Encode Sending Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Sending Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SendingTime.Length)
        {
            throw new System.Exception("Invalid Length for Sending Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Sending Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SendingTime.Length;
    }

    /// <summary>
    ///  Set Sending Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Sending Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + SendingTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Sending Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Sending Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SendingTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Sending Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
