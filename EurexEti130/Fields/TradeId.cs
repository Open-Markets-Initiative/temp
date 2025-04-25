using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trade Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class TradeId
{
    /// <summary>
    ///  Fix Tag for Trade Id
    /// </summary>
    public const ushort FixTag = 1003;

    /// <summary>
    ///  Length of Trade Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Trade Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Trade Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + TradeId.Length)
        {
            throw new System.Exception("Invalid Length for Trade Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + TradeId.Length;
    }

    /// <summary>
    ///  Encode Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Trade Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradeId.Length)
        {
            throw new System.Exception("Invalid Length for Trade Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradeId.Length;
    }

    /// <summary>
    ///  Set Trade Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + TradeId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradeId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
