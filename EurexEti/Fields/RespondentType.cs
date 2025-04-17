using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Respondent Type: Enum
/// </summary>

public static class RespondentType
{
    /// <summary>
    ///  Respondents are known during a negotiation
    /// </summary>
    public const byte AllMarketParticipants = 1;

    /// <summary>
    ///  Respondents are anonymized after negotiation start, Requester will remain anonymous from start
    /// </summary>
    public const byte Anonymous = 102;

    /// <summary>
    ///  Fix Tag for Respondent Type
    /// </summary>
    public const ushort FixTag = 1172;

    /// <summary>
    ///  Length of Respondent Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Respondent Type
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Respondent Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + RespondentType.Length)
        {
            throw new System.Exception("Invalid Length for Respondent Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Respondent Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + RespondentType.Length;
    }

    /// <summary>
    ///  Check available length and set Respondent Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RespondentType.Length)
        {
            throw new System.Exception("Invalid Length for Respondent Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Respondent Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RespondentType.Length;
    }

    /// <summary>
    ///  Set Respondent Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Respondent Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + RespondentType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Respondent Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Respondent Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RespondentType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Respondent Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
