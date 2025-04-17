using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Price Disclosure Instruction: Enum
/// </summary>

public static class PriceDisclosureInstruction
{
    /// <summary>
    ///  No
    /// </summary>
    public const byte No = 0;

    /// <summary>
    ///  Yes
    /// </summary>
    public const byte Yes = 1;

    /// <summary>
    ///  Fix Tag for Price Disclosure Instruction
    /// </summary>
    public const ushort FixTag = 25131;

    /// <summary>
    ///  Length of Price Disclosure Instruction in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Price Disclosure Instruction
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Price Disclosure Instruction
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + PriceDisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Price Disclosure Instruction");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Price Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + PriceDisclosureInstruction.Length;
    }

    /// <summary>
    ///  Check available length and set Price Disclosure Instruction to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PriceDisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Price Disclosure Instruction");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Price Disclosure Instruction to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + PriceDisclosureInstruction.Length;
    }

    /// <summary>
    ///  Set Price Disclosure Instruction to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Price Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + PriceDisclosureInstruction.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Price Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Price Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PriceDisclosureInstruction.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Price Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
