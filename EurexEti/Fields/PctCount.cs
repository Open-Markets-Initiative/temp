using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Pct Count: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class PctCount
{
    /// <summary>
    ///  Fix Tag for Pct Count
    /// </summary>
    public const ushort FixTag = 28615;

    /// <summary>
    ///  Length of Pct Count in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Pct Count
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Pct Count
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + PctCount.Length)
        {
            throw new System.Exception("Invalid Length for Pct Count");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Pct Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + PctCount.Length;
    }

    /// <summary>
    ///  Encode Pct Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Pct Count to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PctCount.Length)
        {
            throw new System.Exception("Invalid Length for Pct Count");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Pct Count to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + PctCount.Length;
    }

    /// <summary>
    ///  Set Pct Count to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Pct Count
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + PctCount.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Pct Count
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Pct Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PctCount.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Pct Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
