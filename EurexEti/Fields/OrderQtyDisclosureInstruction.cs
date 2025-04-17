using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Order Qty Disclosure Instruction: Enum
/// </summary>

public static class OrderQtyDisclosureInstruction
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
    ///  Fix Tag for Order Qty Disclosure Instruction
    /// </summary>
    public const ushort FixTag = 25136;

    /// <summary>
    ///  Length of Order Qty Disclosure Instruction in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Order Qty Disclosure Instruction
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Order Qty Disclosure Instruction
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + OrderQtyDisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Order Qty Disclosure Instruction");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Order Qty Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + OrderQtyDisclosureInstruction.Length;
    }

    /// <summary>
    ///  Check available length and set Order Qty Disclosure Instruction to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrderQtyDisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Order Qty Disclosure Instruction");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Order Qty Disclosure Instruction to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrderQtyDisclosureInstruction.Length;
    }

    /// <summary>
    ///  Set Order Qty Disclosure Instruction to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Order Qty Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + OrderQtyDisclosureInstruction.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Order Qty Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Order Qty Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrderQtyDisclosureInstruction.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Order Qty Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
