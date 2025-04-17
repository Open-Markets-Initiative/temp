using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Matching Engine Status: Enum
/// </summary>

public static class MatchingEngineStatus
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
    ///  Fix Tag for Matching Engine Status
    /// </summary>
    public const ushort FixTag = 25005;

    /// <summary>
    ///  Length of Matching Engine Status in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Matching Engine Status
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Matching Engine Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + MatchingEngineStatus.Length)
        {
            throw new System.Exception("Invalid Length for Matching Engine Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Matching Engine Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + MatchingEngineStatus.Length;
    }

    /// <summary>
    ///  Check available length and set Matching Engine Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MatchingEngineStatus.Length)
        {
            throw new System.Exception("Invalid Length for Matching Engine Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Matching Engine Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MatchingEngineStatus.Length;
    }

    /// <summary>
    ///  Set Matching Engine Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Matching Engine Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + MatchingEngineStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Matching Engine Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Matching Engine Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MatchingEngineStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Matching Engine Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
