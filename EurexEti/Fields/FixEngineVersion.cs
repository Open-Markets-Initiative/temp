using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Fix Engine Version: Optional Fixed Length String Field
/// </summary>

public static class FixEngineVersion
{
    /// <summary>
    ///  Fix Tag for Fix Engine Version
    /// </summary>
    public const ushort FixTag = 1601;

    /// <summary>
    ///  Length of Fix Engine Version in bytes
    /// </summary>
    public const int Length = 30;

    /// <summary>
    ///  Encode Fix Engine Version
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + FixEngineVersion.Length)
        {
            throw new System.Exception("Invalid Length for Fix Engine Version");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Fix Engine Version
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, FixEngineVersion.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = FixEngineVersion.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = 0;
        }

        current = offset + FixEngineVersion.Length;
    }

    /// <summary>
    ///  Check available length and set Fix Engine Version to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FixEngineVersion.Length)
        {
            throw new System.Exception("Invalid Length for Fix Engine Version");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Fix Engine Version to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FixEngineVersion.Length;
    }

    /// <summary>
    ///  Set Fix Engine Version to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < FixEngineVersion.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Fix Engine Version
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + FixEngineVersion.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Fix Engine Version
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + FixEngineVersion.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Fix Engine Version
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FixEngineVersion.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Fix Engine Version
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, FixEngineVersion.Length).Trim('\0');
    }
}
