using System;
using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Party End Client Identification: Optional Fixed Length Space Filled String Field
/// </summary>

public static class PartyEndClientIdentification
{
    /// <summary>
    ///  Fix Tag for Party End Client Identification
    /// </summary>
    public const ushort FixTag = 25241;

    /// <summary>
    ///  Length of Party End Client Identification in bytes
    /// </summary>
    public const int Length = 20;

    /// <summary>
    ///  Encode Party End Client Identification
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + PartyEndClientIdentification.Length)
        {
            throw new System.Exception("Invalid Length for Party End Client Identification");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Party End Client Identification
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, PartyEndClientIdentification.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = PartyEndClientIdentification.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + PartyEndClientIdentification.Length;
    }

    /// <summary>
    ///  Check available length and set Party End Client Identification to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PartyEndClientIdentification.Length)
        {
            throw new System.Exception("Invalid Length for Party End Client Identification");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Party End Client Identification to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + PartyEndClientIdentification.Length;
    }

    /// <summary>
    ///  Set Party End Client Identification to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < PartyEndClientIdentification.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Party End Client Identification
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + PartyEndClientIdentification.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Party End Client Identification
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + PartyEndClientIdentification.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Party End Client Identification
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PartyEndClientIdentification.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Party End Client Identification
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, PartyEndClientIdentification.Length).Trim();
    }
}
