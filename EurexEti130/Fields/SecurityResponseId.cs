using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Security Response Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class SecurityResponseId
{
    /// <summary>
    ///  Fix Tag for Security Response Id
    /// </summary>
    public const ushort FixTag = 322;

    /// <summary>
    ///  Length of Security Response Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Security Response Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Security Response Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + SecurityResponseId.Length)
        {
            throw new System.Exception("Invalid Length for Security Response Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Security Response Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SecurityResponseId.Length;
    }

    /// <summary>
    ///  Encode Security Response Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Security Response Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SecurityResponseId.Length)
        {
            throw new System.Exception("Invalid Length for Security Response Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Security Response Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SecurityResponseId.Length;
    }

    /// <summary>
    ///  Set Security Response Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Security Response Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + SecurityResponseId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Security Response Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Security Response Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SecurityResponseId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Security Response Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
