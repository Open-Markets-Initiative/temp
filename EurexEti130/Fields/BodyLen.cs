using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Body Len: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class BodyLen
{
    /// <summary>
    ///  Fix Tag for Body Len
    /// </summary>
    public const ushort FixTag = 9;

    /// <summary>
    ///  Length of Body Len in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Body Len
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Body Len
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + BodyLen.Length)
        {
            throw new System.Exception("Invalid Length for Body Len");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Body Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + BodyLen.Length;
    }

    /// <summary>
    ///  Encode Body Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Body Len to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + BodyLen.Length)
        {
            throw new System.Exception("Invalid Length for Body Len");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Body Len to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + BodyLen.Length;
    }

    /// <summary>
    ///  Set Body Len to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Body Len
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + BodyLen.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Body Len
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Body Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + BodyLen.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Body Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
