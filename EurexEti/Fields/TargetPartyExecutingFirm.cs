using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Target Party Executing Firm: Optional Fixed Length Space Filled String Field
/// </summary>

public static class TargetPartyExecutingFirm
{
    /// <summary>
    ///  Fix Tag for Target Party Executing Firm
    /// </summary>
    public const ushort FixTag = 22601;

    /// <summary>
    ///  Length of Target Party Executing Firm in bytes
    /// </summary>
    public const int Length = 5;

    /// <summary>
    ///  Encode Target Party Executing Firm
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + TargetPartyExecutingFirm.Length)
        {
            throw new System.Exception("Invalid Length for Target Party Executing Firm");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Target Party Executing Firm
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, TargetPartyExecutingFirm.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = TargetPartyExecutingFirm.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + TargetPartyExecutingFirm.Length;
    }

    /// <summary>
    ///  Check available length and set Target Party Executing Firm to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TargetPartyExecutingFirm.Length)
        {
            throw new System.Exception("Invalid Length for Target Party Executing Firm");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Target Party Executing Firm to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TargetPartyExecutingFirm.Length;
    }

    /// <summary>
    ///  Set Target Party Executing Firm to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < TargetPartyExecutingFirm.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Target Party Executing Firm
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + TargetPartyExecutingFirm.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Target Party Executing Firm
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + TargetPartyExecutingFirm.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Target Party Executing Firm
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TargetPartyExecutingFirm.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Target Party Executing Firm
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, TargetPartyExecutingFirm.Length).Trim();
    }
}
