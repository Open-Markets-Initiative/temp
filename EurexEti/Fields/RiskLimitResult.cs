using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Risk Limit Result: Enum
/// </summary>

public static class RiskLimitResult
{
    /// <summary>
    ///  Margin Based Risk Limits not enabled for business unit
    /// </summary>
    public const ushort DisabledForBu = 10580;

    /// <summary>
    ///  Received Remaining Risk Allowance event ID is lower than lowest entry in Temporary Transaction List
    /// </summary>
    public const ushort LowRraEventId = 10581;

    /// <summary>
    ///  Received Remaining Risk Allowance event ID exceeds last entry in Temporary Transaction List
    /// </summary>
    public const ushort HighRraEventId = 10582;

    /// <summary>
    ///  Fix Tag for Risk Limit Result
    /// </summary>
    public const ushort FixTag = 1764;

    /// <summary>
    ///  Length of Risk Limit Result in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Risk Limit Result
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Risk Limit Result
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + RiskLimitResult.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Result");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Risk Limit Result
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        *(ushort*) (pointer + offset) = value;

        current = offset + RiskLimitResult.Length;
    }

    /// <summary>
    ///  Check available length and set Risk Limit Result to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RiskLimitResult.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Result");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Risk Limit Result to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RiskLimitResult.Length;
    }

    /// <summary>
    ///  Set Risk Limit Result to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Risk Limit Result
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + RiskLimitResult.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Risk Limit Result
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Risk Limit Result
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RiskLimitResult.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Risk Limit Result
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
