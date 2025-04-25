using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Not Affected Security Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class NotAffectedSecurityId
{
    /// <summary>
    ///  Fix Tag for Not Affected Security Id
    /// </summary>
    public const ushort FixTag = 28702;

    /// <summary>
    ///  Length of Not Affected Security Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Not Affected Security Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Not Affected Security Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + NotAffectedSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Not Affected Security Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Not Affected Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NotAffectedSecurityId.Length;
    }

    /// <summary>
    ///  Encode Not Affected Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Not Affected Security Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NotAffectedSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Not Affected Security Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Not Affected Security Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NotAffectedSecurityId.Length;
    }

    /// <summary>
    ///  Set Not Affected Security Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Not Affected Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + NotAffectedSecurityId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Not Affected Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Not Affected Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NotAffectedSecurityId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Not Affected Security Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
