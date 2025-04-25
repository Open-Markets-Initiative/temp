using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Free Text 5: Optional Fixed Length Space Filled String Field
/// </summary>

public static class FreeText5
{
    /// <summary>
    ///  Fix Tag for Free Text 5
    /// </summary>
    public const ushort FixTag = 25172;

    /// <summary>
    ///  Length of Free Text 5 in bytes
    /// </summary>
    public const int Length = 132;

    /// <summary>
    ///  Encode Free Text 5
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + FreeText5.Length)
        {
            throw new System.Exception("Invalid Length for Free Text 5");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Free Text 5
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, FreeText5.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = FreeText5.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + FreeText5.Length;
    }

    /// <summary>
    ///  Check available length and set Free Text 5 to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FreeText5.Length)
        {
            throw new System.Exception("Invalid Length for Free Text 5");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Free Text 5 to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FreeText5.Length;
    }

    /// <summary>
    ///  Set Free Text 5 to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < FreeText5.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Free Text 5
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + FreeText5.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Free Text 5
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + FreeText5.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Free Text 5
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FreeText5.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Free Text 5
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, FreeText5.Length).Trim();
    }
}
