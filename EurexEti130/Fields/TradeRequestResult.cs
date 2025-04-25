using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trade Request Result: Enum
/// </summary>

public static class TradeRequestResult
{
    /// <summary>
    ///  Deal cancellation pending
    /// </summary>
    public const byte Cancelpending = 100;

    /// <summary>
    ///  Deal cancellation declined
    /// </summary>
    public const byte Canceldeclined = 101;

    /// <summary>
    ///  Deal cancellation approved
    /// </summary>
    public const byte Cancelapproved = 102;

    /// <summary>
    ///  Fix Tag for Trade Request Result
    /// </summary>
    public const ushort FixTag = 749;

    /// <summary>
    ///  Length of Trade Request Result in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trade Request Result
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trade Request Result
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradeRequestResult.Length)
        {
            throw new System.Exception("Invalid Length for Trade Request Result");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade Request Result
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradeRequestResult.Length;
    }

    /// <summary>
    ///  Check available length and set Trade Request Result to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradeRequestResult.Length)
        {
            throw new System.Exception("Invalid Length for Trade Request Result");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade Request Result to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradeRequestResult.Length;
    }

    /// <summary>
    ///  Set Trade Request Result to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade Request Result
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradeRequestResult.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade Request Result
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trade Request Result
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradeRequestResult.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade Request Result
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
