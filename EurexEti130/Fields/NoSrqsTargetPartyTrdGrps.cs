using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Srqs Target Party Trd Grps: Runtime Count Field
/// </summary>

public static class NoSrqsTargetPartyTrdGrps
{
    /// <summary>
    ///  Fix Tag for No Srqs Target Party Trd Grps
    /// </summary>
    public const ushort FixTag = 25219;

    /// <summary>
    ///  Length of No Srqs Target Party Trd Grps in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Srqs Target Party Trd Grps
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoSrqsTargetPartyTrdGrps.Length)
        {
            throw new System.Exception("Invalid Length for No Srqs Target Party Trd Grps");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Srqs Target Party Trd Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoSrqsTargetPartyTrdGrps.Length;
    }

    /// <summary>
    ///  Encode No Srqs Target Party Trd Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Srqs Target Party Trd Grps to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoSrqsTargetPartyTrdGrps.Length)
        {
            throw new System.Exception("Invalid Length for No Srqs Target Party Trd Grps");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Srqs Target Party Trd Grps to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoSrqsTargetPartyTrdGrps.Length;
    }

    /// <summary>
    ///  Set No Srqs Target Party Trd Grps to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Srqs Target Party Trd Grps
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoSrqsTargetPartyTrdGrps.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Srqs Target Party Trd Grps
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Srqs Target Party Trd Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoSrqsTargetPartyTrdGrps.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Srqs Target Party Trd Grps
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
