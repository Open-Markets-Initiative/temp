using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Username: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class Username
{
    /// <summary>
    ///  Fix Tag for Username
    /// </summary>
    public const ushort FixTag = 553;

    /// <summary>
    ///  Length of Username in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Username
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Username
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + Username.Length)
        {
            throw new System.Exception("Invalid Length for Username");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Username
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + Username.Length;
    }

    /// <summary>
    ///  Encode Username
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Username to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + Username.Length)
        {
            throw new System.Exception("Invalid Length for Username");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Username to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + Username.Length;
    }

    /// <summary>
    ///  Set Username to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Username
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + Username.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Username
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Username
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Username.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Username
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
