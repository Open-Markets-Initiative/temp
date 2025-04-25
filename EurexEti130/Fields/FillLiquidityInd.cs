using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Fill Liquidity Ind: Enum
/// </summary>

public static class FillLiquidityInd
{
    /// <summary>
    ///  Added Liquidity
    /// </summary>
    public const byte AddedLiquidity = 1;

    /// <summary>
    ///  Removed Liquidity
    /// </summary>
    public const byte RemovedLiquidity = 2;

    /// <summary>
    ///  Auction
    /// </summary>
    public const byte Auction = 4;

    /// <summary>
    ///  Triggered Stop Order
    /// </summary>
    public const byte TriggeredStopOrder = 5;

    /// <summary>
    ///  Triggered OCO Order
    /// </summary>
    public const byte TriggeredOcoOrder = 6;

    /// <summary>
    ///  Triggered Market Order
    /// </summary>
    public const byte TriggeredMarketOrder = 7;

    /// <summary>
    ///  Fix Tag for Fill Liquidity Ind
    /// </summary>
    public const ushort FixTag = 1443;

    /// <summary>
    ///  Length of Fill Liquidity Ind in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Fill Liquidity Ind
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Fill Liquidity Ind
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + FillLiquidityInd.Length)
        {
            throw new System.Exception("Invalid Length for Fill Liquidity Ind");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fill Liquidity Ind
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + FillLiquidityInd.Length;
    }

    /// <summary>
    ///  Check available length and set Fill Liquidity Ind to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FillLiquidityInd.Length)
        {
            throw new System.Exception("Invalid Length for Fill Liquidity Ind");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fill Liquidity Ind to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FillLiquidityInd.Length;
    }

    /// <summary>
    ///  Set Fill Liquidity Ind to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Fill Liquidity Ind
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + FillLiquidityInd.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fill Liquidity Ind
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Fill Liquidity Ind
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FillLiquidityInd.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fill Liquidity Ind
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
