using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Exec Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ExecId
{
    /// <summary>
    ///  Fix Tag for Exec Id
    /// </summary>
    public const ushort FixTag = 17;

    /// <summary>
    ///  Length of Exec Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Exec Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Exec Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ExecId.Length)
        {
            throw new System.Exception("Invalid Length for Exec Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ExecId.Length;
    }

    /// <summary>
    ///  Encode Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Exec Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExecId.Length)
        {
            throw new System.Exception("Invalid Length for Exec Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Exec Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExecId.Length;
    }

    /// <summary>
    ///  Set Exec Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ExecId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExecId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
