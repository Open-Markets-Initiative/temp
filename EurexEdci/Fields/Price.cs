using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
/// </summary>

public static class Price
{
    /// <summary>
    ///  Fix Tag for Price
    /// </summary>
    public const ushort FixTag = 44;

    /// <summary>
    ///  Length of Price in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Price
    /// </summary>
    public const ulong Factor = 100000000;

    /// <summary>
    ///  Null value for Price
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Price
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + Price.Length)
        {
            throw new System.Exception("Invalid Length for Price");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)(value * Factor);

        current = offset + Price.Length;
    }

    /// <summary>
    ///  Check available length and set Price to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + Price.Length)
        {
            throw new System.Exception("Invalid Length for Price");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Price to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + Price.Length;
    }

    /// <summary>
    ///  Set Price to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + Price.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Price
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + Price.Length;

        return result;
    }

    /// <summary>
    ///  Decode Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + Price.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Price
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
