using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Party Details: Runtime Count Field
/// </summary>

public static class NoPartyDetails
{
    /// <summary>
    ///  Fix Tag for No Party Details
    /// </summary>
    public const ushort FixTag = 1671;

    /// <summary>
    ///  Length of No Party Details in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Party Details
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoPartyDetails.Length)
        {
            throw new System.Exception("Invalid Length for No Party Details");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Party Details
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoPartyDetails.Length;
    }

    /// <summary>
    ///  Encode No Party Details
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Party Details to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoPartyDetails.Length)
        {
            throw new System.Exception("Invalid Length for No Party Details");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Party Details to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoPartyDetails.Length;
    }

    /// <summary>
    ///  Set No Party Details to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Party Details
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoPartyDetails.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Party Details
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Party Details
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoPartyDetails.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Party Details
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
