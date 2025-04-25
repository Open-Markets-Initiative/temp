using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Executing Trader: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class ExecutingTrader
{
    /// <summary>
    ///  Fix Tag for Executing Trader
    /// </summary>
    public const ushort FixTag = 25123;

    /// <summary>
    ///  Length of Executing Trader in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Executing Trader
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Executing Trader
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + ExecutingTrader.Length)
        {
            throw new System.Exception("Invalid Length for Executing Trader");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Executing Trader
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ExecutingTrader.Length;
    }

    /// <summary>
    ///  Encode Executing Trader
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Executing Trader to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExecutingTrader.Length)
        {
            throw new System.Exception("Invalid Length for Executing Trader");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Executing Trader to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExecutingTrader.Length;
    }

    /// <summary>
    ///  Set Executing Trader to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Executing Trader
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + ExecutingTrader.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Executing Trader
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Executing Trader
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExecutingTrader.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Executing Trader
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
