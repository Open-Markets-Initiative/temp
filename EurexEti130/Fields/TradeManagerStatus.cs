using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trade Manager Status: Enum
/// </summary>

public static class TradeManagerStatus
{
    /// <summary>
    ///  Unavailable
    /// </summary>
    public const byte Unavailable = 0;

    /// <summary>
    ///  Available
    /// </summary>
    public const byte Available = 1;

    /// <summary>
    ///  Fix Tag for Trade Manager Status
    /// </summary>
    public const ushort FixTag = 25006;

    /// <summary>
    ///  Length of Trade Manager Status in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trade Manager Status
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trade Manager Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradeManagerStatus.Length)
        {
            throw new System.Exception("Invalid Length for Trade Manager Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade Manager Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradeManagerStatus.Length;
    }

    /// <summary>
    ///  Check available length and set Trade Manager Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradeManagerStatus.Length)
        {
            throw new System.Exception("Invalid Length for Trade Manager Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade Manager Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradeManagerStatus.Length;
    }

    /// <summary>
    ///  Set Trade Manager Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade Manager Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradeManagerStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade Manager Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trade Manager Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradeManagerStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade Manager Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
