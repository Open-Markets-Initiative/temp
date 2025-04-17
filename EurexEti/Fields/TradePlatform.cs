using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Trade Platform: Enum
/// </summary>

public static class TradePlatform
{
    /// <summary>
    ///  Off-Book
    /// </summary>
    public const byte OffBook = 0;

    /// <summary>
    ///  On-Book
    /// </summary>
    public const byte OnBook = 1;

    /// <summary>
    ///  Fix Tag for Trade Platform
    /// </summary>
    public const ushort FixTag = 25160;

    /// <summary>
    ///  Length of Trade Platform in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trade Platform
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trade Platform
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradePlatform.Length)
        {
            throw new System.Exception("Invalid Length for Trade Platform");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade Platform
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradePlatform.Length;
    }

    /// <summary>
    ///  Check available length and set Trade Platform to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradePlatform.Length)
        {
            throw new System.Exception("Invalid Length for Trade Platform");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade Platform to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradePlatform.Length;
    }

    /// <summary>
    ///  Set Trade Platform to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade Platform
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradePlatform.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade Platform
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trade Platform
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradePlatform.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade Platform
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
