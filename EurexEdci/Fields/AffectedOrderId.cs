using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Affected Order Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class AffectedOrderId
{
    /// <summary>
    ///  Fix Tag for Affected Order Id
    /// </summary>
    public const ushort FixTag = 535;

    /// <summary>
    ///  Length of Affected Order Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Affected Order Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Affected Order Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + AffectedOrderId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Order Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Affected Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + AffectedOrderId.Length;
    }

    /// <summary>
    ///  Encode Affected Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Affected Order Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + AffectedOrderId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Order Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Affected Order Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + AffectedOrderId.Length;
    }

    /// <summary>
    ///  Set Affected Order Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Affected Order Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + AffectedOrderId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Affected Order Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Affected Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + AffectedOrderId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Affected Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
