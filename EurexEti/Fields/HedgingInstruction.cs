using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Hedging Instruction: Enum
/// </summary>

public static class HedgingInstruction
{
    /// <summary>
    ///  Execute hedge transaction in the closing auction of the underlying
    /// </summary>
    public const byte OnClose = 1;

    /// <summary>
    ///  Fix Tag for Hedging Instruction
    /// </summary>
    public const ushort FixTag = 30059;

    /// <summary>
    ///  Length of Hedging Instruction in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Hedging Instruction
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Hedging Instruction
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + HedgingInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Hedging Instruction");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Hedging Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + HedgingInstruction.Length;
    }

    /// <summary>
    ///  Check available length and set Hedging Instruction to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + HedgingInstruction.Length)
        {
            throw new System.Exception("Invalid Length for Hedging Instruction");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Hedging Instruction to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + HedgingInstruction.Length;
    }

    /// <summary>
    ///  Set Hedging Instruction to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Hedging Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + HedgingInstruction.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Hedging Instruction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Hedging Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + HedgingInstruction.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Hedging Instruction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
