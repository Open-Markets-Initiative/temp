using System.Runtime.CompilerServices;

namespace Eurex.Edci.v131;

/// <summary>
///  Fill Exec Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class FillExecId
{
    /// <summary>
    ///  Fix Tag for Fill Exec Id
    /// </summary>
    public const ushort FixTag = 1363;

    /// <summary>
    ///  Length of Fill Exec Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Fill Exec Id
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Fill Exec Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + FillExecId.Length)
        {
            throw new System.Exception("Invalid Length for Fill Exec Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fill Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + FillExecId.Length;
    }

    /// <summary>
    ///  Encode Fill Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Fill Exec Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FillExecId.Length)
        {
            throw new System.Exception("Invalid Length for Fill Exec Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fill Exec Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FillExecId.Length;
    }

    /// <summary>
    ///  Set Fill Exec Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Fill Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + FillExecId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fill Exec Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Fill Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FillExecId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fill Exec Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
