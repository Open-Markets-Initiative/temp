using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Root Party Id Investment Decision Maker Qualifier: Enum
/// </summary>

public static class RootPartyIdInvestmentDecisionMakerQualifier
{
    /// <summary>
    ///  Algo
    /// </summary>
    public const byte Algo = 22;

    /// <summary>
    ///  Human/Natural person
    /// </summary>
    public const byte Human = 24;

    /// <summary>
    ///  Fix Tag for Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    public const ushort FixTag = 21622;

    /// <summary>
    ///  Length of Root Party Id Investment Decision Maker Qualifier in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + RootPartyIdInvestmentDecisionMakerQualifier.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Investment Decision Maker Qualifier");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + RootPartyIdInvestmentDecisionMakerQualifier.Length;
    }

    /// <summary>
    ///  Check available length and set Root Party Id Investment Decision Maker Qualifier to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartyIdInvestmentDecisionMakerQualifier.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Investment Decision Maker Qualifier");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Id Investment Decision Maker Qualifier to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartyIdInvestmentDecisionMakerQualifier.Length;
    }

    /// <summary>
    ///  Set Root Party Id Investment Decision Maker Qualifier to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + RootPartyIdInvestmentDecisionMakerQualifier.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartyIdInvestmentDecisionMakerQualifier.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Id Investment Decision Maker Qualifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
