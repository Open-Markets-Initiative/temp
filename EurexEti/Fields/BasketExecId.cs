using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Basket Exec Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class BasketExecId
{
    /// <summary>
    ///  Fix Tag for Basket Exec Id
    /// </summary>
    public const ushort FixTag = 25167;

    /// <summary>
    ///  Length of Basket Exec Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Basket Exec Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Basket Exec Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + BasketExecId.Length)
        {
            throw new System.Exception("Invalid Length for Basket Exec Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Basket Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + BasketExecId.Length;
    }

    /// <summary>
    ///  Encode Basket Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Basket Exec Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + BasketExecId.Length)
        {
            throw new System.Exception("Invalid Length for Basket Exec Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Basket Exec Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + BasketExecId.Length;
    }

    /// <summary>
    ///  Set Basket Exec Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Basket Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + BasketExecId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Basket Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Basket Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + BasketExecId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Basket Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
