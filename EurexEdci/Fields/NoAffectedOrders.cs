using System.Runtime.CompilerServices;

namespace Eurex.Edci.v130;

/// <summary>
///  No Affected Orders: Runtime Count Field
/// </summary>

public static class NoAffectedOrders
{
    /// <summary>
    ///  Fix Tag for No Affected Orders
    /// </summary>
    public const ushort FixTag = 1370;

    /// <summary>
    ///  Length of No Affected Orders in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Affected Orders
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoAffectedOrders.Length)
        {
            throw new System.Exception("Invalid Length for No Affected Orders");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Affected Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoAffectedOrders.Length;
    }

    /// <summary>
    ///  Encode No Affected Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Affected Orders to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoAffectedOrders.Length)
        {
            throw new System.Exception("Invalid Length for No Affected Orders");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Affected Orders to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoAffectedOrders.Length;
    }

    /// <summary>
    ///  Set No Affected Orders to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Affected Orders
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoAffectedOrders.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Affected Orders
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Affected Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoAffectedOrders.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Affected Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
