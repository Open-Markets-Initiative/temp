using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Charge Id: Optional Fixed Length Space Filled String Field
/// </summary>

public static class ChargeId
{
    /// <summary>
    ///  Fix Tag for Charge Id
    /// </summary>
    public const ushort FixTag = 25225;

    /// <summary>
    ///  Length of Charge Id in bytes
    /// </summary>
    public const int Length = 132;

    /// <summary>
    ///  Encode Charge Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + ChargeId.Length)
        {
            throw new System.Exception("Invalid Length for Charge Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Charge Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, ChargeId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = ChargeId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + ChargeId.Length;
    }

    /// <summary>
    ///  Check available length and set Charge Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ChargeId.Length)
        {
            throw new System.Exception("Invalid Length for Charge Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Charge Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ChargeId.Length;
    }

    /// <summary>
    ///  Set Charge Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < ChargeId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Charge Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + ChargeId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Charge Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + ChargeId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Charge Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ChargeId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Charge Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, ChargeId.Length).Trim();
    }
}
