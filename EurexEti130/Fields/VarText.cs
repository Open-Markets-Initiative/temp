using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Var Text: Runtime Variable Length Ascii String
/// </summary>

public static class VarText
{
    /// <summary>
    ///  Fix Tag for Var Text
    /// </summary>
    public const ushort FixTag = 30355;

    /// <summary>
    ///  Encode Var Text
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int length, string value, out int current)
    {
        if (length > offset + value.Length)
        {
            throw new System.Exception("Invalid Length for Var Text");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Var Text
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < value.Length; i++)
        {
            *(position++) = (byte)value[i];
        }

        current = offset + value.Length;
    }

    /// <summary>
    ///  TryDecode Var Text
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, int size, out string value, out int current)
    {
        if (length > offset + size)
        {
            return TryDecode(pointer, offset, size, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Var Text
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int size, out string value, out int current)
    {
        if (size > 0)
        {
            value = Decode(pointer, offset, size, out current);

            return !string.IsNullOrEmpty(value);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Var Text
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, int size, out int current)
    {
        current = offset + size;

        return Decode(pointer, offset, size);
    }

    /// <summary>
    ///  Decode Var Text
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, int size)
    {
        return new string ((sbyte*)pointer, offset, size);
    }
}
