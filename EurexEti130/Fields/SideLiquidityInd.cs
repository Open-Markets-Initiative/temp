using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Side Liquidity Ind: Enum
/// </summary>

public static class SideLiquidityInd
{
    /// <summary>
    ///  Added liquidity (passive)
    /// </summary>
    public const byte AddedLiquidity = 1;

    /// <summary>
    ///  Removed liquidity (aggressive, includes triggered orders)
    /// </summary>
    public const byte RemovedLiquidity = 2;

    /// <summary>
    ///  Auction
    /// </summary>
    public const byte Auction = 4;

    /// <summary>
    ///  Fix Tag for Side Liquidity Ind
    /// </summary>
    public const ushort FixTag = 1444;

    /// <summary>
    ///  Length of Side Liquidity Ind in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Side Liquidity Ind
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Side Liquidity Ind
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + SideLiquidityInd.Length)
        {
            throw new System.Exception("Invalid Length for Side Liquidity Ind");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Side Liquidity Ind
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + SideLiquidityInd.Length;
    }

    /// <summary>
    ///  Check available length and set Side Liquidity Ind to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SideLiquidityInd.Length)
        {
            throw new System.Exception("Invalid Length for Side Liquidity Ind");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Side Liquidity Ind to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SideLiquidityInd.Length;
    }

    /// <summary>
    ///  Set Side Liquidity Ind to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Side Liquidity Ind
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + SideLiquidityInd.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Side Liquidity Ind
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Side Liquidity Ind
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SideLiquidityInd.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Side Liquidity Ind
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
