using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Secondary Trade Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class SecondaryTradeId
{
    /// <summary>
    ///  Fix Tag for Secondary Trade Id
    /// </summary>
    public const ushort FixTag = 1040;

    /// <summary>
    ///  Length of Secondary Trade Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Secondary Trade Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Secondary Trade Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + SecondaryTradeId.Length)
        {
            throw new System.Exception("Invalid Length for Secondary Trade Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Secondary Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SecondaryTradeId.Length;
    }

    /// <summary>
    ///  Encode Secondary Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Secondary Trade Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SecondaryTradeId.Length)
        {
            throw new System.Exception("Invalid Length for Secondary Trade Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Secondary Trade Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SecondaryTradeId.Length;
    }

    /// <summary>
    ///  Set Secondary Trade Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Secondary Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + SecondaryTradeId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Secondary Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Secondary Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SecondaryTradeId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Secondary Trade Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
