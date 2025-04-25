using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Session Sub Mode: Enum
/// </summary>

public static class SessionSubMode
{
    /// <summary>
    ///  Regular Trading Session
    /// </summary>
    public const byte Regulartradingsession = 0;

    /// <summary>
    ///  Regular Back Office Session
    /// </summary>
    public const byte RegularBackOfficesession = 2;

    /// <summary>
    ///  Fix Tag for Session Sub Mode
    /// </summary>
    public const ushort FixTag = 28735;

    /// <summary>
    ///  Length of Session Sub Mode in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Session Sub Mode
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Session Sub Mode
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + SessionSubMode.Length)
        {
            throw new System.Exception("Invalid Length for Session Sub Mode");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Session Sub Mode
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + SessionSubMode.Length;
    }

    /// <summary>
    ///  Check available length and set Session Sub Mode to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SessionSubMode.Length)
        {
            throw new System.Exception("Invalid Length for Session Sub Mode");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Session Sub Mode to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SessionSubMode.Length;
    }

    /// <summary>
    ///  Set Session Sub Mode to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Session Sub Mode
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + SessionSubMode.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Session Sub Mode
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Session Sub Mode
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SessionSubMode.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Session Sub Mode
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
