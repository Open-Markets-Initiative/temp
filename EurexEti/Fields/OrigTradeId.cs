using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Orig Trade Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class OrigTradeId
{
    /// <summary>
    ///  Fix Tag for Orig Trade Id
    /// </summary>
    public const ushort FixTag = 1126;

    /// <summary>
    ///  Length of Orig Trade Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Orig Trade Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Orig Trade Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + OrigTradeId.Length)
        {
            throw new System.Exception("Invalid Length for Orig Trade Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Orig Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + OrigTradeId.Length;
    }

    /// <summary>
    ///  Encode Orig Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Orig Trade Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrigTradeId.Length)
        {
            throw new System.Exception("Invalid Length for Orig Trade Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Orig Trade Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrigTradeId.Length;
    }

    /// <summary>
    ///  Set Orig Trade Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Orig Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + OrigTradeId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Orig Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Orig Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrigTradeId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Orig Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
