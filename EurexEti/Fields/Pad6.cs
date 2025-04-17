using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Pad 6: Fixed Length Padding
/// </summary>

public static class Pad6
{
    /// <summary>
    ///  Fix Tag for Pad 6
    /// </summary>
    public const ushort FixTag = 39060;

    /// <summary>
    ///  Length of Pad 6 in bytes
    /// </summary>
    public const int Length = 6;

    /// <summary>
    ///  Encode Pad 6
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < Pad6.Length; i++)
        {
            *(position++) = 0;
        }

        current = offset + Pad6.Length;
    }

    /// <summary>
    ///  TryDecode Pad 6
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + Pad6.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Pad 6
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Pad6.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Pad 6
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[Pad6.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < Pad6.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
