using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Fill Ref Id: Optional 1 Byte Fixed Width Integer
/// </summary>

public static class FillRefId
{
    /// <summary>
    ///  Fix Tag for Fill Ref Id
    /// </summary>
    public const ushort FixTag = 2421;

    /// <summary>
    ///  Length of Fill Ref Id in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Fill Ref Id
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Fill Ref Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + FillRefId.Length)
        {
            throw new System.Exception("Invalid Length for Fill Ref Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fill Ref Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + FillRefId.Length;
    }

    /// <summary>
    ///  Encode Fill Ref Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Fill Ref Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FillRefId.Length)
        {
            throw new System.Exception("Invalid Length for Fill Ref Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fill Ref Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FillRefId.Length;
    }

    /// <summary>
    ///  Set Fill Ref Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Fill Ref Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + FillRefId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fill Ref Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Fill Ref Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FillRefId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fill Ref Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
