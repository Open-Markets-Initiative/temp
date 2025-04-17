using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Root Party Id Position Account: Optional Fixed Length Space Filled String Field
/// </summary>

public static class RootPartyIdPositionAccount
{
    /// <summary>
    ///  Fix Tag for Root Party Id Position Account
    /// </summary>
    public const ushort FixTag = 20438;

    /// <summary>
    ///  Length of Root Party Id Position Account in bytes
    /// </summary>
    public const int Length = 32;

    /// <summary>
    ///  Encode Root Party Id Position Account
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + RootPartyIdPositionAccount.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Position Account");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Id Position Account
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, RootPartyIdPositionAccount.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = RootPartyIdPositionAccount.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + RootPartyIdPositionAccount.Length;
    }

    /// <summary>
    ///  Check available length and set Root Party Id Position Account to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartyIdPositionAccount.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Position Account");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Id Position Account to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartyIdPositionAccount.Length;
    }

    /// <summary>
    ///  Set Root Party Id Position Account to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < RootPartyIdPositionAccount.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Root Party Id Position Account
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + RootPartyIdPositionAccount.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Id Position Account
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + RootPartyIdPositionAccount.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Root Party Id Position Account
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartyIdPositionAccount.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Id Position Account
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, RootPartyIdPositionAccount.Length).Trim();
    }
}
