using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Underlying Security Id: Optional Fixed Length Space Filled String Field
/// </summary>

public static class UnderlyingSecurityId
{
    /// <summary>
    ///  Fix Tag for Underlying Security Id
    /// </summary>
    public const ushort FixTag = 309;

    /// <summary>
    ///  Length of Underlying Security Id in bytes
    /// </summary>
    public const int Length = 12;

    /// <summary>
    ///  Encode Underlying Security Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + UnderlyingSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Security Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Underlying Security Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, UnderlyingSecurityId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = UnderlyingSecurityId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + UnderlyingSecurityId.Length;
    }

    /// <summary>
    ///  Check available length and set Underlying Security Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + UnderlyingSecurityId.Length)
        {
            throw new System.Exception("Invalid Length for Underlying Security Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Underlying Security Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + UnderlyingSecurityId.Length;
    }

    /// <summary>
    ///  Set Underlying Security Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < UnderlyingSecurityId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Underlying Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + UnderlyingSecurityId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Underlying Security Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + UnderlyingSecurityId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Underlying Security Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + UnderlyingSecurityId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Underlying Security Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, UnderlyingSecurityId.Length).Trim();
    }
}
