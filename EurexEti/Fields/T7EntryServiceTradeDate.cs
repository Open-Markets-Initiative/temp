using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  T 7 Entry Service Trade Date: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class T7EntryServiceTradeDate
{
    /// <summary>
    ///  Fix Tag for T 7 Entry Service Trade Date
    /// </summary>
    public const ushort FixTag = 25047;

    /// <summary>
    ///  Length of T 7 Entry Service Trade Date in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for T 7 Entry Service Trade Date
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode T 7 Entry Service Trade Date
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + T7EntryServiceTradeDate.Length)
        {
            throw new System.Exception("Invalid Length for T 7 Entry Service Trade Date");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode T 7 Entry Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + T7EntryServiceTradeDate.Length;
    }

    /// <summary>
    ///  Encode T 7 Entry Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set T 7 Entry Service Trade Date to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + T7EntryServiceTradeDate.Length)
        {
            throw new System.Exception("Invalid Length for T 7 Entry Service Trade Date");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set T 7 Entry Service Trade Date to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + T7EntryServiceTradeDate.Length;
    }

    /// <summary>
    ///  Set T 7 Entry Service Trade Date to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode T 7 Entry Service Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + T7EntryServiceTradeDate.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode T 7 Entry Service Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode T 7 Entry Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + T7EntryServiceTradeDate.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode T 7 Entry Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
