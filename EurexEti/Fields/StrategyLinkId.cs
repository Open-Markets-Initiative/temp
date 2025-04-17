using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Strategy Link Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class StrategyLinkId
{
    /// <summary>
    ///  Fix Tag for Strategy Link Id
    /// </summary>
    public const ushort FixTag = 1851;

    /// <summary>
    ///  Length of Strategy Link Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Strategy Link Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Strategy Link Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + StrategyLinkId.Length)
        {
            throw new System.Exception("Invalid Length for Strategy Link Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Strategy Link Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + StrategyLinkId.Length;
    }

    /// <summary>
    ///  Encode Strategy Link Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Strategy Link Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + StrategyLinkId.Length)
        {
            throw new System.Exception("Invalid Length for Strategy Link Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Strategy Link Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + StrategyLinkId.Length;
    }

    /// <summary>
    ///  Set Strategy Link Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Strategy Link Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + StrategyLinkId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Strategy Link Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Strategy Link Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + StrategyLinkId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Strategy Link Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
