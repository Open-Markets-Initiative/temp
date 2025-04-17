using System;
using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Firm Trade Id: Optional Fixed Length Space Filled String Field
/// </summary>

public static class FirmTradeId
{
    /// <summary>
    ///  Fix Tag for Firm Trade Id
    /// </summary>
    public const ushort FixTag = 1041;

    /// <summary>
    ///  Length of Firm Trade Id in bytes
    /// </summary>
    public const int Length = 20;

    /// <summary>
    ///  Encode Firm Trade Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
    {
        if (length > offset + FirmTradeId.Length)
        {
            throw new System.Exception("Invalid Length for Firm Trade Id");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Firm Trade Id
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var position = pointer + offset;

        var end = Math.Min(value.Length, FirmTradeId.Length);

        for (var i = 0; i < end; i++)
        {
            *(position++) = (byte)value[i];
        }

        end = FirmTradeId.Length - end;

        for(var i = 0; i < end; i++)
        {
            *(position++) = (byte)' ';
        }

        current = offset + FirmTradeId.Length;
    }

    /// <summary>
    ///  Check available length and set Firm Trade Id to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + FirmTradeId.Length)
        {
            throw new System.Exception("Invalid Length for Firm Trade Id");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Firm Trade Id to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + FirmTradeId.Length;
    }

    /// <summary>
    ///  Set Firm Trade Id to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        var position = pointer + offset;

        for (var i = 0; i < FirmTradeId.Length; i++)
        {
            *(position++) = 0;
        }
    }

    /// <summary>
    ///  TryDecode Firm Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
    {
        if (length > offset + FirmTradeId.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = string.Empty;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Firm Trade Id
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
    {
        current = offset + FirmTradeId.Length;

        value = string.Empty;

        if (*(pointer + offset) == 0)
        {
            return false;
        }

        value = Decode(pointer, offset);

        return !string.IsNullOrEmpty(value);
    }

    /// <summary>
    ///  Decode Firm Trade Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset, out int current)
    {
        current = offset + FirmTradeId.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Firm Trade Id
    /// </summary>
    public unsafe static string Decode(byte* pointer, int offset)
    {
        return new string ((sbyte*)pointer, offset, FirmTradeId.Length).Trim();
    }
}
