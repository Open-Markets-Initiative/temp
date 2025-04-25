using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Optional Early Termination Indicator: Enum
/// </summary>

public static class OptionalEarlyTerminationIndicator
{
    /// <summary>
    ///  No
    /// </summary>
    public const byte No = 0;

    /// <summary>
    ///  Yes
    /// </summary>
    public const byte Yes = 1;

    /// <summary>
    ///  Fix Tag for Optional Early Termination Indicator
    /// </summary>
    public const ushort FixTag = 25247;

    /// <summary>
    ///  Length of Optional Early Termination Indicator in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Optional Early Termination Indicator
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Optional Early Termination Indicator
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + OptionalEarlyTerminationIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Optional Early Termination Indicator");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Optional Early Termination Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + OptionalEarlyTerminationIndicator.Length;
    }

    /// <summary>
    ///  Check available length and set Optional Early Termination Indicator to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OptionalEarlyTerminationIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Optional Early Termination Indicator");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Optional Early Termination Indicator to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OptionalEarlyTerminationIndicator.Length;
    }

    /// <summary>
    ///  Set Optional Early Termination Indicator to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Optional Early Termination Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + OptionalEarlyTerminationIndicator.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Optional Early Termination Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Optional Early Termination Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OptionalEarlyTerminationIndicator.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Optional Early Termination Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
