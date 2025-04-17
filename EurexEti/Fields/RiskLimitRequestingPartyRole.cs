using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Risk Limit Requesting Party Role: Enum
/// </summary>

public static class RiskLimitRequestingPartyRole
{
    /// <summary>
    ///  requested by Clearing firm
    /// </summary>
    public const byte Clearingfirm = 4;

    /// <summary>
    ///  requested by Exchange
    /// </summary>
    public const byte Exchange = 22;

    /// <summary>
    ///  requested by Executing firm
    /// </summary>
    public const byte Executingunit = 59;

    /// <summary>
    ///  Fix Tag for Risk Limit Requesting Party Role
    /// </summary>
    public const ushort FixTag = 28776;

    /// <summary>
    ///  Length of Risk Limit Requesting Party Role in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Risk Limit Requesting Party Role
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Risk Limit Requesting Party Role
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + RiskLimitRequestingPartyRole.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Requesting Party Role");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Risk Limit Requesting Party Role
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + RiskLimitRequestingPartyRole.Length;
    }

    /// <summary>
    ///  Check available length and set Risk Limit Requesting Party Role to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RiskLimitRequestingPartyRole.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Requesting Party Role");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Risk Limit Requesting Party Role to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RiskLimitRequestingPartyRole.Length;
    }

    /// <summary>
    ///  Set Risk Limit Requesting Party Role to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Risk Limit Requesting Party Role
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + RiskLimitRequestingPartyRole.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Risk Limit Requesting Party Role
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Risk Limit Requesting Party Role
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RiskLimitRequestingPartyRole.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Risk Limit Requesting Party Role
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
