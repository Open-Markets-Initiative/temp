using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Tot Num Trade Reports: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class TotNumTradeReports
{
    /// <summary>
    ///  Fix Tag for Tot Num Trade Reports
    /// </summary>
    public const ushort FixTag = 748;

    /// <summary>
    ///  Length of Tot Num Trade Reports in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Tot Num Trade Reports
    /// </summary>
    public const int NoValue = unchecked((int)0x80000000);

    /// <summary>
    ///  Encode Tot Num Trade Reports
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
    {
        if (length > offset + TotNumTradeReports.Length)
        {
            throw new System.Exception("Invalid Length for Tot Num Trade Reports");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Tot Num Trade Reports
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + TotNumTradeReports.Length;
    }

    /// <summary>
    ///  Encode Tot Num Trade Reports
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, int value)
    {
        *(int*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Tot Num Trade Reports to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TotNumTradeReports.Length)
        {
            throw new System.Exception("Invalid Length for Tot Num Trade Reports");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Tot Num Trade Reports to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TotNumTradeReports.Length;
    }

    /// <summary>
    ///  Set Tot Num Trade Reports to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(int*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Tot Num Trade Reports
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
    {
        if (length > offset + TotNumTradeReports.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Tot Num Trade Reports
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Tot Num Trade Reports
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TotNumTradeReports.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Tot Num Trade Reports
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static int Decode(byte* pointer, int offset)
    {
        return *(int*) (pointer + offset);
    }
}
