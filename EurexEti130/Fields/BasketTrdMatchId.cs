using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Basket Trd Match Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class BasketTrdMatchId
{
    /// <summary>
    ///  Fix Tag for Basket Trd Match Id
    /// </summary>
    public const ushort FixTag = 25161;

    /// <summary>
    ///  Length of Basket Trd Match Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Basket Trd Match Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Basket Trd Match Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + BasketTrdMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Basket Trd Match Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + BasketTrdMatchId.Length;
    }

    /// <summary>
    ///  Encode Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Basket Trd Match Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + BasketTrdMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Basket Trd Match Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Basket Trd Match Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + BasketTrdMatchId.Length;
    }

    /// <summary>
    ///  Set Basket Trd Match Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Basket Trd Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + BasketTrdMatchId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Basket Trd Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + BasketTrdMatchId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
