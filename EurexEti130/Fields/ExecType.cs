using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Exec Type: Enum
/// </summary>

public static class ExecType
{
    /// <summary>
    ///  New
    /// </summary>
    public const char New = '0';

    /// <summary>
    ///  Cancelled
    /// </summary>
    public const char Canceled = '4';

    /// <summary>
    ///  Replaced
    /// </summary>
    public const char Replaced = '5';

    /// <summary>
    ///  Pending Cancel (e.g. result of Order Cancel Request)
    /// </summary>
    public const char PendingCancele = '6';

    /// <summary>
    ///  Suspended
    /// </summary>
    public const char Suspended = '9';

    /// <summary>
    ///  Restated
    /// </summary>
    public const char Restated = 'D';

    /// <summary>
    ///  Triggered
    /// </summary>
    public const char Triggered = 'L';

    /// <summary>
    ///  Trade
    /// </summary>
    public const char Trade = 'F';

    /// <summary>
    ///  Fix Tag for Exec Type
    /// </summary>
    public const ushort FixTag = 150;

    /// <summary>
    ///  Length of Exec Type in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode Exec Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
    {
        if (length > offset + ExecType.Length)
        {
            throw new System.Exception("Invalid Length for Exec Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Exec Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

        Encode(pointer, offset, character, out current);
    }

    /// <summary>
    ///  Encode Exec Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
    {
        *(char*) (pointer + offset) = value;

        current = offset + ExecType.Length;
    }

    /// <summary>
    ///  TryDecode Exec Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
    {
        if (length > offset + ExecType.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Exec Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExecType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Exec Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset)
    {
        return *(char*) (pointer + offset);
    }
}
