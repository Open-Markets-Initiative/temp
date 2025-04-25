using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Leg Position Effect: Enum
/// </summary>

public static class LegPositionEffect
{
    /// <summary>
    ///  Close
    /// </summary>
    public const char Close = 'C';

    /// <summary>
    ///  Open
    /// </summary>
    public const char Open = 'O';

    /// <summary>
    ///  Fix Tag for Leg Position Effect
    /// </summary>
    public const ushort FixTag = 564;

    /// <summary>
    ///  Length of Leg Position Effect in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode Leg Position Effect
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
    {
        if (length > offset + LegPositionEffect.Length)
        {
            throw new System.Exception("Invalid Length for Leg Position Effect");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Leg Position Effect
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

        Encode(pointer, offset, character, out current);
    }

    /// <summary>
    ///  Encode Leg Position Effect
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
    {
        *(char*) (pointer + offset) = value;

        current = offset + LegPositionEffect.Length;
    }

    /// <summary>
    ///  TryDecode Leg Position Effect
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
    {
        if (length > offset + LegPositionEffect.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Leg Position Effect
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LegPositionEffect.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Leg Position Effect
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset)
    {
        return *(char*) (pointer + offset);
    }
}
