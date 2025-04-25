using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Number Of Respondents: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class NumberOfRespondents
{
    /// <summary>
    ///  Fix Tag for Number Of Respondents
    /// </summary>
    public const ushort FixTag = 25150;

    /// <summary>
    ///  Length of Number Of Respondents in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Number Of Respondents
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Number Of Respondents
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + NumberOfRespondents.Length)
        {
            throw new System.Exception("Invalid Length for Number Of Respondents");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Number Of Respondents
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NumberOfRespondents.Length;
    }

    /// <summary>
    ///  Encode Number Of Respondents
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Number Of Respondents to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NumberOfRespondents.Length)
        {
            throw new System.Exception("Invalid Length for Number Of Respondents");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Number Of Respondents to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + NumberOfRespondents.Length;
    }

    /// <summary>
    ///  Set Number Of Respondents to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Number Of Respondents
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + NumberOfRespondents.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Number Of Respondents
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Number Of Respondents
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NumberOfRespondents.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Number Of Respondents
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
