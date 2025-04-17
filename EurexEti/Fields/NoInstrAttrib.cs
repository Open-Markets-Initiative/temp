using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Instr Attrib: Runtime Count Field
/// </summary>

public static class NoInstrAttrib
{
    /// <summary>
    ///  Fix Tag for No Instr Attrib
    /// </summary>
    public const ushort FixTag = 870;

    /// <summary>
    ///  Length of No Instr Attrib in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Instr Attrib
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoInstrAttrib.Length)
        {
            throw new System.Exception("Invalid Length for No Instr Attrib");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Instr Attrib
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoInstrAttrib.Length;
    }

    /// <summary>
    ///  Encode No Instr Attrib
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Instr Attrib to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoInstrAttrib.Length)
        {
            throw new System.Exception("Invalid Length for No Instr Attrib");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Instr Attrib to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoInstrAttrib.Length;
    }

    /// <summary>
    ///  Set No Instr Attrib to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Instr Attrib
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoInstrAttrib.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Instr Attrib
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Instr Attrib
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoInstrAttrib.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Instr Attrib
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
