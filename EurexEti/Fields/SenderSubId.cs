using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Sender Sub Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class SenderSubId
{
    /// <summary>
    ///  Fix Tag for Sender Sub Id
    /// </summary>
    public const ushort FixTag = 50;

    /// <summary>
    ///  Length of Sender Sub Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Sender Sub Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Sender Sub Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + SenderSubId.Length)
        {
            throw new System.Exception("Invalid Length for Sender Sub Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Sender Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + SenderSubId.Length;
    }

    /// <summary>
    ///  Encode Sender Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Sender Sub Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + SenderSubId.Length)
        {
            throw new System.Exception("Invalid Length for Sender Sub Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Sender Sub Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + SenderSubId.Length;
    }

    /// <summary>
    ///  Set Sender Sub Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Sender Sub Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + SenderSubId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Sender Sub Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Sender Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + SenderSubId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Sender Sub Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
