using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Appl Msg Id: Fixed Length Data Field
/// </summary>

public static class ApplMsgId
{
    /// <summary>
    ///  Fix Tag for Appl Msg Id
    /// </summary>
    public const ushort FixTag = 28704;

    /// <summary>
    ///  Length of Appl Msg Id in bytes
    /// </summary>
    public const int Length = 16;

    /// <summary>
    ///  Encode Appl Msg Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte[] value, int length, out int current)
    {
        if (length > offset + ApplMsgId.Length)
        {
            throw new System.Exception("Invalid Length for Appl Msg Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Msg Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte[] value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, ApplMsgId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = value[i];
        }

        end = ApplMsgId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = 0;
        }

        current = offset + ApplMsgId.Length;
    }

    /// <summary>
    ///  TryDecode Appl Msg Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
    {
        if (length > offset + ApplMsgId.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = null;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Appl Msg Id
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplMsgId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Msg Id
    /// </summary>
    public unsafe static byte[] Decode(byte* pointer, int offset)
    {
        var buffer = new byte[ApplMsgId.Length];

        byte* position = pointer + offset;

        for (var i = 0; i < ApplMsgId.Length; i++)
        {
            buffer[i] = *(position++);
        }

        return buffer;
    }
}
