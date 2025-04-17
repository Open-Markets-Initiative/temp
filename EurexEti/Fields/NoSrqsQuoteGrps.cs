using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Srqs Quote Grps: Runtime Count Field
/// </summary>

public static class NoSrqsQuoteGrps
{
    /// <summary>
    ///  Fix Tag for No Srqs Quote Grps
    /// </summary>
    public const ushort FixTag = 25218;

    /// <summary>
    ///  Length of No Srqs Quote Grps in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Srqs Quote Grps
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoSrqsQuoteGrps.Length)
        {
            throw new System.Exception("Invalid Length for No Srqs Quote Grps");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Srqs Quote Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoSrqsQuoteGrps.Length;
    }

    /// <summary>
    ///  Encode No Srqs Quote Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Srqs Quote Grps to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoSrqsQuoteGrps.Length)
        {
            throw new System.Exception("Invalid Length for No Srqs Quote Grps");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Srqs Quote Grps to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoSrqsQuoteGrps.Length;
    }

    /// <summary>
    ///  Set No Srqs Quote Grps to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Srqs Quote Grps
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoSrqsQuoteGrps.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Srqs Quote Grps
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Srqs Quote Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoSrqsQuoteGrps.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Srqs Quote Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
