using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Related Market Segment Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class RelatedMarketSegmentId
{
    /// <summary>
    ///  Fix Tag for Related Market Segment Id
    /// </summary>
    public const ushort FixTag = 2546;

    /// <summary>
    ///  Length of Related Market Segment Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Related Market Segment Id
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Related Market Segment Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + RelatedMarketSegmentId.Length)
        {
            throw new System.Exception("Invalid Length for Related Market Segment Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Related Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RelatedMarketSegmentId.Length;
    }

    /// <summary>
    ///  Encode Related Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Related Market Segment Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RelatedMarketSegmentId.Length)
        {
            throw new System.Exception("Invalid Length for Related Market Segment Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Related Market Segment Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RelatedMarketSegmentId.Length;
    }

    /// <summary>
    ///  Set Related Market Segment Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Related Market Segment Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + RelatedMarketSegmentId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Related Market Segment Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Related Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RelatedMarketSegmentId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Related Market Segment Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
