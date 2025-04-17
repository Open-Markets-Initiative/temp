using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Expire Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ExpireTime
{
    /// <summary>
    ///  Fix Tag for Expire Time
    /// </summary>
    public const ushort FixTag = 126;

    /// <summary>
    ///  Length of Expire Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Expire Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Expire Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ExpireTime.Length)
        {
            throw new System.Exception("Invalid Length for Expire Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Expire Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ExpireTime.Length;
    }

    /// <summary>
    ///  Encode Expire Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Expire Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExpireTime.Length)
        {
            throw new System.Exception("Invalid Length for Expire Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Expire Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExpireTime.Length;
    }

    /// <summary>
    ///  Set Expire Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Expire Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ExpireTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Expire Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Expire Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExpireTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Expire Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
