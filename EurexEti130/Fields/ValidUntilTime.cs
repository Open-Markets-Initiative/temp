using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Valid Until Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ValidUntilTime
{
    /// <summary>
    ///  Fix Tag for Valid Until Time
    /// </summary>
    public const ushort FixTag = 62;

    /// <summary>
    ///  Length of Valid Until Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Valid Until Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Valid Until Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ValidUntilTime.Length)
        {
            throw new System.Exception("Invalid Length for Valid Until Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Valid Until Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ValidUntilTime.Length;
    }

    /// <summary>
    ///  Encode Valid Until Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Valid Until Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ValidUntilTime.Length)
        {
            throw new System.Exception("Invalid Length for Valid Until Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Valid Until Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ValidUntilTime.Length;
    }

    /// <summary>
    ///  Set Valid Until Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Valid Until Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ValidUntilTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Valid Until Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Valid Until Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ValidUntilTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Valid Until Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
