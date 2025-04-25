using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Root Party Clearing Firm: Optional Fixed Length Space Filled String Field
/// </summary>

public static class RootPartyClearingFirm
{
    /// <summary>
    ///  Fix Tag for Root Party Clearing Firm
    /// </summary>
    public const ushort FixTag = 22404;

    /// <summary>
    ///  Length of Root Party Clearing Firm in bytes
    /// </summary>
    public const int Length = 5;

    /// <summary>
    ///  Encode Root Party Clearing Firm
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + RootPartyClearingFirm.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Clearing Firm");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Clearing Firm
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, RootPartyClearingFirm.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = RootPartyClearingFirm.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + RootPartyClearingFirm.Length;
    }

    /// <summary>
    ///  Check available length and set Root Party Clearing Firm to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartyClearingFirm.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Clearing Firm");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Clearing Firm to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartyClearingFirm.Length;
    }

    /// <summary>
    ///  Set Root Party Clearing Firm to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < RootPartyClearingFirm.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Root Party Clearing Firm
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + RootPartyClearingFirm.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Clearing Firm
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + RootPartyClearingFirm.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Root Party Clearing Firm
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartyClearingFirm.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Clearing Firm
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, RootPartyClearingFirm.Length).Trim();
    }
}
