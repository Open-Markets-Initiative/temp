using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Pad 7: Fixed Length Padding
/// </summary>

public static class Pad7
{
    /// <summary>
    ///  Fix Tag for Pad 7
    /// </summary>
    public const ushort FixTag = 39070;

    /// <summary>
    ///  Length of Pad 7 in bytes
    /// </summary>
    public const int Length = 7;

    /// <summary>
    ///  Encode Pad 7
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < Pad7.Length; i++)
        {
            *(position++) = 0;
        }

        current = offset + Pad7.Length;
    }

    /// <summary>
    ///  TryDecode Pad 7
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + Pad7.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Pad 7
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Pad7.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Pad 7
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[Pad7.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < Pad7.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
