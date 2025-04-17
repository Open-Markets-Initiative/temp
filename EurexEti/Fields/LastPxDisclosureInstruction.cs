using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Last Px Disclosure Instruction: Enum
/// </summary>

public static class LastPxDisclosureInstruction
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
    ///  Fix Tag for Last Px Disclosure Instruction
    /// </summary>
    public const ushort FixTag = 25146;

    /// <summary>
    ///  Length of Last Px Disclosure Instruction in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Last Px Disclosure Instruction
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Last Px Disclosure Instruction
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + LastPxDisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Last Px Disclosure Instruction");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Last Px Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + LastPxDisclosureInstruction.Length;
    }

    /// <summary>
    ///  Check available length and set Last Px Disclosure Instruction to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LastPxDisclosureInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Last Px Disclosure Instruction");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Last Px Disclosure Instruction to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LastPxDisclosureInstruction.Length;
    }

    /// <summary>
    ///  Set Last Px Disclosure Instruction to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Last Px Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + LastPxDisclosureInstruction.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Last Px Disclosure Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Last Px Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LastPxDisclosureInstruction.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Last Px Disclosure Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
