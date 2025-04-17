using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Trd Match Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class TrdMatchId
{
    /// <summary>
    ///  Fix Tag for Trd Match Id
    /// </summary>
    public const ushort FixTag = 880;

    /// <summary>
    ///  Length of Trd Match Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Trd Match Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Trd Match Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + TrdMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Trd Match Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + TrdMatchId.Length;
    }

    /// <summary>
    ///  Encode Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Trd Match Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TrdMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Trd Match Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trd Match Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TrdMatchId.Length;
    }

    /// <summary>
    ///  Set Trd Match Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trd Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + TrdMatchId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trd Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TrdMatchId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trd Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
