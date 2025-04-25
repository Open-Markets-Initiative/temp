using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Match Sub Type: Enum
/// </summary>

public static class MatchSubType
{
    /// <summary>
    ///  Opening auction
    /// </summary>
    public const byte OpeningAuction = 1;

    /// <summary>
    ///  Closing auction
    /// </summary>
    public const byte ClosingAuction = 2;

    /// <summary>
    ///  Intraday auction
    /// </summary>
    public const byte IntradayAuction = 3;

    /// <summary>
    ///  Circuit Breaker auction
    /// </summary>
    public const byte CircuitBreakerAuction = 4;

    /// <summary>
    ///  CLIP matching outside BBO
    /// </summary>
    public const byte OutsideBbo = 6;

    /// <summary>
    ///  Fix Tag for Match Sub Type
    /// </summary>
    public const ushort FixTag = 28610;

    /// <summary>
    ///  Length of Match Sub Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Match Sub Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Match Sub Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + MatchSubType.Length)
        {
            throw new System.Exception("Invalid Length for Match Sub Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Match Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + MatchSubType.Length;
    }

    /// <summary>
    ///  Check available length and set Match Sub Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MatchSubType.Length)
        {
            throw new System.Exception("Invalid Length for Match Sub Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Match Sub Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MatchSubType.Length;
    }

    /// <summary>
    ///  Set Match Sub Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Match Sub Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + MatchSubType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Match Sub Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Match Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MatchSubType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Match Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
