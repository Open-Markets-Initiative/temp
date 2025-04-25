using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Appl Id Status: Enum
/// </summary>

public static class ApplIdStatus
{
    /// <summary>
    ///  Error converting response or broadcast
    /// </summary>
    public const uint Outboundconversionerror = 105;

    /// <summary>
    ///  Fix Tag for Appl Id Status
    /// </summary>
    public const ushort FixTag = 28724;

    /// <summary>
    ///  Length of Appl Id Status in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Appl Id Status
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Appl Id Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + ApplIdStatus.Length)
        {
            throw new System.Exception("Invalid Length for Appl Id Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Id Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        *(uint*) (pointer + offset) = value;

        current = offset + ApplIdStatus.Length;
    }

    /// <summary>
    ///  Check available length and set Appl Id Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ApplIdStatus.Length)
        {
            throw new System.Exception("Invalid Length for Appl Id Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Appl Id Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ApplIdStatus.Length;
    }

    /// <summary>
    ///  Set Appl Id Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Appl Id Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + ApplIdStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Appl Id Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Appl Id Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplIdStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Id Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
