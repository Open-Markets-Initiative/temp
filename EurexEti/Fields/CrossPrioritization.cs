using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Cross Prioritization: Enum
/// </summary>

public static class CrossPrioritization
{
    /// <summary>
    ///  Buy side is prioritized
    /// </summary>
    public const byte Buyside = 1;

    /// <summary>
    ///  Sell side is prioritized
    /// </summary>
    public const byte Sellside = 2;

    /// <summary>
    ///  Fix Tag for Cross Prioritization
    /// </summary>
    public const ushort FixTag = 550;

    /// <summary>
    ///  Length of Cross Prioritization in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Cross Prioritization
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Cross Prioritization
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + CrossPrioritization.Length)
        {
            throw new System.Exception("Invalid Length for Cross Prioritization");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Cross Prioritization
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + CrossPrioritization.Length;
    }

    /// <summary>
    ///  Check available length and set Cross Prioritization to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + CrossPrioritization.Length)
        {
            throw new System.Exception("Invalid Length for Cross Prioritization");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Cross Prioritization to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + CrossPrioritization.Length;
    }

    /// <summary>
    ///  Set Cross Prioritization to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Cross Prioritization
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + CrossPrioritization.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Cross Prioritization
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Cross Prioritization
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + CrossPrioritization.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Cross Prioritization
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
