using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Free Text 5 Disclosure Instruction: Enum
/// </summary>

public static class FreeText5DisclosureInstruction
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
    ///  Fix Tag for Free Text 5 Disclosure Instruction
    /// </summary>
    public const ushort FixTag = 31814;

    /// <summary>
    ///  Length of Free Text 5 Disclosure Instruction in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Free Text 5 Disclosure Instruction
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Free Text 5 Disclosure Instruction
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + FreeText5DisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Free Text 5 Disclosure Instruction");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Free Text 5 Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + FreeText5DisclosureInstruction.Length;
    }

    /// <summary>
    ///  Check available length and set Free Text 5 Disclosure Instruction to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FreeText5DisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Free Text 5 Disclosure Instruction");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Free Text 5 Disclosure Instruction to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FreeText5DisclosureInstruction.Length;
    }

    /// <summary>
    ///  Set Free Text 5 Disclosure Instruction to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Free Text 5 Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + FreeText5DisclosureInstruction.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Free Text 5 Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Free Text 5 Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FreeText5DisclosureInstruction.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Free Text 5 Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
