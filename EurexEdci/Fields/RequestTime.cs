using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  Request Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class RequestTime
{
    /// <summary>
    ///  Fix Tag for Request Time
    /// </summary>
    public const ushort FixTag = 5979;

    /// <summary>
    ///  Length of Request Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Request Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Request Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + RequestTime.Length)
        {
            throw new System.Exception("Invalid Length for Request Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Request Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RequestTime.Length;
    }

    /// <summary>
    ///  Encode Request Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Request Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RequestTime.Length)
        {
            throw new System.Exception("Invalid Length for Request Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Request Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RequestTime.Length;
    }

    /// <summary>
    ///  Set Request Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Request Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + RequestTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Request Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Request Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RequestTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Request Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
