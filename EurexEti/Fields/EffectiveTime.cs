using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Effective Time: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class EffectiveTime
{
    /// <summary>
    ///  Fix Tag for Effective Time
    /// </summary>
    public const ushort FixTag = 168;

    /// <summary>
    ///  Length of Effective Time in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Effective Time
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Effective Time
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + EffectiveTime.Length)
        {
            throw new System.Exception("Invalid Length for Effective Time");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Effective Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + EffectiveTime.Length;
    }

    /// <summary>
    ///  Encode Effective Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Effective Time to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + EffectiveTime.Length)
        {
            throw new System.Exception("Invalid Length for Effective Time");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Effective Time to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + EffectiveTime.Length;
    }

    /// <summary>
    ///  Set Effective Time to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Effective Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + EffectiveTime.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Effective Time
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Effective Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + EffectiveTime.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Effective Time
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
