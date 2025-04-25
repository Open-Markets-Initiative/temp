using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Trad Ses Mode: Enum
/// </summary>

public static class TradSesMode
{
    /// <summary>
    ///  Development
    /// </summary>
    public const byte Testing = 1;

    /// <summary>
    ///  Simulation
    /// </summary>
    public const byte Simulated = 2;

    /// <summary>
    ///  Production
    /// </summary>
    public const byte Production = 3;

    /// <summary>
    ///  Acceptance
    /// </summary>
    public const byte Acceptance = 4;

    /// <summary>
    ///  Disaster Recovery
    /// </summary>
    public const byte DisasterRecovery = 5;

    /// <summary>
    ///  Fix Tag for Trad Ses Mode
    /// </summary>
    public const ushort FixTag = 339;

    /// <summary>
    ///  Length of Trad Ses Mode in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Null value for Trad Ses Mode
    /// </summary>
    public const byte NoValue = 0xFF;

    /// <summary>
    ///  Encode Trad Ses Mode
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
    {
        if (length > offset + TradSesMode.Length)
        {
            throw new System.Exception("Invalid Length for Trad Ses Mode");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trad Ses Mode
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
    {
        *(byte*) (pointer + offset) = value;

        current = offset + TradSesMode.Length;
    }

    /// <summary>
    ///  Check available length and set Trad Ses Mode to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradSesMode.Length)
        {
            throw new System.Exception("Invalid Length for Trad Ses Mode");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trad Ses Mode to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradSesMode.Length;
    }

    /// <summary>
    ///  Set Trad Ses Mode to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(byte*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trad Ses Mode
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
    {
        if (length > offset + TradSesMode.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trad Ses Mode
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Trad Ses Mode
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradSesMode.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trad Ses Mode
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static byte Decode(byte* pointer, int offset)
    {
        return *(byte*) (pointer + offset);
    }
}
