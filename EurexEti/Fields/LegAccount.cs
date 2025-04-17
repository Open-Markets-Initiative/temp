using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Leg Account: Optional Fixed Length Space Filled String Field
/// </summary>

public static class LegAccount
{
    /// <summary>
    ///  Fix Tag for Leg Account
    /// </summary>
    public const ushort FixTag = 2680;

    /// <summary>
    ///  Length of Leg Account in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode Leg Account
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + LegAccount.Length)
        {
            throw new System.Exception("Invalid Length for Leg Account");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Leg Account
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, LegAccount.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = LegAccount.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + LegAccount.Length;
    }

    /// <summary>
    ///  Check available length and set Leg Account to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LegAccount.Length)
        {
            throw new System.Exception("Invalid Length for Leg Account");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Leg Account to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LegAccount.Length;
    }

    /// <summary>
    ///  Set Leg Account to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < LegAccount.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Leg Account
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + LegAccount.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Leg Account
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + LegAccount.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Leg Account
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LegAccount.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Leg Account
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, LegAccount.Length).Trim();
    }
}
