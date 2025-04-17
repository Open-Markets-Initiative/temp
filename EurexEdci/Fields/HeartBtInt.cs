using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Heart Bt Int: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class HeartBtInt
{
    /// <summary>
    ///  Fix Tag for Heart Bt Int
    /// </summary>
    public const ushort FixTag = 108;

    /// <summary>
    ///  Length of Heart Bt Int in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Heart Bt Int
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Heart Bt Int
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + HeartBtInt.Length)
        {
            throw new System.Exception("Invalid Length for Heart Bt Int");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Heart Bt Int
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + HeartBtInt.Length;
    }

    /// <summary>
    ///  Encode Heart Bt Int
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Heart Bt Int to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + HeartBtInt.Length)
        {
            throw new System.Exception("Invalid Length for Heart Bt Int");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Heart Bt Int to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + HeartBtInt.Length;
    }

    /// <summary>
    ///  Set Heart Bt Int to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Heart Bt Int
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + HeartBtInt.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Heart Bt Int
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Heart Bt Int
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + HeartBtInt.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Heart Bt Int
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
