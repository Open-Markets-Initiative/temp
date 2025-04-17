using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Appl Seq Indicator: Enum
/// </summary>

public static class ApplSeqIndicator
{
    /// <summary>
    ///  
    /// </summary>
    public const byte NoRecoveryRequired = 0;

    /// <summary>
    ///  
    /// </summary>
    public const byte RecoveryRequired = 1;

    /// <summary>
    ///  Fix Tag for Appl Seq Indicator
    /// </summary>
    public const ushort FixTag = 28703;

    /// <summary>
    ///  Length of Appl Seq Indicator in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Appl Seq Indicator
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Appl Seq Indicator
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ApplSeqIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Appl Seq Indicator");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Seq Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ApplSeqIndicator.Length;
    }

    /// <summary>
    ///  Check available length and set Appl Seq Indicator to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ApplSeqIndicator.Length)
        {
            throw new System.Exception("Invalid Length for Appl Seq Indicator");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Appl Seq Indicator to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ApplSeqIndicator.Length;
    }

    /// <summary>
    ///  Set Appl Seq Indicator to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Appl Seq Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ApplSeqIndicator.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Appl Seq Indicator
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Appl Seq Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplSeqIndicator.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Seq Indicator
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
