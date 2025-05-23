using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Number Of Securities: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class NumberOfSecurities
{
    /// <summary>
    ///  Fix Tag for Number Of Securities
    /// </summary>
    public const ushort FixTag = 28614;

    /// <summary>
    ///  Length of Number Of Securities in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Number Of Securities
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Number Of Securities
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + NumberOfSecurities.Length)
        {
            throw new System.Exception("Invalid Length for Number Of Securities");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Number Of Securities
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NumberOfSecurities.Length;
    }

    /// <summary>
    ///  Encode Number Of Securities
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Number Of Securities to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NumberOfSecurities.Length)
        {
            throw new System.Exception("Invalid Length for Number Of Securities");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Number Of Securities to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NumberOfSecurities.Length;
    }

    /// <summary>
    ///  Set Number Of Securities to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Number Of Securities
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + NumberOfSecurities.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Number Of Securities
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Number Of Securities
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NumberOfSecurities.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Number Of Securities
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
