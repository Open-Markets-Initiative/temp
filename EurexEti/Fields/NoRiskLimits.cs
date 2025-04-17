using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Risk Limits: Runtime Count Field
/// </summary>

public static class NoRiskLimits
{
    /// <summary>
    ///  Fix Tag for No Risk Limits
    /// </summary>
    public const ushort FixTag = 1669;

    /// <summary>
    ///  Length of No Risk Limits in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Risk Limits
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoRiskLimits.Length)
        {
            throw new System.Exception("Invalid Length for No Risk Limits");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Risk Limits
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoRiskLimits.Length;
    }

    /// <summary>
    ///  Encode No Risk Limits
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Risk Limits to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoRiskLimits.Length)
        {
            throw new System.Exception("Invalid Length for No Risk Limits");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Risk Limits to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoRiskLimits.Length;
    }

    /// <summary>
    ///  Set No Risk Limits to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Risk Limits
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoRiskLimits.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Risk Limits
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Risk Limits
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoRiskLimits.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Risk Limits
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
