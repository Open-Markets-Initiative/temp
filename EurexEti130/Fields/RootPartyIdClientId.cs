using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Root Party Id Client Id: Optional 8 Byte Fixed Width Integer
/// </summary>

public static class RootPartyIdClientId
{
    /// <summary>
    ///  Fix Tag for Root Party Id Client Id
    /// </summary>
    public const ushort FixTag = 20403;

    /// <summary>
    ///  Length of Root Party Id Client Id in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Null value for Root Party Id Client Id
    /// </summary>
    public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

    /// <summary>
    ///  Encode Root Party Id Client Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
    {
        if (length > offset + RootPartyIdClientId.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Client Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Id Client Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + RootPartyIdClientId.Length;
    }

    /// <summary>
    ///  Encode Root Party Id Client Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ulong value)
    {
        *(ulong*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Root Party Id Client Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartyIdClientId.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Id Client Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Id Client Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartyIdClientId.Length;
    }

    /// <summary>
    ///  Set Root Party Id Client Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Root Party Id Client Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
    {
        if (length > offset + RootPartyIdClientId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Id Client Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Root Party Id Client Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartyIdClientId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Id Client Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ulong Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset);
    }
}
