using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Auto Approval Rule Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class AutoApprovalRuleId
{
    /// <summary>
    ///  Fix Tag for Auto Approval Rule Id
    /// </summary>
    public const ushort FixTag = 25181;

    /// <summary>
    ///  Length of Auto Approval Rule Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Auto Approval Rule Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Auto Approval Rule Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + AutoApprovalRuleId.Length)
        {
            throw new System.Exception("Invalid Length for Auto Approval Rule Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Auto Approval Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + AutoApprovalRuleId.Length;
    }

    /// <summary>
    ///  Encode Auto Approval Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Auto Approval Rule Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + AutoApprovalRuleId.Length)
        {
            throw new System.Exception("Invalid Length for Auto Approval Rule Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Auto Approval Rule Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + AutoApprovalRuleId.Length;
    }

    /// <summary>
    ///  Set Auto Approval Rule Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Auto Approval Rule Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + AutoApprovalRuleId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Auto Approval Rule Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Auto Approval Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + AutoApprovalRuleId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Auto Approval Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
