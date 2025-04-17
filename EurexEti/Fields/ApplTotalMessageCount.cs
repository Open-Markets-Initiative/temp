using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Appl Total Message Count: Optional 2 Byte Fixed Width Integer
/// </summary>

public static class ApplTotalMessageCount
{
    /// <summary>
    ///  Fix Tag for Appl Total Message Count
    /// </summary>
    public const ushort FixTag = 1349;

    /// <summary>
    ///  Length of Appl Total Message Count in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Appl Total Message Count
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Appl Total Message Count
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + ApplTotalMessageCount.Length)
        {
            throw new System.Exception("Invalid Length for Appl Total Message Count");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Total Message Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + ApplTotalMessageCount.Length;
    }

    /// <summary>
    ///  Encode Appl Total Message Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value)
    {
        *(ushort*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Appl Total Message Count to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ApplTotalMessageCount.Length)
        {
            throw new System.Exception("Invalid Length for Appl Total Message Count");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Appl Total Message Count to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ApplTotalMessageCount.Length;
    }

    /// <summary>
    ///  Set Appl Total Message Count to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Appl Total Message Count
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + ApplTotalMessageCount.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Appl Total Message Count
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Appl Total Message Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplTotalMessageCount.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Total Message Count
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
