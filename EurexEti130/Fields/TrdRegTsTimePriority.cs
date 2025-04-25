using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trd Reg Ts Time Priority: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class TrdRegTsTimePriority
{
    /// <summary>
    ///  Fix Tag for Trd Reg Ts Time Priority
    /// </summary>
    public const ushort FixTag = 21008;

    /// <summary>
    ///  Length of Trd Reg Ts Time Priority in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Trd Reg Ts Time Priority
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Trd Reg Ts Time Priority
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + TrdRegTsTimePriority.Length)
        {
            throw new System.Exception("Invalid Length for Trd Reg Ts Time Priority");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trd Reg Ts Time Priority
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + TrdRegTsTimePriority.Length;
    }

    /// <summary>
    ///  Encode Trd Reg Ts Time Priority
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Trd Reg Ts Time Priority to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TrdRegTsTimePriority.Length)
        {
            throw new System.Exception("Invalid Length for Trd Reg Ts Time Priority");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trd Reg Ts Time Priority to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TrdRegTsTimePriority.Length;
    }

    /// <summary>
    ///  Set Trd Reg Ts Time Priority to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trd Reg Ts Time Priority
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + TrdRegTsTimePriority.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trd Reg Ts Time Priority
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trd Reg Ts Time Priority
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TrdRegTsTimePriority.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trd Reg Ts Time Priority
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
