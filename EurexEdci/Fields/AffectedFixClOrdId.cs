using System;
using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Affected Fix Cl Ord Id: Optional Fixed Length Space Filled String Field
/// </summary>

public static class AffectedFixClOrdId
{
    /// <summary>
    ///  Fix Tag for Affected Fix Cl Ord Id
    /// </summary>
    public const ushort FixTag = 30536;

    /// <summary>
    ///  Length of Affected Fix Cl Ord Id in bytes
    /// </summary>
    public const int Length = 20;

    /// <summary>
    ///  Encode Affected Fix Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + AffectedFixClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Fix Cl Ord Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Affected Fix Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, AffectedFixClOrdId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = AffectedFixClOrdId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + AffectedFixClOrdId.Length;
    }

    /// <summary>
    ///  Check available length and set Affected Fix Cl Ord Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + AffectedFixClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Affected Fix Cl Ord Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Affected Fix Cl Ord Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + AffectedFixClOrdId.Length;
    }

    /// <summary>
    ///  Set Affected Fix Cl Ord Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < AffectedFixClOrdId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Affected Fix Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + AffectedFixClOrdId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Affected Fix Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + AffectedFixClOrdId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Affected Fix Cl Ord Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + AffectedFixClOrdId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Affected Fix Cl Ord Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, AffectedFixClOrdId.Length).Trim();
    }
}
