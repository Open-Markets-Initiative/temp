using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Order Event Match Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class OrderEventMatchId
{
    /// <summary>
    ///  Fix Tag for Order Event Match Id
    /// </summary>
    public const ushort FixTag = 30060;

    /// <summary>
    ///  Length of Order Event Match Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Order Event Match Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Order Event Match Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + OrderEventMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Order Event Match Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Order Event Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + OrderEventMatchId.Length;
    }

    /// <summary>
    ///  Encode Order Event Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Order Event Match Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + OrderEventMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Order Event Match Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Order Event Match Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + OrderEventMatchId.Length;
    }

    /// <summary>
    ///  Set Order Event Match Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Order Event Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + OrderEventMatchId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Order Event Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Order Event Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + OrderEventMatchId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Order Event Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
