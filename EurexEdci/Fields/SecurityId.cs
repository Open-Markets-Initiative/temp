using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Security Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class SecurityId
{
    /// <summary>
    ///  Fix Tag for Security Id
    /// </summary>
    public const ushort FixTag = 48;

    /// <summary>
    ///  Length of Security Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Security Id
    /// </summary>
    public const long NoValue = unchecked((long)0x8000000000000000);

    /// <summary>
    ///  Encode Security Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
    {
        if (length > offset + SecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Security Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SecurityId.Length;
    }

    /// <summary>
    ///  Encode Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, long value)
    {
        *(long*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Security Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Security Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Security Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SecurityId.Length;
    }

    /// <summary>
    ///  Set Security Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(long*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
    {
        if (length > offset + SecurityId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out long value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SecurityId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static long Decode(byte* pointer, int offset)
    {
        return *(long*) (pointer + offset);
    }
}
