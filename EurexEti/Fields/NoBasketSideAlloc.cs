using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Basket Side Alloc: Runtime Count Field
/// </summary>

public static class NoBasketSideAlloc
{
    /// <summary>
    ///  Fix Tag for No Basket Side Alloc
    /// </summary>
    public const ushort FixTag = 25169;

    /// <summary>
    ///  Length of No Basket Side Alloc in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Basket Side Alloc
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoBasketSideAlloc.Length)
        {
            throw new System.Exception("Invalid Length for No Basket Side Alloc");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoBasketSideAlloc.Length;
    }

    /// <summary>
    ///  Encode No Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Basket Side Alloc to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoBasketSideAlloc.Length)
        {
            throw new System.Exception("Invalid Length for No Basket Side Alloc");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Basket Side Alloc to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoBasketSideAlloc.Length;
    }

    /// <summary>
    ///  Set No Basket Side Alloc to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Basket Side Alloc
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoBasketSideAlloc.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Basket Side Alloc
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoBasketSideAlloc.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
