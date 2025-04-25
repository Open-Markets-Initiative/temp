using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Pad 2: Fixed Length Padding
/// </summary>

public static class Pad2
{
    /// <summary>
    ///  Fix Tag for Pad 2
    /// </summary>
    public const ushort FixTag = 39020;

    /// <summary>
    ///  Length of Pad 2 in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode Pad 2
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < Pad2.Length; i++)
        {
            *(position++) = 0;
        }

        current = offset + Pad2.Length;
    }

    /// <summary>
    ///  TryDecode Pad 2
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + Pad2.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Pad 2
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Pad2.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Pad 2
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[Pad2.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < Pad2.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
