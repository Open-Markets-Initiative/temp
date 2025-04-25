using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Transaction Delay Indicator: Enum
/// </summary>

public static class TransactionDelayIndicator
{
    /// <summary>
    ///  Transaction not delayed
    /// </summary>
    public const byte Notdelayed = 0;

    /// <summary>
    ///  Transaction delayed
    /// </summary>
    public const byte Delayed = 1;

    /// <summary>
    ///  Fix Tag for Transaction Delay Indicator
    /// </summary>
    public const ushort FixTag = 25159;

    /// <summary>
    ///  Length of Transaction Delay Indicator in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Transaction Delay Indicator
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Transaction Delay Indicator
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TransactionDelayIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Transaction Delay Indicator");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Transaction Delay Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TransactionDelayIndicator.Length;
    }

    /// <summary>
    ///  Check available length and set Transaction Delay Indicator to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TransactionDelayIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Transaction Delay Indicator");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Transaction Delay Indicator to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TransactionDelayIndicator.Length;
    }

    /// <summary>
    ///  Set Transaction Delay Indicator to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Transaction Delay Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TransactionDelayIndicator.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Transaction Delay Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Transaction Delay Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TransactionDelayIndicator.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Transaction Delay Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
