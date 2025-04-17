using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Matching Engine Trade Date: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class MatchingEngineTradeDate
{
    /// <summary>
    ///  Fix Tag for Matching Engine Trade Date
    /// </summary>
    public const ushort FixTag = 25030;

    /// <summary>
    ///  Length of Matching Engine Trade Date in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Matching Engine Trade Date
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Matching Engine Trade Date
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + MatchingEngineTradeDate.Length)
        {
            throw new System.Exception("Invalid Length for Matching Engine Trade Date");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Matching Engine Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + MatchingEngineTradeDate.Length;
    }

    /// <summary>
    ///  Encode Matching Engine Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Matching Engine Trade Date to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MatchingEngineTradeDate.Length)
        {
            throw new System.Exception("Invalid Length for Matching Engine Trade Date");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Matching Engine Trade Date to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MatchingEngineTradeDate.Length;
    }

    /// <summary>
    ///  Set Matching Engine Trade Date to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Matching Engine Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + MatchingEngineTradeDate.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Matching Engine Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Matching Engine Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MatchingEngineTradeDate.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Matching Engine Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
