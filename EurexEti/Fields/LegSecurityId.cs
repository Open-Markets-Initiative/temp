using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Leg Security Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class LegSecurityId
{
    /// <summary>
    ///  Fix Tag for Leg Security Id
    /// </summary>
    public const ushort FixTag = 602;

    /// <summary>
    ///  Length of Leg Security Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Leg Security Id
    /// </summary>
    public const long NoValue = unchecked((long)0x8000000000000000);

    /// <summary>
    ///  Encode Leg Security Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
    {
        if (length > offset + LegSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Leg Security Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Leg Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + LegSecurityId.Length;
    }

    /// <summary>
    ///  Encode Leg Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value)
    {
        *(long*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Leg Security Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LegSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Leg Security Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Leg Security Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LegSecurityId.Length;
    }

    /// <summary>
    ///  Set Leg Security Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(long*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Leg Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
    {
        if (length > offset + LegSecurityId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Leg Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out long value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Leg Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LegSecurityId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Leg Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset)
    {
        return *(long*) (pointer + offset);
    }
}
