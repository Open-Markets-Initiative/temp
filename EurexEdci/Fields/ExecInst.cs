using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  Exec Inst: Enum
/// </summary>

public static class ExecInst
{
    /// <summary>
    ///  Persistent Order (FIX value 'H')
    /// </summary>
    public const byte H = 1;

    /// <summary>
    ///  Non-persistent Order (FIX value 'Q')
    /// </summary>
    public const byte Q = 2;

    /// <summary>
    ///  Persistent and non-persistent orders affected (FIX value 'H Q')
    /// </summary>
    public const byte Hq = 3;

    /// <summary>
    ///  Persistent and Book or Cancel order (FIX value 'H 6')
    /// </summary>
    public const byte H6 = 5;

    /// <summary>
    ///  Non-persistent and Book or Cancel order (FIX value 'Q 6')
    /// </summary>
    public const byte Q6 = 6;

    /// <summary>
    ///  Fix Tag for Exec Inst
    /// </summary>
    public const ushort FixTag = 18;

    /// <summary>
    ///  Length of Exec Inst in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Exec Inst
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Exec Inst
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ExecInst.Length)
        {
            throw new System.Exception("Invalid Length for Exec Inst");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Exec Inst
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ExecInst.Length;
    }

    /// <summary>
    ///  Check available length and set Exec Inst to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExecInst.Length)
        {
            throw new System.Exception("Invalid Length for Exec Inst");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Exec Inst to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExecInst.Length;
    }

    /// <summary>
    ///  Set Exec Inst to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Exec Inst
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ExecInst.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Exec Inst
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Exec Inst
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExecInst.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Exec Inst
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
