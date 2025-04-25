using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trade Report Type: Enum
/// </summary>

public static class TradeReportType
{
    /// <summary>
    ///  Submit
    /// </summary>
    public const byte Submit = 0;

    /// <summary>
    ///  Alleged
    /// </summary>
    public const byte Alleged = 1;

    /// <summary>
    ///  Accept
    /// </summary>
    public const byte Accept = 2;

    /// <summary>
    ///  Decline
    /// </summary>
    public const byte Decline = 3;

    /// <summary>
    ///  No/Was (Replaced)
    /// </summary>
    public const byte NoWasReplaced = 5;

    /// <summary>
    ///  Trade Report Cancel
    /// </summary>
    public const byte TradeReportCancel = 6;

    /// <summary>
    ///  (Locked-In) Trade Break
    /// </summary>
    public const byte TradeBreak = 7;

    /// <summary>
    ///  Alleged New
    /// </summary>
    public const byte AllegedNew = 11;

    /// <summary>
    ///  Alleged No/Was
    /// </summary>
    public const byte AllegedNoWas = 13;

    /// <summary>
    ///  Fix Tag for Trade Report Type
    /// </summary>
    public const ushort FixTag = 856;

    /// <summary>
    ///  Length of Trade Report Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trade Report Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trade Report Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradeReportType.Length)
        {
            throw new System.Exception("Invalid Length for Trade Report Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade Report Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradeReportType.Length;
    }

    /// <summary>
    ///  Check available length and set Trade Report Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradeReportType.Length)
        {
            throw new System.Exception("Invalid Length for Trade Report Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade Report Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradeReportType.Length;
    }

    /// <summary>
    ///  Set Trade Report Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade Report Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradeReportType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade Report Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trade Report Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradeReportType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade Report Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
