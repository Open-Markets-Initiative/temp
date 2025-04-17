using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Ownership Indicator: Enum
/// </summary>

public static class OwnershipIndicator
{
    /// <summary>
    ///  Do not change ownership
    /// </summary>
    public const byte NoChangeofOwnership = 0;

    /// <summary>
    ///  Change ownership to executing party (User ID)
    /// </summary>
    public const byte ChangetoExecutingTrader = 1;

    /// <summary>
    ///  Fix Tag for Ownership Indicator
    /// </summary>
    public const ushort FixTag = 28743;

    /// <summary>
    ///  Length of Ownership Indicator in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Ownership Indicator
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Ownership Indicator
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + OwnershipIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Ownership Indicator");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Ownership Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + OwnershipIndicator.Length;
    }

    /// <summary>
    ///  Check available length and set Ownership Indicator to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OwnershipIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Ownership Indicator");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Ownership Indicator to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OwnershipIndicator.Length;
    }

    /// <summary>
    ///  Set Ownership Indicator to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Ownership Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + OwnershipIndicator.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Ownership Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Ownership Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OwnershipIndicator.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Ownership Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
