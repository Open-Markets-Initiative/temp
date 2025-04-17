using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Triggered: Enum
/// </summary>

public static class Triggered
{
    /// <summary>
    ///  
    /// </summary>
    public const byte Nottriggered = 0;

    /// <summary>
    ///  
    /// </summary>
    public const byte TriggeredStop = 1;

    /// <summary>
    ///  
    /// </summary>
    public const byte TriggeredOco = 2;

    /// <summary>
    ///  Fix Tag for Triggered
    /// </summary>
    public const ushort FixTag = 1823;

    /// <summary>
    ///  Length of Triggered in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Triggered
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Triggered
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + Triggered.Length)
        {
            throw new System.Exception("Invalid Length for Triggered");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Triggered
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + Triggered.Length;
    }

    /// <summary>
    ///  Check available length and set Triggered to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + Triggered.Length)
        {
            throw new System.Exception("Invalid Length for Triggered");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Triggered to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + Triggered.Length;
    }

    /// <summary>
    ///  Set Triggered to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Triggered
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + Triggered.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Triggered
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Triggered
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Triggered.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Triggered
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
