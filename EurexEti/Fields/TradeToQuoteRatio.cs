using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Trade To Quote Ratio: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
/// </summary>

public static class TradeToQuoteRatio
{
    /// <summary>
    ///  Fix Tag for Trade To Quote Ratio
    /// </summary>
    public const ushort FixTag = 25201;

    /// <summary>
    ///  Length of Trade To Quote Ratio in bytes
    /// </summary>
    public const int Length = 8;

    /// <summary>
    ///  Decimal place factor for Trade To Quote Ratio
    /// </summary>
    public const ulong Factor = 10000;

    /// <summary>
    ///  Null value for Trade To Quote Ratio
    /// </summary>
    public const ulong NoValue = 0x8000000000000000;

    /// <summary>
    ///  Encode Trade To Quote Ratio
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
    {
        if (length > offset + TradeToQuoteRatio.Length)
        {
            throw new System.Exception("Invalid Length for Trade To Quote Ratio");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Trade To Quote Ratio
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
    {
        *(ulong*) (pointer + offset) = (ulong)double.Round(value * Factor);

        current = offset + TradeToQuoteRatio.Length;
    }

    /// <summary>
    ///  Check available length and set Trade To Quote Ratio to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + TradeToQuoteRatio.Length)
        {
            throw new System.Exception("Invalid Length for Trade To Quote Ratio");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Trade To Quote Ratio to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + TradeToQuoteRatio.Length;
    }

    /// <summary>
    ///  Set Trade To Quote Ratio to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ulong*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Trade To Quote Ratio
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
    {
        if (length > offset + TradeToQuoteRatio.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Trade To Quote Ratio
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
    {
        var raw = *(ulong*)(pointer + offset);

        var result = raw != NoValue;

        value = raw / (double)Factor;

        current = offset + TradeToQuoteRatio.Length;

        return result;
    }

    /// <summary>
    ///  Decode Trade To Quote Ratio
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset, out int current)
    {
        current = offset + TradeToQuoteRatio.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Trade To Quote Ratio
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static double Decode(byte* pointer, int offset)
    {
        return *(ulong*) (pointer + offset) / (double)Factor;
    }
}
