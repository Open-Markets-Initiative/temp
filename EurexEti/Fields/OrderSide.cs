using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Order Side: Enum
/// </summary>

public static class OrderSide
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
    ///  Fix Tag for Order Side
    /// </summary>
    public const ushort FixTag = 28586;

    /// <summary>
    ///  Length of Order Side in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Order Side
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Order Side
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + OrderSide.Length)
        {
            throw new System.Exception("Invalid Length for Order Side");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Order Side
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + OrderSide.Length;
    }

    /// <summary>
    ///  Check available length and set Order Side to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrderSide.Length)
        {
            throw new System.Exception("Invalid Length for Order Side");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Order Side to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrderSide.Length;
    }

    /// <summary>
    ///  Set Order Side to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Order Side
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + OrderSide.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Order Side
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Order Side
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrderSide.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Order Side
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
