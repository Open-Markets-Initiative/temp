using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Session Status: Enum
/// </summary>

public static class SessionStatus
{
    /// <summary>
    ///  Session active
    /// </summary>
    public const byte Active = 0;

    /// <summary>
    ///  Session logout complete
    /// </summary>
    public const byte Logout = 4;

    /// <summary>
    ///  Fix Tag for Session Status
    /// </summary>
    public const ushort FixTag = 1409;

    /// <summary>
    ///  Length of Session Status in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Session Status
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Session Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + SessionStatus.Length)
        {
            throw new System.Exception("Invalid Length for Session Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Session Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + SessionStatus.Length;
    }

    /// <summary>
    ///  Check available length and set Session Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SessionStatus.Length)
        {
            throw new System.Exception("Invalid Length for Session Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Session Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SessionStatus.Length;
    }

    /// <summary>
    ///  Set Session Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Session Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + SessionStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Session Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Session Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SessionStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Session Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
