using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Appl Usage Orders: Enum
/// </summary>

public static class ApplUsageOrders
{
    /// <summary>
    ///  Automated
    /// </summary>
    public const char Automated = 'A';

    /// <summary>
    ///  Manual
    /// </summary>
    public const char Manual = 'M';

    /// <summary>
    ///  Both (Automated and Manual)
    /// </summary>
    public const char AutoSelect = 'B';

    /// <summary>
    ///  None
    /// </summary>
    public const char None = 'N';

    /// <summary>
    ///  Fix Tag for Appl Usage Orders
    /// </summary>
    public const ushort FixTag = 25012;

    /// <summary>
    ///  Length of Appl Usage Orders in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode Appl Usage Orders
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
    {
        if (length > offset + ApplUsageOrders.Length)
        {
            throw new System.Exception("Invalid Length for Appl Usage Orders");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Appl Usage Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

        Encode(pointer, offset, character, out current);
    }

    /// <summary>
    ///  Encode Appl Usage Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
    {
        *(char*) (pointer + offset) = value;

        current = offset + ApplUsageOrders.Length;
    }

    /// <summary>
    ///  TryDecode Appl Usage Orders
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
    {
        if (length > offset + ApplUsageOrders.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode Appl Usage Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ApplUsageOrders.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Appl Usage Orders
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset)
    {
        return *(char*) (pointer + offset);
    }
}
