using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Fill Match Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class FillMatchId
{
    /// <summary>
    ///  Fix Tag for Fill Match Id
    /// </summary>
    public const ushort FixTag = 28708;

    /// <summary>
    ///  Length of Fill Match Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Fill Match Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Fill Match Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + FillMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Fill Match Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fill Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + FillMatchId.Length;
    }

    /// <summary>
    ///  Encode Fill Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Fill Match Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FillMatchId.Length)
        {
            throw new System.Exception("Invalid Length for Fill Match Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fill Match Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FillMatchId.Length;
    }

    /// <summary>
    ///  Set Fill Match Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Fill Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + FillMatchId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fill Match Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Fill Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FillMatchId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fill Match Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
