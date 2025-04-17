using System;
using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Pad 4: Fixed Length Padding
/// </summary>

public static class Pad4
{
    /// <summary>
    ///  Fix Tag for Pad 4
    /// </summary>
    public const ushort FixTag = 39040;

    /// <summary>
    ///  Length of Pad 4 in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Encode Pad 4
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < Pad4.Length; i++)
        {
            *(position++) = 0;
        }

        current = offset + Pad4.Length;
    }

    /// <summary>
    ///  TryDecode Pad 4
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + Pad4.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Pad 4
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Pad4.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Pad 4
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[Pad4.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < Pad4.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
