using System;
using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Fix Orig Cl Ord Id: Optional Fixed Length Space Filled String Field
/// </summary>

public static class FixOrigClOrdId
{
    /// <summary>
    ///  Fix Tag for Fix Orig Cl Ord Id
    /// </summary>
    public const ushort FixTag = 30041;

    /// <summary>
    ///  Length of Fix Orig Cl Ord Id in bytes
    /// </summary>
    public const int Length = 20;

    /// <summary>
    ///  Encode Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + FixOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Fix Orig Cl Ord Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, FixOrigClOrdId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = FixOrigClOrdId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + FixOrigClOrdId.Length;
    }

    /// <summary>
    ///  Check available length and set Fix Orig Cl Ord Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FixOrigClOrdId.Length)
        {
            throw new System.Exception("Invalid Length for Fix Orig Cl Ord Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fix Orig Cl Ord Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FixOrigClOrdId.Length;
    }

    /// <summary>
    ///  Set Fix Orig Cl Ord Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < FixOrigClOrdId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + FixOrigClOrdId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + FixOrigClOrdId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FixOrigClOrdId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fix Orig Cl Ord Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, FixOrigClOrdId.Length).Trim();
    }
}
