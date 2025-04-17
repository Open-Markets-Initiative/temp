using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Default Cstm Appl Ver Id: Optional Fixed Length String Field
/// </summary>

public static class DefaultCstmApplVerId
{
    /// <summary>
    ///  Fix Tag for Default Cstm Appl Ver Id
    /// </summary>
    public const ushort FixTag = 1408;

    /// <summary>
    ///  Length of Default Cstm Appl Ver Id in bytes
    /// </summary>
    public const int Length = 30;

    /// <summary>
    ///  Encode Default Cstm Appl Ver Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + DefaultCstmApplVerId.Length)
        {
            throw new System.Exception("Invalid Length for Default Cstm Appl Ver Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Default Cstm Appl Ver Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, DefaultCstmApplVerId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = DefaultCstmApplVerId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = 0;
        }

        current = offset + DefaultCstmApplVerId.Length;
    }

    /// <summary>
    ///  Check available length and set Default Cstm Appl Ver Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + DefaultCstmApplVerId.Length)
        {
            throw new System.Exception("Invalid Length for Default Cstm Appl Ver Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Default Cstm Appl Ver Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + DefaultCstmApplVerId.Length;
    }

    /// <summary>
    ///  Set Default Cstm Appl Ver Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < DefaultCstmApplVerId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Default Cstm Appl Ver Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + DefaultCstmApplVerId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Default Cstm Appl Ver Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + DefaultCstmApplVerId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Default Cstm Appl Ver Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + DefaultCstmApplVerId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Default Cstm Appl Ver Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, DefaultCstmApplVerId.Length).Trim('\0');
    }
}
