using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  T 7 Entry Service Status: Enum
/// </summary>

public static class T7EntryServiceStatus
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
    ///  Fix Tag for T 7 Entry Service Status
    /// </summary>
    public const ushort FixTag = 25048;

    /// <summary>
    ///  Length of T 7 Entry Service Status in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for T 7 Entry Service Status
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode T 7 Entry Service Status
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + T7EntryServiceStatus.Length)
        {
            throw new System.Exception("Invalid Length for T 7 Entry Service Status");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode T 7 Entry Service Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + T7EntryServiceStatus.Length;
    }

    /// <summary>
    ///  Check available length and set T 7 Entry Service Status to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + T7EntryServiceStatus.Length)
        {
            throw new System.Exception("Invalid Length for T 7 Entry Service Status");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set T 7 Entry Service Status to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + T7EntryServiceStatus.Length;
    }

    /// <summary>
    ///  Set T 7 Entry Service Status to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode T 7 Entry Service Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + T7EntryServiceStatus.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode T 7 Entry Service Status
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode T 7 Entry Service Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + T7EntryServiceStatus.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode T 7 Entry Service Status
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
