using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Effect On Basket: Enum
/// </summary>

public static class EffectOnBasket
{
    /// <summary>
    ///  Add volume
    /// </summary>
    public const byte AddVolume = 1;

    /// <summary>
    ///  Remove volume
    /// </summary>
    public const byte RemoveVolume = 2;

    /// <summary>
    ///  Fix Tag for Effect On Basket
    /// </summary>
    public const ushort FixTag = 25163;

    /// <summary>
    ///  Length of Effect On Basket in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Effect On Basket
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Effect On Basket
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + EffectOnBasket.Length)
        {
            throw new System.Exception("Invalid Length for Effect On Basket");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Effect On Basket
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + EffectOnBasket.Length;
    }

    /// <summary>
    ///  Check available length and set Effect On Basket to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + EffectOnBasket.Length)
        {
            throw new System.Exception("Invalid Length for Effect On Basket");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Effect On Basket to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + EffectOnBasket.Length;
    }

    /// <summary>
    ///  Set Effect On Basket to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Effect On Basket
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + EffectOnBasket.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Effect On Basket
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Effect On Basket
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + EffectOnBasket.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Effect On Basket
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
