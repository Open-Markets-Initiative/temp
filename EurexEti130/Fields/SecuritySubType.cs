using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Security Sub Type: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class SecuritySubType
{
    /// <summary>
    ///  Fix Tag for Security Sub Type
    /// </summary>
    public const ushort FixTag = 762;

    /// <summary>
    ///  Length of Security Sub Type in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Security Sub Type
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Security Sub Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + SecuritySubType.Length)
        {
            throw new System.Exception("Invalid Length for Security Sub Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Security Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SecuritySubType.Length;
    }

    /// <summary>
    ///  Encode Security Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Security Sub Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SecuritySubType.Length)
        {
            throw new System.Exception("Invalid Length for Security Sub Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Security Sub Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SecuritySubType.Length;
    }

    /// <summary>
    ///  Set Security Sub Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Security Sub Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + SecuritySubType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Security Sub Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Security Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SecuritySubType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Security Sub Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
