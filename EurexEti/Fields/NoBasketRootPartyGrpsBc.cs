using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Basket Root Party Grps Bc: Runtime Count Field
/// </summary>

public static class NoBasketRootPartyGrpsBc
{
    /// <summary>
    ///  Fix Tag for No Basket Root Party Grps Bc
    /// </summary>
    public const ushort FixTag = 25171;

    /// <summary>
    ///  Length of No Basket Root Party Grps Bc in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode No Basket Root Party Grps Bc
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + NoBasketRootPartyGrpsBc.Length)
        {
            throw new System.Exception("Invalid Length for No Basket Root Party Grps Bc");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Basket Root Party Grps Bc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoBasketRootPartyGrpsBc.Length;
    }

    /// <summary>
    ///  Encode No Basket Root Party Grps Bc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value)
    {
        *(byte*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Basket Root Party Grps Bc to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoBasketRootPartyGrpsBc.Length)
        {
            throw new System.Exception("Invalid Length for No Basket Root Party Grps Bc");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Basket Root Party Grps Bc to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoBasketRootPartyGrpsBc.Length;
    }

    /// <summary>
    ///  Set No Basket Root Party Grps Bc to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Basket Root Party Grps Bc
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + NoBasketRootPartyGrpsBc.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Basket Root Party Grps Bc
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Basket Root Party Grps Bc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoBasketRootPartyGrpsBc.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Basket Root Party Grps Bc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
