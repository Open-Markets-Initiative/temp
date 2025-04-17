using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Input Source: Enum
/// </summary>

public static class InputSource
{
    /// <summary>
    ///  Client Broker
    /// </summary>
    public const byte ClientBroker = 1;

    /// <summary>
    ///  Proprietary Broker
    /// </summary>
    public const byte ProprietaryBroker = 2;

    /// <summary>
    ///  Fix Tag for Input Source
    /// </summary>
    public const ushort FixTag = 979;

    /// <summary>
    ///  Length of Input Source in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Input Source
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Input Source
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + InputSource.Length)
        {
            throw new System.Exception("Invalid Length for Input Source");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Input Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + InputSource.Length;
    }

    /// <summary>
    ///  Check available length and set Input Source to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + InputSource.Length)
        {
            throw new System.Exception("Invalid Length for Input Source");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Input Source to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + InputSource.Length;
    }

    /// <summary>
    ///  Set Input Source to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Input Source
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + InputSource.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Input Source
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Input Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + InputSource.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Input Source
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
