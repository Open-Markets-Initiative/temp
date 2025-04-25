using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Enlight Rfq Avg Resp Rate Ranking: Enum
/// </summary>

public static class EnlightRfqAvgRespRateRanking
{
    /// <summary>
    ///  Low
    /// </summary>
    public const byte Low = 1;

    /// <summary>
    ///  Medium
    /// </summary>
    public const byte Medium = 2;

    /// <summary>
    ///  High
    /// </summary>
    public const byte High = 3;

    /// <summary>
    ///  Fix Tag for Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    public const ushort FixTag = 25178;

    /// <summary>
    ///  Length of Enlight Rfq Avg Resp Rate Ranking in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + EnlightRfqAvgRespRateRanking.Length)
        {
            throw new System.Exception("Invalid Length for Enlight Rfq Avg Resp Rate Ranking");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + EnlightRfqAvgRespRateRanking.Length;
    }

    /// <summary>
    ///  Check available length and set Enlight Rfq Avg Resp Rate Ranking to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + EnlightRfqAvgRespRateRanking.Length)
        {
            throw new System.Exception("Invalid Length for Enlight Rfq Avg Resp Rate Ranking");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Enlight Rfq Avg Resp Rate Ranking to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + EnlightRfqAvgRespRateRanking.Length;
    }

    /// <summary>
    ///  Set Enlight Rfq Avg Resp Rate Ranking to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + EnlightRfqAvgRespRateRanking.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + EnlightRfqAvgRespRateRanking.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Enlight Rfq Avg Resp Rate Ranking
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
