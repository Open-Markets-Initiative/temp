using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  No Old Basket Side Alloc: Runtime Count Field
/// </summary>

public static class NoOldBasketSideAlloc
{
    /// <summary>
    ///  Fix Tag for No Old Basket Side Alloc
    /// </summary>
    public const ushort FixTag = 25250;

    /// <summary>
    ///  Length of No Old Basket Side Alloc in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Old Basket Side Alloc
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoOldBasketSideAlloc.Length)
        {
            throw new System.Exception("Invalid Length for No Old Basket Side Alloc");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Old Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoOldBasketSideAlloc.Length;
    }

    /// <summary>
    ///  Encode No Old Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Old Basket Side Alloc to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoOldBasketSideAlloc.Length)
        {
            throw new System.Exception("Invalid Length for No Old Basket Side Alloc");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Old Basket Side Alloc to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoOldBasketSideAlloc.Length;
    }

    /// <summary>
    ///  Set No Old Basket Side Alloc to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Old Basket Side Alloc
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoOldBasketSideAlloc.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Old Basket Side Alloc
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Old Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoOldBasketSideAlloc.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Old Basket Side Alloc
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
