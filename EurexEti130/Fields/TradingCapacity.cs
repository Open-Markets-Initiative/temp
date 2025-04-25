using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trading Capacity: Enum
/// </summary>

public static class TradingCapacity
{
    /// <summary>
    ///  Customer (Agency)
    /// </summary>
    public const byte Customer = 1;

    /// <summary>
    ///  Principal (Proprietary)
    /// </summary>
    public const byte Principal = 5;

    /// <summary>
    ///  Market Maker
    /// </summary>
    public const byte MarketMaker = 6;

    /// <summary>
    ///  Fix Tag for Trading Capacity
    /// </summary>
    public const ushort FixTag = 1815;

    /// <summary>
    ///  Length of Trading Capacity in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trading Capacity
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trading Capacity
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradingCapacity.Length)
        {
            throw new System.Exception("Invalid Length for Trading Capacity");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trading Capacity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradingCapacity.Length;
    }

    /// <summary>
    ///  Check available length and set Trading Capacity to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradingCapacity.Length)
        {
            throw new System.Exception("Invalid Length for Trading Capacity");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trading Capacity to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradingCapacity.Length;
    }

    /// <summary>
    ///  Set Trading Capacity to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trading Capacity
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradingCapacity.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trading Capacity
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trading Capacity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradingCapacity.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trading Capacity
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
