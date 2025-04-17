using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Leg Side: Enum
/// </summary>

public static class LegSide
{
    /// <summary>
    ///  Buy
    /// </summary>
    public const byte Buy = 1;

    /// <summary>
    ///  Sell
    /// </summary>
    public const byte Sell = 2;

    /// <summary>
    ///  Fix Tag for Leg Side
    /// </summary>
    public const ushort FixTag = 624;

    /// <summary>
    ///  Length of Leg Side in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Leg Side
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Leg Side
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + LegSide.Length)
        {
            throw new System.Exception("Invalid Length for Leg Side");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Leg Side
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + LegSide.Length;
    }

    /// <summary>
    ///  Check available length and set Leg Side to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LegSide.Length)
        {
            throw new System.Exception("Invalid Length for Leg Side");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Leg Side to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LegSide.Length;
    }

    /// <summary>
    ///  Set Leg Side to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Leg Side
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + LegSide.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Leg Side
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Leg Side
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LegSide.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Leg Side
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
