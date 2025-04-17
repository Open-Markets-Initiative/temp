using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Last Update Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class LastUpdateTime
{
    /// <summary>
    ///  Fix Tag for Last Update Time
    /// </summary>
    public const ushort FixTag = 779;

    /// <summary>
    ///  Length of Last Update Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Last Update Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Last Update Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + LastUpdateTime.Length)
        {
            throw new System.Exception("Invalid Length for Last Update Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Last Update Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + LastUpdateTime.Length;
    }

    /// <summary>
    ///  Encode Last Update Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Last Update Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LastUpdateTime.Length)
        {
            throw new System.Exception("Invalid Length for Last Update Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Last Update Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LastUpdateTime.Length;
    }

    /// <summary>
    ///  Set Last Update Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Last Update Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + LastUpdateTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Last Update Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Last Update Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LastUpdateTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Last Update Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
