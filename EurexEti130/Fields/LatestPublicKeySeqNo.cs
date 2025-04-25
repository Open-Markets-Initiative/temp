using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Latest Public Key Seq No: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class LatestPublicKeySeqNo
{
    /// <summary>
    ///  Fix Tag for Latest Public Key Seq No
    /// </summary>
    public const ushort FixTag = 25243;

    /// <summary>
    ///  Length of Latest Public Key Seq No in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Latest Public Key Seq No
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Latest Public Key Seq No
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + LatestPublicKeySeqNo.Length)
        {
            throw new System.Exception("Invalid Length for Latest Public Key Seq No");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Latest Public Key Seq No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + LatestPublicKeySeqNo.Length;
    }

    /// <summary>
    ///  Encode Latest Public Key Seq No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Latest Public Key Seq No to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + LatestPublicKeySeqNo.Length)
        {
            throw new System.Exception("Invalid Length for Latest Public Key Seq No");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Latest Public Key Seq No to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + LatestPublicKeySeqNo.Length;
    }

    /// <summary>
    ///  Set Latest Public Key Seq No to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Latest Public Key Seq No
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + LatestPublicKeySeqNo.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Latest Public Key Seq No
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Latest Public Key Seq No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + LatestPublicKeySeqNo.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Latest Public Key Seq No
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
