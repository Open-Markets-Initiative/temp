using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Public Key Len: Runtime Count Field
/// </summary>

public static class PublicKeyLen
{
    /// <summary>
    ///  Fix Tag for Public Key Len
    /// </summary>
    public const ushort FixTag = 25242;

    /// <summary>
    ///  Length of Public Key Len in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Encode Public Key Len
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + PublicKeyLen.Length)
        {
            throw new System.Exception("Invalid Length for Public Key Len");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Public Key Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + PublicKeyLen.Length;
    }

    /// <summary>
    ///  Encode Public Key Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Public Key Len to 0
    /// </summary>
    public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + PublicKeyLen.Length)
        {
            throw new System.Exception("Invalid Length for Public Key Len");
        }

        Zero(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Public Key Len to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset, out int current)
    {
        Zero(pointer, offset);

        current = offset + PublicKeyLen.Length;
    }

    /// <summary>
    ///  Set Public Key Len to 0
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Zero(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = 0;
    }

    /// <summary>
    ///  TryDecode Public Key Len
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + PublicKeyLen.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Public Key Len
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value > 0;
    }

    /// <summary>
    ///  Decode Public Key Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + PublicKeyLen.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Public Key Len
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
