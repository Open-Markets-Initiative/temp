using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Executing Trader Qualifier: Enum
/// </summary>

public static class ExecutingTraderQualifier
{
    /// <summary>
    ///  Algo
    /// </summary>
    public const byte Algo = 22;

    /// <summary>
    ///  Human/Natural person
    /// </summary>
    public const byte Human = 24;

    /// <summary>
    ///  Fix Tag for Executing Trader Qualifier
    /// </summary>
    public const ushort FixTag = 25124;

    /// <summary>
    ///  Length of Executing Trader Qualifier in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Executing Trader Qualifier
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Executing Trader Qualifier
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + ExecutingTraderQualifier.Length)
        {
            throw new System.Exception("Invalid Length for Executing Trader Qualifier");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Executing Trader Qualifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + ExecutingTraderQualifier.Length;
    }

    /// <summary>
    ///  Check available length and set Executing Trader Qualifier to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExecutingTraderQualifier.Length)
        {
            throw new System.Exception("Invalid Length for Executing Trader Qualifier");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Executing Trader Qualifier to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExecutingTraderQualifier.Length;
    }

    /// <summary>
    ///  Set Executing Trader Qualifier to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Executing Trader Qualifier
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + ExecutingTraderQualifier.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Executing Trader Qualifier
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Executing Trader Qualifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExecutingTraderQualifier.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Executing Trader Qualifier
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
