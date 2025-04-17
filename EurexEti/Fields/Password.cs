using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Password: Optional Fixed Length String Field
/// </summary>

public static class Password
{
    /// <summary>
    ///  Fix Tag for Password
    /// </summary>
    public const ushort FixTag = 554;

    /// <summary>
    ///  Length of Password in bytes
    /// </summary>
    public const int Length = 32;

    /// <summary>
    ///  Encode Password
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + Password.Length)
        {
            throw new System.Exception("Invalid Length for Password");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Password
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, Password.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = Password.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = 0;
        }

        current = offset + Password.Length;
    }

    /// <summary>
    ///  Check available length and set Password to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + Password.Length)
        {
            throw new System.Exception("Invalid Length for Password");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Password to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + Password.Length;
    }

    /// <summary>
    ///  Set Password to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < Password.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Password
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + Password.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Password
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + Password.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Password
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Password.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Password
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, Password.Length).Trim('\0');
    }
}
