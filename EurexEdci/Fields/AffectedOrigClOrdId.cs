using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Affected Orig Cl Ord Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class AffectedOrigClOrdId
{
    /// <summary>
    ///  Fix Tag for Affected Orig Cl Ord Id
    /// </summary>
    public const ushort FixTag = 1824;

    /// <summary>
    ///  Length of Affected Orig Cl Ord Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Affected Orig Cl Ord Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Affected Orig Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + AffectedOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Orig Cl Ord Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Affected Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + AffectedOrigClOrdId.Length;
    }

    /// <summary>
    ///  Encode Affected Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Affected Orig Cl Ord Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + AffectedOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Orig Cl Ord Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Affected Orig Cl Ord Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + AffectedOrigClOrdId.Length;
    }

    /// <summary>
    ///  Set Affected Orig Cl Ord Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Affected Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + AffectedOrigClOrdId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Affected Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Affected Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + AffectedOrigClOrdId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Affected Orig Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
