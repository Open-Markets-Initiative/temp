using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Swap Clearer: Enum
/// </summary>

public static class SwapClearer
{
    /// <summary>
    ///  Eurex Clearing
    /// </summary>
    public const byte Ecag = 0;

    /// <summary>
    ///  Non-Eurex Clearing
    /// </summary>
    public const byte Nonecag = 1;

    /// <summary>
    ///  Fix Tag for Swap Clearer
    /// </summary>
    public const ushort FixTag = 25199;

    /// <summary>
    ///  Length of Swap Clearer in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Swap Clearer
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Swap Clearer
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + SwapClearer.Length)
        {
            throw new System.Exception("Invalid Length for Swap Clearer");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Swap Clearer
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + SwapClearer.Length;
    }

    /// <summary>
    ///  Check available length and set Swap Clearer to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SwapClearer.Length)
        {
            throw new System.Exception("Invalid Length for Swap Clearer");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Swap Clearer to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SwapClearer.Length;
    }

    /// <summary>
    ///  Set Swap Clearer to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Swap Clearer
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + SwapClearer.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Swap Clearer
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Swap Clearer
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SwapClearer.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Swap Clearer
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
