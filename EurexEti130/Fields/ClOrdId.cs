using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Cl Ord Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ClOrdId
{
    /// <summary>
    ///  Fix Tag for Cl Ord Id
    /// </summary>
    public const ushort FixTag = 11;

    /// <summary>
    ///  Length of Cl Ord Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Cl Ord Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Cl Ord Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ClOrdId.Length;
    }

    /// <summary>
    ///  Encode Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Cl Ord Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Cl Ord Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Cl Ord Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ClOrdId.Length;
    }

    /// <summary>
    ///  Set Cl Ord Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ClOrdId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ClOrdId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Cl Ord Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
