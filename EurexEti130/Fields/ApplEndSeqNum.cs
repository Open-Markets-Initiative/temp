using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Appl End Seq Num: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ApplEndSeqNum
{
    /// <summary>
    ///  Fix Tag for Appl End Seq Num
    /// </summary>
    public const ushort FixTag = 1183;

    /// <summary>
    ///  Length of Appl End Seq Num in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Appl End Seq Num
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Appl End Seq Num
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ApplEndSeqNum.Length)
        {
            throw new System.Exception("Invalid Length for Appl End Seq Num");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl End Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ApplEndSeqNum.Length;
    }

    /// <summary>
    ///  Encode Appl End Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Appl End Seq Num to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ApplEndSeqNum.Length)
        {
            throw new System.Exception("Invalid Length for Appl End Seq Num");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Appl End Seq Num to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ApplEndSeqNum.Length;
    }

    /// <summary>
    ///  Set Appl End Seq Num to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Appl End Seq Num
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ApplEndSeqNum.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Appl End Seq Num
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Appl End Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplEndSeqNum.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl End Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
