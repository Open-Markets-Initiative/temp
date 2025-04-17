using System.Runtime.CompilerServices;

namespace Eurex.Eti.v131;

/// <summary>
///  Exec Restatement Reason: Enum
/// </summary>

public static class ExecRestatementReason
{
    /// <summary>
    ///  Order book restatement
    /// </summary>
    public const ushort OrderBookRestatement = 1;

    /// <summary>
    ///  Order add accepted
    /// </summary>
    public const ushort OrderAdded = 101;

    /// <summary>
    ///  Order modify accepted
    /// </summary>
    public const ushort OrderModified = 102;

    /// <summary>
    ///  Order delete accepted
    /// </summary>
    public const ushort OrderCancelled = 103;

    /// <summary>
    ///  IOC Order accepted
    /// </summary>
    public const ushort IocOrderCancelled = 105;

    /// <summary>
    ///  FOK Order accepted
    /// </summary>
    public const ushort FokOrderCancelled = 107;

    /// <summary>
    ///  Book Order executed
    /// </summary>
    public const ushort BookOrderExecuted = 108;

    /// <summary>
    ///  Order has been changed to IOC
    /// </summary>
    public const ushort ChangedtoIoc = 114;

    /// <summary>
    ///  Member has been disabled
    /// </summary>
    public const ushort Memberdisable = 117;

    /// <summary>
    ///  Instrument State Change
    /// </summary>
    public const ushort InstrumentStateChange = 122;

    /// <summary>
    ///  Market Order triggered and executed
    /// </summary>
    public const ushort MarketOrderTriggered = 135;

    /// <summary>
    ///  Closing Auction Order has been activated
    /// </summary>
    public const ushort CaoOrderActivated = 149;

    /// <summary>
    ///  Closing Auction Order has been inactivated
    /// </summary>
    public const ushort CaoOrderInactivated = 150;

    /// <summary>
    ///  Opening Auction Order has been activated
    /// </summary>
    public const ushort OaoOrderActivated = 151;

    /// <summary>
    ///  Opening Auction Order has been inactivated
    /// </summary>
    public const ushort OaoOrderInactivated = 152;

    /// <summary>
    ///  Any Auction Order has been activated
    /// </summary>
    public const ushort AaoOrderActivated = 153;

    /// <summary>
    ///  Any Auction Order has been inactivated
    /// </summary>
    public const ushort AaoOrderInactivated = 154;

    /// <summary>
    ///  One-cancels-the-other Order has been triggered
    /// </summary>
    public const ushort OcoOrderTriggered = 164;

    /// <summary>
    ///  Stop Order has been triggered
    /// </summary>
    public const ushort StopOrderTriggered = 172;

    /// <summary>
    ///  Ownership Changed
    /// </summary>
    public const ushort OwnershipChanged = 181;

    /// <summary>
    ///  Pending order deletion
    /// </summary>
    public const ushort OrderCancellationPending = 197;

    /// <summary>
    ///  Pending order cancellation processed (end of FREEZE state)
    /// </summary>
    public const ushort PendingCancellationExecuted = 199;

    /// <summary>
    ///  Book or Cancel Order accepted
    /// </summary>
    public const ushort BocOrderCancelled = 212;

    /// <summary>
    ///  Panic Cancel
    /// </summary>
    public const ushort PanicCancel = 261;

    /// <summary>
    ///  Market Order uncrossing
    /// </summary>
    public const ushort MarketOrderUncrossing = 302;

    /// <summary>
    ///  CLIP execution after improvement period
    /// </summary>
    public const ushort ClipExecution = 340;

    /// <summary>
    ///  CLIP Request deleted by arrangement time out
    /// </summary>
    public const ushort ClipArrangementtimeout = 343;

    /// <summary>
    ///  CLIP Request deleted by arrangement validation
    /// </summary>
    public const ushort ClipArrangementValidation = 344;

    /// <summary>
    ///  Cross order added
    /// </summary>
    public const ushort CrossOrderAdded = 346;

    /// <summary>
    ///  Cross order cancelled
    /// </summary>
    public const ushort CrossOrderCancelled = 347;

    /// <summary>
    ///  Fix Tag for Exec Restatement Reason
    /// </summary>
    public const ushort FixTag = 378;

    /// <summary>
    ///  Length of Exec Restatement Reason in bytes
    /// </summary>
    public const int Length = 2;

    /// <summary>
    ///  Null value for Exec Restatement Reason
    /// </summary>
    public const ushort NoValue = 0xFFFF;

    /// <summary>
    ///  Encode Exec Restatement Reason
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
    {
        if (length > offset + ExecRestatementReason.Length)
        {
            throw new System.Exception("Invalid Length for Exec Restatement Reason");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode Exec Restatement Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
    {
        *(ushort*) (pointer + offset) = value;

        current = offset + ExecRestatementReason.Length;
    }

    /// <summary>
    ///  Check available length and set Exec Restatement Reason to no value
    /// </summary>
    public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
    {
        if (length > offset + ExecRestatementReason.Length)
        {
            throw new System.Exception("Invalid Length for Exec Restatement Reason");
        }

        SetNull(pointer, offset, out current);
    }

    /// <summary>
    ///  Set Exec Restatement Reason to no value and update index
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset, out int current)
    {
        SetNull(pointer, offset);

        current = offset + ExecRestatementReason.Length;
    }

    /// <summary>
    ///  Set Exec Restatement Reason to no value
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void SetNull(byte* pointer, int offset)
    {
        *(ushort*) (pointer + offset) = NoValue;
    }

    /// <summary>
    ///  TryDecode Exec Restatement Reason
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
    {
        if (length > offset + ExecRestatementReason.Length)
        {
            return TryDecode(pointer, offset, out value, out current);
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  TryDecode Exec Restatement Reason
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
    {
        value = Decode(pointer, offset, out current);

        return value != NoValue;
    }

    /// <summary>
    ///  Decode Exec Restatement Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ExecRestatementReason.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode Exec Restatement Reason
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static ushort Decode(byte* pointer, int offset)
    {
        return *(ushort*) (pointer + offset);
    }
}
