using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Check Sum Correction: Optional 2 Byte Fixed Width Integer
/// </summary>

public static class CheckSumCorrection
{
    /// <summary>
    ///  Fix Tag for Check Sum Correction
    /// </summary>
    public const ushort FixTag = 30010;

    /// <summary>
    ///  Length of Check Sum Correction in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Check Sum Correction
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Check Sum Correction
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + CheckSumCorrection.Length)
        {
            throw new System.Exception("Invalid Length for Check Sum Correction");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Check Sum Correction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + CheckSumCorrection.Length;
    }

    /// <summary>
    ///  Encode Check Sum Correction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Check Sum Correction to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + CheckSumCorrection.Length)
        {
            throw new System.Exception("Invalid Length for Check Sum Correction");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Check Sum Correction to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + CheckSumCorrection.Length;
    }

    /// <summary>
    ///  Set Check Sum Correction to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Check Sum Correction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + CheckSumCorrection.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Check Sum Correction
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Check Sum Correction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + CheckSumCorrection.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Check Sum Correction
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
