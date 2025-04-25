using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Risk Limit Report Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class RiskLimitReportId
{
    /// <summary>
    ///  Fix Tag for Risk Limit Report Id
    /// </summary>
    public const ushort FixTag = 1667;

    /// <summary>
    ///  Length of Risk Limit Report Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Risk Limit Report Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Risk Limit Report Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + RiskLimitReportId.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Report Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Risk Limit Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RiskLimitReportId.Length;
    }

    /// <summary>
    ///  Encode Risk Limit Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Risk Limit Report Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RiskLimitReportId.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Report Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Risk Limit Report Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RiskLimitReportId.Length;
    }

    /// <summary>
    ///  Set Risk Limit Report Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Risk Limit Report Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + RiskLimitReportId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Risk Limit Report Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Risk Limit Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RiskLimitReportId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Risk Limit Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
