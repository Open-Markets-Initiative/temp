using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Party Action Type: Enum
/// </summary>

public static class PartyActionType
{
    /// <summary>
    ///  Halt trading
    /// </summary>
    public const byte HaltTrading = 1;

    /// <summary>
    ///  Reinstate
    /// </summary>
    public const byte Reinstate = 2;

    /// <summary>
    ///  Fix Tag for Party Action Type
    /// </summary>
    public const ushort FixTag = 2329;

    /// <summary>
    ///  Length of Party Action Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Party Action Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Party Action Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + PartyActionType.Length)
        {
            throw new System.Exception("Invalid Length for Party Action Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Party Action Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + PartyActionType.Length;
    }

    /// <summary>
    ///  Check available length and set Party Action Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PartyActionType.Length)
        {
            throw new System.Exception("Invalid Length for Party Action Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Party Action Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + PartyActionType.Length;
    }

    /// <summary>
    ///  Set Party Action Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Party Action Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + PartyActionType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Party Action Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Party Action Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PartyActionType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Party Action Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
