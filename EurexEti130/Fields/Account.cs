using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Account: Optional Fixed Length Space Filled String Field
/// </summary>

public static class Account
{
    /// <summary>
    ///  Fix Tag for Account
    /// </summary>
    public const ushort FixTag = 1;

    /// <summary>
    ///  Length of Account in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode Account
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + Account.Length)
        {
            throw new System.Exception("Invalid Length for Account");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Account
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, Account.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = Account.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + Account.Length;
    }

    /// <summary>
    ///  Check available length and set Account to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + Account.Length)
        {
            throw new System.Exception("Invalid Length for Account");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Account to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + Account.Length;
    }

    /// <summary>
    ///  Set Account to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < Account.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Account
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + Account.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Account
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + Account.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Account
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Account.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Account
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, Account.Length).Trim();
    }
}
