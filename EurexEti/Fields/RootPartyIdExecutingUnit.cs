using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Root Party Id Executing Unit: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class RootPartyIdExecutingUnit
{
    /// <summary>
    ///  Fix Tag for Root Party Id Executing Unit
    /// </summary>
    public const ushort FixTag = 20459;

    /// <summary>
    ///  Length of Root Party Id Executing Unit in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Root Party Id Executing Unit
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Root Party Id Executing Unit
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + RootPartyIdExecutingUnit.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Executing Unit");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Id Executing Unit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RootPartyIdExecutingUnit.Length;
    }

    /// <summary>
    ///  Encode Root Party Id Executing Unit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Root Party Id Executing Unit to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartyIdExecutingUnit.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Executing Unit");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Id Executing Unit to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartyIdExecutingUnit.Length;
    }

    /// <summary>
    ///  Set Root Party Id Executing Unit to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Root Party Id Executing Unit
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + RootPartyIdExecutingUnit.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Id Executing Unit
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Root Party Id Executing Unit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartyIdExecutingUnit.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Id Executing Unit
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
