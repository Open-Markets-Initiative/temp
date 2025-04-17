using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Appl Id: Enum
/// </summary>

public static class ApplId
{
    /// <summary>
    ///  OrderDropCopy Data
    /// </summary>
    public const byte OrderDropCopy = 12;

    /// <summary>
    ///  Fix Tag for Appl Id
    /// </summary>
    public const ushort FixTag = 1180;

    /// <summary>
    ///  Length of Appl Id in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Appl Id
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Appl Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ApplId.Length)
        {
            throw new System.Exception("Invalid Length for Appl Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ApplId.Length;
    }

    /// <summary>
    ///  Check available length and set Appl Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ApplId.Length)
        {
            throw new System.Exception("Invalid Length for Appl Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Appl Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ApplId.Length;
    }

    /// <summary>
    ///  Set Appl Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Appl Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ApplId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Appl Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Appl Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
