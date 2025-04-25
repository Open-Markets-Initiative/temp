using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Appl Resend Flag: Enum
/// </summary>

public static class ApplResendFlag
{
    /// <summary>
    ///  False
    /// </summary>
    public const byte False = 0;

    /// <summary>
    ///  True
    /// </summary>
    public const byte True = 1;

    /// <summary>
    ///  Fix Tag for Appl Resend Flag
    /// </summary>
    public const ushort FixTag = 1352;

    /// <summary>
    ///  Length of Appl Resend Flag in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Appl Resend Flag
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Appl Resend Flag
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ApplResendFlag.Length)
        {
            throw new System.Exception("Invalid Length for Appl Resend Flag");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Resend Flag
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ApplResendFlag.Length;
    }

    /// <summary>
    ///  Check available length and set Appl Resend Flag to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ApplResendFlag.Length)
        {
            throw new System.Exception("Invalid Length for Appl Resend Flag");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Appl Resend Flag to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ApplResendFlag.Length;
    }

    /// <summary>
    ///  Set Appl Resend Flag to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Appl Resend Flag
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ApplResendFlag.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Appl Resend Flag
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Appl Resend Flag
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplResendFlag.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Resend Flag
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
