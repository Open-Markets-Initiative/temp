using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Transact Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class TransactTime
{
    /// <summary>
    ///  Fix Tag for Transact Time
    /// </summary>
    public const ushort FixTag = 60;

    /// <summary>
    ///  Length of Transact Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Transact Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Transact Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + TransactTime.Length)
        {
            throw new System.Exception("Invalid Length for Transact Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Transact Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + TransactTime.Length;
    }

    /// <summary>
    ///  Encode Transact Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Transact Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TransactTime.Length)
        {
            throw new System.Exception("Invalid Length for Transact Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Transact Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TransactTime.Length;
    }

    /// <summary>
    ///  Set Transact Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Transact Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + TransactTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Transact Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Transact Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TransactTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Transact Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
