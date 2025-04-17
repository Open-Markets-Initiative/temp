using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Trading Session Sub Id: Enum
/// </summary>

public static class TradingSessionSubId
{
    /// <summary>
    ///  Opening or opening auction
    /// </summary>
    public const byte Openingauction = 2;

    /// <summary>
    ///  Closing or closing auction
    /// </summary>
    public const byte Closingauction = 4;

    /// <summary>
    ///  Any auction
    /// </summary>
    public const byte AnyAuction = 8;

    /// <summary>
    ///  Fix Tag for Trading Session Sub Id
    /// </summary>
    public const ushort FixTag = 625;

    /// <summary>
    ///  Length of Trading Session Sub Id in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trading Session Sub Id
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trading Session Sub Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradingSessionSubId.Length)
        {
            throw new System.Exception("Invalid Length for Trading Session Sub Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trading Session Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradingSessionSubId.Length;
    }

    /// <summary>
    ///  Check available length and set Trading Session Sub Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradingSessionSubId.Length)
        {
            throw new System.Exception("Invalid Length for Trading Session Sub Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trading Session Sub Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradingSessionSubId.Length;
    }

    /// <summary>
    ///  Set Trading Session Sub Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trading Session Sub Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradingSessionSubId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trading Session Sub Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trading Session Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradingSessionSubId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trading Session Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
