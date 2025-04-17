using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Cross Request Type: Enum
/// </summary>

public static class CrossRequestType
{
    /// <summary>
    ///  Cross Announcement
    /// </summary>
    public const byte Cross = 1;

    /// <summary>
    ///  Liquidity Improvement Cross
    /// </summary>
    public const byte Clip = 2;

    /// <summary>
    ///  Fix Tag for Cross Request Type
    /// </summary>
    public const ushort FixTag = 28771;

    /// <summary>
    ///  Length of Cross Request Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Cross Request Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Cross Request Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + CrossRequestType.Length)
        {
            throw new System.Exception("Invalid Length for Cross Request Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Cross Request Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + CrossRequestType.Length;
    }

    /// <summary>
    ///  Check available length and set Cross Request Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + CrossRequestType.Length)
        {
            throw new System.Exception("Invalid Length for Cross Request Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Cross Request Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + CrossRequestType.Length;
    }

    /// <summary>
    ///  Set Cross Request Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Cross Request Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + CrossRequestType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Cross Request Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Cross Request Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + CrossRequestType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Cross Request Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
