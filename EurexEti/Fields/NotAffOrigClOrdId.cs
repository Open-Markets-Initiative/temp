using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Not Aff Orig Cl Ord Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class NotAffOrigClOrdId
{
    /// <summary>
    ///  Fix Tag for Not Aff Orig Cl Ord Id
    /// </summary>
    public const ushort FixTag = 1372;

    /// <summary>
    ///  Length of Not Aff Orig Cl Ord Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Not Aff Orig Cl Ord Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Not Aff Orig Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + NotAffOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Not Aff Orig Cl Ord Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Not Aff Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NotAffOrigClOrdId.Length;
    }

    /// <summary>
    ///  Encode Not Aff Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Not Aff Orig Cl Ord Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NotAffOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Not Aff Orig Cl Ord Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Not Aff Orig Cl Ord Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NotAffOrigClOrdId.Length;
    }

    /// <summary>
    ///  Set Not Aff Orig Cl Ord Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Not Aff Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + NotAffOrigClOrdId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Not Aff Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Not Aff Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NotAffOrigClOrdId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Not Aff Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
