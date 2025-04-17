using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Orig Basket Trd Match Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class OrigBasketTrdMatchId
{
    /// <summary>
    ///  Fix Tag for Orig Basket Trd Match Id
    /// </summary>
    public const ushort FixTag = 25248;

    /// <summary>
    ///  Length of Orig Basket Trd Match Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Orig Basket Trd Match Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Orig Basket Trd Match Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + OrigBasketTrdMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Orig Basket Trd Match Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Orig Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + OrigBasketTrdMatchId.Length;
    }

    /// <summary>
    ///  Encode Orig Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Orig Basket Trd Match Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrigBasketTrdMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Orig Basket Trd Match Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Orig Basket Trd Match Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrigBasketTrdMatchId.Length;
    }

    /// <summary>
    ///  Set Orig Basket Trd Match Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Orig Basket Trd Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + OrigBasketTrdMatchId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Orig Basket Trd Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Orig Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrigBasketTrdMatchId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Orig Basket Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
