using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Instrmt Match Side Id: Optional 1 Byte Fixed Width Integer
/// </summary>

public static class InstrmtMatchSideId
{
    /// <summary>
    ///  Fix Tag for Instrmt Match Side Id
    /// </summary>
    public const ushort FixTag = 25166;

    /// <summary>
    ///  Length of Instrmt Match Side Id in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Instrmt Match Side Id
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Instrmt Match Side Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + InstrmtMatchSideId.Length)
        {
            throw new System.Exception("Invalid Length for Instrmt Match Side Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Instrmt Match Side Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + InstrmtMatchSideId.Length;
    }

    /// <summary>
    ///  Encode Instrmt Match Side Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Instrmt Match Side Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + InstrmtMatchSideId.Length)
        {
            throw new System.Exception("Invalid Length for Instrmt Match Side Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Instrmt Match Side Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + InstrmtMatchSideId.Length;
    }

    /// <summary>
    ///  Set Instrmt Match Side Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Instrmt Match Side Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + InstrmtMatchSideId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Instrmt Match Side Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Instrmt Match Side Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + InstrmtMatchSideId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Instrmt Match Side Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
