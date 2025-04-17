using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Mass Order Report Id: Optional 4 Byte Fixed Width Integer
/// </summary>

public static class MassOrderReportId
{
    /// <summary>
    ///  Fix Tag for Mass Order Report Id
    /// </summary>
    public const ushort FixTag = 2424;

    /// <summary>
    ///  Length of Mass Order Report Id in bytes
    /// </summary>
    public const int Length = 4;

    /// <summary>
    ///  Null value for Mass Order Report Id
    /// </summary>
    public const uint NoValue = 0xFFFFFFFF;

    /// <summary>
    ///  Encode Mass Order Report Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
    {
        if (length > offset + MassOrderReportId.Length)
        {
            throw new System.Exception("Invalid Length for Mass Order Report Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Mass Order Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
    {
        Encode(pointer, offset, value);

        current = offset + MassOrderReportId.Length;
    }

    /// <summary>
    ///  Encode Mass Order Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, uint value)
    {
        *(uint*) (pointer + offset) = value;
    }

    /// <summary>
    ///  Check available length and set Mass Order Report Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + MassOrderReportId.Length)
        {
            throw new System.Exception("Invalid Length for Mass Order Report Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Mass Order Report Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + MassOrderReportId.Length;
    }

    /// <summary>
    ///  Set Mass Order Report Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(uint*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Mass Order Report Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
    {
        if (length > offset + MassOrderReportId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Mass Order Report Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Mass Order Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset, out int current)
    {
        current = offset + MassOrderReportId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Mass Order Report Id
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static uint Decode(byte* pointer, int offset)
    {
        return *(uint*) (pointer + offset);
    }
}
