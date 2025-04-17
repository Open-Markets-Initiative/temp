using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Target Party Entering Trader: Optional Fixed Length Space Filled String Field
/// </summary>

public static class TargetPartyEnteringTrader
{
    /// <summary>
    ///  Fix Tag for Target Party Entering Trader
    /// </summary>
    public const ushort FixTag = 22636;

    /// <summary>
    ///  Length of Target Party Entering Trader in bytes
    /// </summary>
    public const int Length = 6;

    /// <summary>
    ///  Encode Target Party Entering Trader
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + TargetPartyEnteringTrader.Length)
        {
            throw new System.Exception("Invalid Length for Target Party Entering Trader");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Target Party Entering Trader
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, TargetPartyEnteringTrader.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = TargetPartyEnteringTrader.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + TargetPartyEnteringTrader.Length;
    }

    /// <summary>
    ///  Check available length and set Target Party Entering Trader to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TargetPartyEnteringTrader.Length)
        {
            throw new System.Exception("Invalid Length for Target Party Entering Trader");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Target Party Entering Trader to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TargetPartyEnteringTrader.Length;
    }

    /// <summary>
    ///  Set Target Party Entering Trader to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < TargetPartyEnteringTrader.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Target Party Entering Trader
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + TargetPartyEnteringTrader.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Target Party Entering Trader
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + TargetPartyEnteringTrader.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Target Party Entering Trader
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TargetPartyEnteringTrader.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Target Party Entering Trader
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, TargetPartyEnteringTrader.Length).Trim();
    }
}
