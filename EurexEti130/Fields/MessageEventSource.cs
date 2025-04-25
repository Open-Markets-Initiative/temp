using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Message Event Source: Enum
/// </summary>

public static class MessageEventSource
{
    /// <summary>
    ///  Broadcast to initiator
    /// </summary>
    public const char BroadcasttoInitiator = 'I';

    /// <summary>
    ///  Broadcast to approver
    /// </summary>
    public const char BroadcasttoApprover = 'A';

    /// <summary>
    ///  Broadcast to requestor
    /// </summary>
    public const char BroadcasttoRequester = 'R';

    /// <summary>
    ///  Broadcast to quote submitter
    /// </summary>
    public const char BroadcasttoQuoteSubmitter = 'Q';

    /// <summary>
    ///  Fix Tag for Message Event Source
    /// </summary>
    public const ushort FixTag = 1011;

    /// <summary>
    ///  Length of Message Event Source in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode Message Event Source
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
    {
        if (length > offset + MessageEventSource.Length)
        {
            throw new System.Exception("Invalid Length for Message Event Source");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Message Event Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

        Encode(pointer, offset, character, out current);
    }

    /// <summary>
    ///  Encode Message Event Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
    {
        *(char*) (pointer + offset) = value;

        current = offset + MessageEventSource.Length;
    }

    /// <summary>
    ///  TryDecode Message Event Source
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
    {
        if (length > offset + MessageEventSource.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Message Event Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MessageEventSource.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Message Event Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset)
    {
        return *(char*) (pointer + offset);
    }
}
