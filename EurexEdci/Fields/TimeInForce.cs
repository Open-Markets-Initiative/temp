using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Time In Force: Enum
/// </summary>

public static class TimeInForce
{
    /// <summary>
    ///  Day (GFD)
    /// </summary>
    public const byte Day = 0;

    /// <summary>
    ///  Good Till Cancelled (GTC) - Standard Orders only
    /// </summary>
    public const byte Gtc = 1;

    /// <summary>
    ///  Immediate or Cancel (IOC)
    /// </summary>
    public const byte Ioc = 3;

    /// <summary>
    ///  Fill Or Kill (FOK)
    /// </summary>
    public const byte Fok = 4;

    /// <summary>
    ///  Good Till Date (GTD) - Standard Orders only
    /// </summary>
    public const byte Gtd = 6;

    /// <summary>
    ///  Fix Tag for Time In Force
    /// </summary>
    public const ushort FixTag = 59;

    /// <summary>
    ///  Length of Time In Force in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Time In Force
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Time In Force
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TimeInForce.Length)
        {
            throw new System.Exception("Invalid Length for Time In Force");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Time In Force
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TimeInForce.Length;
    }

    /// <summary>
    ///  Check available length and set Time In Force to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TimeInForce.Length)
        {
            throw new System.Exception("Invalid Length for Time In Force");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Time In Force to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TimeInForce.Length;
    }

    /// <summary>
    ///  Set Time In Force to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Time In Force
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TimeInForce.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Time In Force
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Time In Force
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TimeInForce.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Time In Force
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
