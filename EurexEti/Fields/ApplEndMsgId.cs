using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Appl End Msg Id: Fixed Length Data Field
/// </summary>

public static class ApplEndMsgId
{
    /// <summary>
    ///  Fix Tag for Appl End Msg Id
    /// </summary>
    public const ushort FixTag = 28719;

    /// <summary>
    ///  Length of Appl End Msg Id in bytes
    /// </summary>
    public const int Length = 16;

    /// <summary>
    ///  Encode Appl End Msg Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte[] value, int length, out int current)
    {
        if (length > offset + ApplEndMsgId.Length)
        {
            throw new System.Exception("Invalid Length for Appl End Msg Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl End Msg Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte[] value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, ApplEndMsgId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = value[i];
        }

        end = ApplEndMsgId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = 0;
        }

        current = offset + ApplEndMsgId.Length;
    }

    /// <summary>
    ///  TryDecode Appl End Msg Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + ApplEndMsgId.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Appl End Msg Id
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplEndMsgId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl End Msg Id
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[ApplEndMsgId.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < ApplEndMsgId.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
