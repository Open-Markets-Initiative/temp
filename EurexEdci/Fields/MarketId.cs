using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Market Id: Enum
/// </summary>

public static class MarketId
{
    /// <summary>
    ///  XEUR
    /// </summary>
    public const ushort Xeur = 1;

    /// <summary>
    ///  XEEE
    /// </summary>
    public const ushort Xeee = 2;

    /// <summary>
    ///  Fix Tag for Market Id
    /// </summary>
    public const ushort FixTag = 1301;

    /// <summary>
    ///  Length of Market Id in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Market Id
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Market Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + MarketId.Length)
        {
            throw new System.Exception("Invalid Length for Market Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        *(ushort*) (pointer + offset) = value;

        current = offset + MarketId.Length;
    }

    /// <summary>
    ///  Check available length and set Market Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MarketId.Length)
        {
            throw new System.Exception("Invalid Length for Market Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Market Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MarketId.Length;
    }

    /// <summary>
    ///  Set Market Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Market Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + MarketId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Market Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MarketId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Market Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
