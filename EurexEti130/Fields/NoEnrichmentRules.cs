using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  No Enrichment Rules: Runtime Count Field
/// </summary>

public static class NoEnrichmentRules
{
    /// <summary>
    ///  Fix Tag for No Enrichment Rules
    /// </summary>
    public const ushort FixTag = 28738;

    /// <summary>
    ///  Length of No Enrichment Rules in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode No Enrichment Rules
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + NoEnrichmentRules.Length)
        {
            throw new System.Exception("Invalid Length for No Enrichment Rules");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode No Enrichment Rules
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + NoEnrichmentRules.Length;
    }

    /// <summary>
    ///  Encode No Enrichment Rules
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set No Enrichment Rules to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + NoEnrichmentRules.Length)
        {
            throw new System.Exception("Invalid Length for No Enrichment Rules");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set No Enrichment Rules to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + NoEnrichmentRules.Length;
    }

    /// <summary>
    ///  Set No Enrichment Rules to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode No Enrichment Rules
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + NoEnrichmentRules.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode No Enrichment Rules
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode No Enrichment Rules
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + NoEnrichmentRules.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode No Enrichment Rules
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
