using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Selective Request For Quote Service Trade Date: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class SelectiveRequestForQuoteServiceTradeDate
{
    /// <summary>
    ///  Fix Tag for Selective Request For Quote Service Trade Date
    /// </summary>
    public const ushort FixTag = 25052;

    /// <summary>
    ///  Length of Selective Request For Quote Service Trade Date in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Selective Request For Quote Service Trade Date
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Selective Request For Quote Service Trade Date
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + SelectiveRequestForQuoteServiceTradeDate.Length)
        {
            throw new System.Exception("Invalid Length for Selective Request For Quote Service Trade Date");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Selective Request For Quote Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SelectiveRequestForQuoteServiceTradeDate.Length;
    }

    /// <summary>
    ///  Encode Selective Request For Quote Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Selective Request For Quote Service Trade Date to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SelectiveRequestForQuoteServiceTradeDate.Length)
        {
            throw new System.Exception("Invalid Length for Selective Request For Quote Service Trade Date");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Selective Request For Quote Service Trade Date to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SelectiveRequestForQuoteServiceTradeDate.Length;
    }

    /// <summary>
    ///  Set Selective Request For Quote Service Trade Date to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Selective Request For Quote Service Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + SelectiveRequestForQuoteServiceTradeDate.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Selective Request For Quote Service Trade Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Selective Request For Quote Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SelectiveRequestForQuoteServiceTradeDate.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Selective Request For Quote Service Trade Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
