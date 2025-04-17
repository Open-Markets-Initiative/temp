using System;
using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Free Text 1: Optional Fixed Length Space Filled String Field
/// </summary>

public static class FreeText1
{
    /// <summary>
    ///  Fix Tag for Free Text 1
    /// </summary>
    public const ushort FixTag = 25007;

    /// <summary>
    ///  Length of Free Text 1 in bytes
    /// </summary>
    public const int Length = 12;

    /// <summary>
    ///  Encode Free Text 1
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + FreeText1.Length)
        {
            throw new System.Exception("Invalid Length for Free Text 1");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Free Text 1
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, FreeText1.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = FreeText1.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + FreeText1.Length;
    }

    /// <summary>
    ///  Check available length and set Free Text 1 to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FreeText1.Length)
        {
            throw new System.Exception("Invalid Length for Free Text 1");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Free Text 1 to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FreeText1.Length;
    }

    /// <summary>
    ///  Set Free Text 1 to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < FreeText1.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Free Text 1
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + FreeText1.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Free Text 1
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + FreeText1.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Free Text 1
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FreeText1.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Free Text 1
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, FreeText1.Length).Trim();
    }
}
