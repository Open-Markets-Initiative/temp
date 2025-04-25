using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  Root Party Sub Id Type: Enum
/// </summary>

public static class RootPartySubIdType
{
    /// <summary>
    ///  Buyer
    /// </summary>
    public const ushort Buyer = 4001;

    /// <summary>
    ///  Seller
    /// </summary>
    public const ushort Seller = 4002;

    /// <summary>
    ///  Broker
    /// </summary>
    public const ushort Broker = 4003;

    /// <summary>
    ///  Fix Tag for Root Party Sub Id Type
    /// </summary>
    public const ushort FixTag = 1122;

    /// <summary>
    ///  Length of Root Party Sub Id Type in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Root Party Sub Id Type
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Root Party Sub Id Type
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + RootPartySubIdType.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Sub Id Type");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Root Party Sub Id Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        *(ushort*) (pointer + offset) = value;

        current = offset + RootPartySubIdType.Length;
    }

    /// <summary>
    ///  Check available length and set Root Party Sub Id Type to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + RootPartySubIdType.Length)
        {
            throw new System.Exception("Invalid Length for Root Party Sub Id Type");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Root Party Sub Id Type to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + RootPartySubIdType.Length;
    }

    /// <summary>
    ///  Set Root Party Sub Id Type to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Root Party Sub Id Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + RootPartySubIdType.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Root Party Sub Id Type
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Root Party Sub Id Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + RootPartySubIdType.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Root Party Sub Id Type
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
