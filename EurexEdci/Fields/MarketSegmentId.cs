using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  Market Segment Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class MarketSegmentId
{
    /// <summary>
    ///  Fix Tag for Market Segment Id
    /// </summary>
    public const ushort FixTag = 1300;

    /// <summary>
    ///  Length of Market Segment Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Market Segment Id
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Market Segment Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + MarketSegmentId.Length)
        {
            throw new System.Exception("Invalid Length for Market Segment Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + MarketSegmentId.Length;
    }

    /// <summary>
    ///  Encode Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Market Segment Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MarketSegmentId.Length)
        {
            throw new System.Exception("Invalid Length for Market Segment Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Market Segment Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MarketSegmentId.Length;
    }

    /// <summary>
    ///  Set Market Segment Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Market Segment Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + MarketSegmentId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Market Segment Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MarketSegmentId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
