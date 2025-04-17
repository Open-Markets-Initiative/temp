using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Enrichment Rule Id: Optional 2 Byte Fixed Width Integer
/// </summary>

public static class EnrichmentRuleId
{
    /// <summary>
    ///  Fix Tag for Enrichment Rule Id
    /// </summary>
    public const ushort FixTag = 25033;

    /// <summary>
    ///  Length of Enrichment Rule Id in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Enrichment Rule Id
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Enrichment Rule Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + EnrichmentRuleId.Length)
        {
            throw new System.Exception("Invalid Length for Enrichment Rule Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Enrichment Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + EnrichmentRuleId.Length;
    }

    /// <summary>
    ///  Encode Enrichment Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Enrichment Rule Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + EnrichmentRuleId.Length)
        {
            throw new System.Exception("Invalid Length for Enrichment Rule Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Enrichment Rule Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + EnrichmentRuleId.Length;
    }

    /// <summary>
    ///  Set Enrichment Rule Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Enrichment Rule Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + EnrichmentRuleId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Enrichment Rule Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Enrichment Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + EnrichmentRuleId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Enrichment Rule Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
