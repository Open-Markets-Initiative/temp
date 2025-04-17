using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Side Compliance Text: Optional Fixed Length Space Filled String Field
/// </summary>

public static class SideComplianceText
{
    /// <summary>
    ///  Fix Tag for Side Compliance Text
    /// </summary>
    public const ushort FixTag = 28774;

    /// <summary>
    ///  Length of Side Compliance Text in bytes
    /// </summary>
    public const int Length = 20;

    /// <summary>
    ///  Encode Side Compliance Text
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + SideComplianceText.Length)
        {
            throw new System.Exception("Invalid Length for Side Compliance Text");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Side Compliance Text
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, SideComplianceText.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = SideComplianceText.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + SideComplianceText.Length;
    }

    /// <summary>
    ///  Check available length and set Side Compliance Text to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SideComplianceText.Length)
        {
            throw new System.Exception("Invalid Length for Side Compliance Text");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Side Compliance Text to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SideComplianceText.Length;
    }

    /// <summary>
    ///  Set Side Compliance Text to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < SideComplianceText.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Side Compliance Text
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + SideComplianceText.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Side Compliance Text
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + SideComplianceText.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Side Compliance Text
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SideComplianceText.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Side Compliance Text
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, SideComplianceText.Length).Trim();
    }
}
