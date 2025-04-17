using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Root Party Contra Firm: Optional Fixed Length Space Filled String Field
/// </summary>

public static class RootPartyContraFirm
{
    /// <summary>
    ///  Fix Tag for Root Party Contra Firm
    /// </summary>
    public const ushort FixTag = 22417;

    /// <summary>
    ///  Length of Root Party Contra Firm in bytes
    /// </summary>
    public const int Length = 5;

    /// <summary>
    ///  Encode Root Party Contra Firm
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + RootPartyContraFirm.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Contra Firm");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Contra Firm
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, RootPartyContraFirm.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = RootPartyContraFirm.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + RootPartyContraFirm.Length;
    }

    /// <summary>
    ///  Check available length and set Root Party Contra Firm to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartyContraFirm.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Contra Firm");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Contra Firm to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartyContraFirm.Length;
    }

    /// <summary>
    ///  Set Root Party Contra Firm to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < RootPartyContraFirm.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Root Party Contra Firm
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + RootPartyContraFirm.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Contra Firm
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + RootPartyContraFirm.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Root Party Contra Firm
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartyContraFirm.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Contra Firm
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, RootPartyContraFirm.Length).Trim();
    }
}
