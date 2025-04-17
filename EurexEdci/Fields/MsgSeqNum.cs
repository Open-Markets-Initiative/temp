using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Msg Seq Num: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class MsgSeqNum
{
    /// <summary>
    ///  Fix Tag for Msg Seq Num
    /// </summary>
    public const ushort FixTag = 34;

    /// <summary>
    ///  Length of Msg Seq Num in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Msg Seq Num
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Msg Seq Num
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + MsgSeqNum.Length)
        {
            throw new System.Exception("Invalid Length for Msg Seq Num");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Msg Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + MsgSeqNum.Length;
    }

    /// <summary>
    ///  Encode Msg Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Msg Seq Num to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MsgSeqNum.Length)
        {
            throw new System.Exception("Invalid Length for Msg Seq Num");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Msg Seq Num to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MsgSeqNum.Length;
    }

    /// <summary>
    ///  Set Msg Seq Num to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Msg Seq Num
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + MsgSeqNum.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Msg Seq Num
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Msg Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MsgSeqNum.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Msg Seq Num
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
