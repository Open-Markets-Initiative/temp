using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Fix Engine Vendor: Optional Fixed Length String Field
/// </summary>

public static class FixEngineVendor
{
    /// <summary>
    ///  Fix Tag for Fix Engine Vendor
    /// </summary>
    public const ushort FixTag = 1602;

    /// <summary>
    ///  Length of Fix Engine Vendor in bytes
    /// </summary>
    public const int Length = 30;

    /// <summary>
    ///  Encode Fix Engine Vendor
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + FixEngineVendor.Length)
        {
            throw new System.Exception("Invalid Length for Fix Engine Vendor");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fix Engine Vendor
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, FixEngineVendor.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = FixEngineVendor.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = 0;
        }

        current = offset + FixEngineVendor.Length;
    }

    /// <summary>
    ///  Check available length and set Fix Engine Vendor to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FixEngineVendor.Length)
        {
            throw new System.Exception("Invalid Length for Fix Engine Vendor");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fix Engine Vendor to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FixEngineVendor.Length;
    }

    /// <summary>
    ///  Set Fix Engine Vendor to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < FixEngineVendor.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Fix Engine Vendor
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + FixEngineVendor.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fix Engine Vendor
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + FixEngineVendor.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Fix Engine Vendor
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FixEngineVendor.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fix Engine Vendor
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, FixEngineVendor.Length).Trim('\0');
    }
}
