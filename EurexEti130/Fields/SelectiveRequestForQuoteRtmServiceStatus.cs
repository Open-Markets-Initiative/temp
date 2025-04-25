using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Selective Request For Quote Rtm Service Status: Enum
/// </summary>

public static class SelectiveRequestForQuoteRtmServiceStatus
{
    /// <summary>
    ///  Unavailable
    /// </summary>
    public const byte Unavailable = 0;

    /// <summary>
    ///  Available
    /// </summary>
    public const byte Available = 1;

    /// <summary>
    ///  Fix Tag for Selective Request For Quote Rtm Service Status
    /// </summary>
    public const ushort FixTag = 25053;

    /// <summary>
    ///  Length of Selective Request For Quote Rtm Service Status in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Selective Request For Quote Rtm Service Status
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Selective Request For Quote Rtm Service Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + SelectiveRequestForQuoteRtmServiceStatus.Length)
        {
            throw new System.Exception("Invalid Length for Selective Request For Quote Rtm Service Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Selective Request For Quote Rtm Service Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + SelectiveRequestForQuoteRtmServiceStatus.Length;
    }

    /// <summary>
    ///  Check available length and set Selective Request For Quote Rtm Service Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SelectiveRequestForQuoteRtmServiceStatus.Length)
        {
            throw new System.Exception("Invalid Length for Selective Request For Quote Rtm Service Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Selective Request For Quote Rtm Service Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SelectiveRequestForQuoteRtmServiceStatus.Length;
    }

    /// <summary>
    ///  Set Selective Request For Quote Rtm Service Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Selective Request For Quote Rtm Service Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + SelectiveRequestForQuoteRtmServiceStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Selective Request For Quote Rtm Service Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Selective Request For Quote Rtm Service Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SelectiveRequestForQuoteRtmServiceStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Selective Request For Quote Rtm Service Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
