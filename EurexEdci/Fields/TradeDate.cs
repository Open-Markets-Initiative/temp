using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  Trade Date: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class TradeDate
{
    /// <summary>
    ///  Fix Tag for Trade Date
    /// </summary>
    public const ushort FixTag = 75;

    /// <summary>
    ///  Length of Trade Date in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Trade Date
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Trade Date
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + TradeDate.Length)
        {
            throw new System.Exception("Invalid Length for Trade Date");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + TradeDate.Length;
    }

    /// <summary>
    ///  Encode Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Trade Date to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradeDate.Length)
        {
            throw new System.Exception("Invalid Length for Trade Date");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade Date to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradeDate.Length;
    }

    /// <summary>
    ///  Set Trade Date to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + TradeDate.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradeDate.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
