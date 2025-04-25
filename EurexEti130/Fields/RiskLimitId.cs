using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Risk Limit Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class RiskLimitId
{
    /// <summary>
    ///  Fix Tag for Risk Limit Id
    /// </summary>
    public const ushort FixTag = 1670;

    /// <summary>
    ///  Length of Risk Limit Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Risk Limit Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Risk Limit Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + RiskLimitId.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Risk Limit Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RiskLimitId.Length;
    }

    /// <summary>
    ///  Encode Risk Limit Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Risk Limit Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RiskLimitId.Length)
        {
            throw new System.Exception("Invalid Length for Risk Limit Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Risk Limit Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RiskLimitId.Length;
    }

    /// <summary>
    ///  Set Risk Limit Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Risk Limit Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + RiskLimitId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Risk Limit Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Risk Limit Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RiskLimitId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Risk Limit Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
