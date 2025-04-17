using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Related Security Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class RelatedSecurityId
{
    /// <summary>
    ///  Fix Tag for Related Security Id
    /// </summary>
    public const ushort FixTag = 1650;

    /// <summary>
    ///  Length of Related Security Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Related Security Id
    /// </summary>
    public const long NoValue = unchecked((long)0x8000000000000000);

    /// <summary>
    ///  Encode Related Security Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
    {
        if (length > offset + RelatedSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Related Security Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Related Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RelatedSecurityId.Length;
    }

    /// <summary>
    ///  Encode Related Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value)
    {
        *(long*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Related Security Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RelatedSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Related Security Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Related Security Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RelatedSecurityId.Length;
    }

    /// <summary>
    ///  Set Related Security Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(long*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Related Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
    {
        if (length > offset + RelatedSecurityId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Related Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out long value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Related Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RelatedSecurityId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Related Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset)
    {
        return *(long*) (pointer + offset);
    }
}
