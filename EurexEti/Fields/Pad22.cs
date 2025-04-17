using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Pad 22: Fixed Length Padding
/// </summary>

public static class Pad22
{
    /// <summary>
    ///  Fix Tag for Pad 22
    /// </summary>
    public const ushort FixTag = 39022;

    /// <summary>
    ///  Length of Pad 22 in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode Pad 22
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < Pad22.Length; i++)
        {
            *(position++) = 0;
        }

        current = offset + Pad22.Length;
    }

    /// <summary>
    ///  TryDecode Pad 22
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + Pad22.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Pad 22
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Pad22.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Pad 22
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[Pad22.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < Pad22.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
