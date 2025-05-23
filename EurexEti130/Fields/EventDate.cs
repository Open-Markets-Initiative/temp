using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Event Date: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class EventDate
{
    /// <summary>
    ///  Fix Tag for Event Date
    /// </summary>
    public const ushort FixTag = 866;

    /// <summary>
    ///  Length of Event Date in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Event Date
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Event Date
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + EventDate.Length)
        {
            throw new System.Exception("Invalid Length for Event Date");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Event Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + EventDate.Length;
    }

    /// <summary>
    ///  Encode Event Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Event Date to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + EventDate.Length)
        {
            throw new System.Exception("Invalid Length for Event Date");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Event Date to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + EventDate.Length;
    }

    /// <summary>
    ///  Set Event Date to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Event Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + EventDate.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Event Date
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Event Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + EventDate.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Event Date
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
