using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Underlying Currency: Optional Fixed Length Space Filled String Field
/// </summary>

public static class UnderlyingCurrency
{
    /// <summary>
    ///  Fix Tag for Underlying Currency
    /// </summary>
    public const ushort FixTag = 318;

    /// <summary>
    ///  Length of Underlying Currency in bytes
    /// </summary>
    public const int Length = 3;

    /// <summary>
    ///  Encode Underlying Currency
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + UnderlyingCurrency.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Currency");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Underlying Currency
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, UnderlyingCurrency.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = UnderlyingCurrency.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + UnderlyingCurrency.Length;
    }

    /// <summary>
    ///  Check available length and set Underlying Currency to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + UnderlyingCurrency.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Currency");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Underlying Currency to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + UnderlyingCurrency.Length;
    }

    /// <summary>
    ///  Set Underlying Currency to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < UnderlyingCurrency.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Underlying Currency
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + UnderlyingCurrency.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Underlying Currency
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + UnderlyingCurrency.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Underlying Currency
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + UnderlyingCurrency.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Underlying Currency
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, UnderlyingCurrency.Length).Trim();
    }
}
