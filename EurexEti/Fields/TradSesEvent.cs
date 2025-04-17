using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Trad Ses Event: Enum
/// </summary>

public static class TradSesEvent
{
    /// <summary>
    ///  Start of Service
    /// </summary>
    public const byte StartofService = 101;

    /// <summary>
    ///  Market Reset
    /// </summary>
    public const byte MarketReset = 102;

    /// <summary>
    ///  End of Restatement
    /// </summary>
    public const byte EndofRestatement = 103;

    /// <summary>
    ///  End of Service
    /// </summary>
    public const byte EndofDayService = 104;

    /// <summary>
    ///  Service Resumed
    /// </summary>
    public const byte ServiceResumed = 105;

    /// <summary>
    ///  Fix Tag for Trad Ses Event
    /// </summary>
    public const ushort FixTag = 1368;

    /// <summary>
    ///  Length of Trad Ses Event in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trad Ses Event
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trad Ses Event
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradSesEvent.Length)
        {
            throw new System.Exception("Invalid Length for Trad Ses Event");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trad Ses Event
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradSesEvent.Length;
    }

    /// <summary>
    ///  Check available length and set Trad Ses Event to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradSesEvent.Length)
        {
            throw new System.Exception("Invalid Length for Trad Ses Event");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trad Ses Event to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradSesEvent.Length;
    }

    /// <summary>
    ///  Set Trad Ses Event to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trad Ses Event
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradSesEvent.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trad Ses Event
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trad Ses Event
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradSesEvent.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trad Ses Event
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
