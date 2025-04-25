using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Party Id Settlement Location: Enum
/// </summary>

public static class PartyIdSettlementLocation
{
    /// <summary>
    ///  Clearstrem Banking Frankfurt
    /// </summary>
    public const byte ClearstremBankingFrankfurt = 1;

    /// <summary>
    ///  Clearstrem Banking Luxemburg
    /// </summary>
    public const byte ClearstremBankingLuxemburg = 2;

    /// <summary>
    ///  CLS Group
    /// </summary>
    public const byte ClsGroup = 3;

    /// <summary>
    ///  Euroclear
    /// </summary>
    public const byte Euroclear = 4;

    /// <summary>
    ///  Fix Tag for Party Id Settlement Location
    /// </summary>
    public const ushort FixTag = 20010;

    /// <summary>
    ///  Length of Party Id Settlement Location in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Party Id Settlement Location
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Party Id Settlement Location
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + PartyIdSettlementLocation.Length)
        {
            throw new System.Exception("Invalid Length for Party Id Settlement Location");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Party Id Settlement Location
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + PartyIdSettlementLocation.Length;
    }

    /// <summary>
    ///  Check available length and set Party Id Settlement Location to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PartyIdSettlementLocation.Length)
        {
            throw new System.Exception("Invalid Length for Party Id Settlement Location");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Party Id Settlement Location to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + PartyIdSettlementLocation.Length;
    }

    /// <summary>
    ///  Set Party Id Settlement Location to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Party Id Settlement Location
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + PartyIdSettlementLocation.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Party Id Settlement Location
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Party Id Settlement Location
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PartyIdSettlementLocation.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Party Id Settlement Location
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
