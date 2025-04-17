using System;
using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Affected Fix Orig Cl Ord Id: Optional Fixed Length Space Filled String Field
/// </summary>

public static class AffectedFixOrigClOrdId
{
    /// <summary>
    ///  Fix Tag for Affected Fix Orig Cl Ord Id
    /// </summary>
    public const ushort FixTag = 31824;

    /// <summary>
    ///  Length of Affected Fix Orig Cl Ord Id in bytes
    /// </summary>
    public const int Length = 20;

    /// <summary>
    ///  Encode Affected Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + AffectedFixOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Fix Orig Cl Ord Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Affected Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, AffectedFixOrigClOrdId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = AffectedFixOrigClOrdId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + AffectedFixOrigClOrdId.Length;
    }

    /// <summary>
    ///  Check available length and set Affected Fix Orig Cl Ord Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + AffectedFixOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Fix Orig Cl Ord Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Affected Fix Orig Cl Ord Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + AffectedFixOrigClOrdId.Length;
    }

    /// <summary>
    ///  Set Affected Fix Orig Cl Ord Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < AffectedFixOrigClOrdId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Affected Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + AffectedFixOrigClOrdId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Affected Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + AffectedFixOrigClOrdId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Affected Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + AffectedFixOrigClOrdId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Affected Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, AffectedFixOrigClOrdId.Length).Trim();
    }
}
