using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Quote Event Exec Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class QuoteEventExecId
{
    /// <summary>
    ///  Fix Tag for Quote Event Exec Id
    /// </summary>
    public const ushort FixTag = 28711;

    /// <summary>
    ///  Length of Quote Event Exec Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Quote Event Exec Id
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Quote Event Exec Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + QuoteEventExecId.Length)
        {
            throw new System.Exception("Invalid Length for Quote Event Exec Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Quote Event Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + QuoteEventExecId.Length;
    }

    /// <summary>
    ///  Encode Quote Event Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Quote Event Exec Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + QuoteEventExecId.Length)
        {
            throw new System.Exception("Invalid Length for Quote Event Exec Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Quote Event Exec Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + QuoteEventExecId.Length;
    }

    /// <summary>
    ///  Set Quote Event Exec Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Quote Event Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + QuoteEventExecId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Quote Event Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Quote Event Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + QuoteEventExecId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Quote Event Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
