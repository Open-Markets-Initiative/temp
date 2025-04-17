using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Order Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class OrderId
{
    /// <summary>
    ///  Fix Tag for Order Id
    /// </summary>
    public const ushort FixTag = 37;

    /// <summary>
    ///  Length of Order Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Order Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Order Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + OrderId.Length)
        {
            throw new System.Exception("Invalid Length for Order Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + OrderId.Length;
    }

    /// <summary>
    ///  Encode Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Order Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrderId.Length)
        {
            throw new System.Exception("Invalid Length for Order Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Order Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrderId.Length;
    }

    /// <summary>
    ///  Set Order Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Order Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + OrderId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Order Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrderId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Order Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
