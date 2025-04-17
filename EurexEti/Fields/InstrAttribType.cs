using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Instr Attrib Type: Enum
/// </summary>

public static class InstrAttribType
{
    /// <summary>
    ///  Variable rate
    /// </summary>
    public const byte VariableRate = 5;

    /// <summary>
    ///  Coupon rate
    /// </summary>
    public const byte CouponRate = 100;

    /// <summary>
    ///  Offset to the variable coupon rate
    /// </summary>
    public const byte Offsettothevariablecouponrate = 101;

    /// <summary>
    ///  Swap Customer 1
    /// </summary>
    public const byte SwapCustomer1 = 102;

    /// <summary>
    ///  Swap Customer 2
    /// </summary>
    public const byte SwapCustomer2 = 103;

    /// <summary>
    ///  Cash Basket Reference
    /// </summary>
    public const byte CashBasketReference = 104;

    /// <summary>
    ///  Fix Tag for Instr Attrib Type
    /// </summary>
    public const ushort FixTag = 871;

    /// <summary>
    ///  Length of Instr Attrib Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Instr Attrib Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Instr Attrib Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + InstrAttribType.Length)
        {
            throw new System.Exception("Invalid Length for Instr Attrib Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Instr Attrib Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + InstrAttribType.Length;
    }

    /// <summary>
    ///  Check available length and set Instr Attrib Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + InstrAttribType.Length)
        {
            throw new System.Exception("Invalid Length for Instr Attrib Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Instr Attrib Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + InstrAttribType.Length;
    }

    /// <summary>
    ///  Set Instr Attrib Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Instr Attrib Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + InstrAttribType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Instr Attrib Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Instr Attrib Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + InstrAttribType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Instr Attrib Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
