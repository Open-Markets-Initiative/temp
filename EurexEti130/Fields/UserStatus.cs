using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  User Status: Enum
/// </summary>

public static class UserStatus
{
    /// <summary>
    ///  Forced user logout by exchange
    /// </summary>
    public const byte Userforcedlogout = 7;

    /// <summary>
    ///  Admission to trading suspended
    /// </summary>
    public const byte Userstopped = 10;

    /// <summary>
    ///  Suspension revoked
    /// </summary>
    public const byte Userreleased = 11;

    /// <summary>
    ///  Fix Tag for User Status
    /// </summary>
    public const ushort FixTag = 926;

    /// <summary>
    ///  Length of User Status in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for User Status
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode User Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + UserStatus.Length)
        {
            throw new System.Exception("Invalid Length for User Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode User Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + UserStatus.Length;
    }

    /// <summary>
    ///  Check available length and set User Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + UserStatus.Length)
        {
            throw new System.Exception("Invalid Length for User Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set User Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + UserStatus.Length;
    }

    /// <summary>
    ///  Set User Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode User Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + UserStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode User Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode User Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + UserStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode User Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
