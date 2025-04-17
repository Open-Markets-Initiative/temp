using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Quote Event Grp Comp Message Methods
/// </summary>

public static partial class QuoteEventGrpComp
{
    /// <summary>
    ///  Fix Tag for Quote Event Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39130;

    /// <summary>
    ///  Encode Quote Event Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup quoteEventGrpComp, out int current)
    {
        current = offset;

        foreach (var group in quoteEventGrpComp.sectionList)
        {
            if (group.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(QuoteEventPx.FixTag, out var quoteEventPx))
            {
                QuoteEventPx.Encode(pointer, current, quoteEventPx, out current);
            }
            else
            {
                QuoteEventPx.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(QuoteEventQty.FixTag, out var quoteEventQty))
            {
                QuoteEventQty.Encode(pointer, current, quoteEventQty, out current);
            }
            else
            {
                QuoteEventQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(QuoteMsgId.FixTag, out var quoteMsgId))
            {
                QuoteMsgId.Encode(pointer, current, quoteMsgId, out current);
            }
            else
            {
                QuoteMsgId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteEventMatchId.FixTag, out var quoteEventMatchId))
            {
                QuoteEventMatchId.Encode(pointer, current, (uint)quoteEventMatchId, out current);
            }
            else
            {
                QuoteEventMatchId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteEventExecId.FixTag, out var quoteEventExecId))
            {
                QuoteEventExecId.Encode(pointer, current, quoteEventExecId, out current);
            }
            else
            {
                QuoteEventExecId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteEventType.FixTag, out var quoteEventType))
            {
                QuoteEventType.Encode(pointer, current, (byte)quoteEventType, out current);
            }
            else
            {
                QuoteEventType.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteEventSide.FixTag, out var quoteEventSide))
            {
                QuoteEventSide.Encode(pointer, current, (byte)quoteEventSide, out current);
            }
            else
            {
                QuoteEventSide.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteEventLiquidityInd.FixTag, out var quoteEventLiquidityInd))
            {
                QuoteEventLiquidityInd.Encode(pointer, current, (byte)quoteEventLiquidityInd, out current);
            }
            else
            {
                QuoteEventLiquidityInd.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteEventReason.FixTag, out var quoteEventReason))
            {
                QuoteEventReason.Encode(pointer, current, (byte)quoteEventReason, out current);
            }
            else
            {
                QuoteEventReason.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Quote Event Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoQuoteEvents.FixTag, count);

        while (count-- > 0)
        {
            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (QuoteEventPx.TryDecode(pointer, current, out var quoteEventPx, out current))
            {
                message.AppendDouble(QuoteEventPx.FixTag, quoteEventPx);
            }

            if (QuoteEventQty.TryDecode(pointer, current, out var quoteEventQty, out current))
            {
                message.AppendDouble(QuoteEventQty.FixTag, quoteEventQty);
            }

            if (QuoteMsgId.TryDecode(pointer, current, out var quoteMsgId, out current))
            {
                message.AppendULong(QuoteMsgId.FixTag, quoteMsgId);
            }

            if (QuoteEventMatchId.TryDecode(pointer, current, out var quoteEventMatchId, out current))
            {
                message.AppendInt(QuoteEventMatchId.FixTag, (int)quoteEventMatchId);
            }

            if (QuoteEventExecId.TryDecode(pointer, current, out var quoteEventExecId, out current))
            {
                message.AppendInt(QuoteEventExecId.FixTag, quoteEventExecId);
            }

            if (QuoteEventType.TryDecode(pointer, current, out var quoteEventType, out current))
            {
                message.AppendInt(QuoteEventType.FixTag, quoteEventType);
            }

            if (QuoteEventSide.TryDecode(pointer, current, out var quoteEventSide, out current))
            {
                message.AppendInt(QuoteEventSide.FixTag, quoteEventSide);
            }

            if (QuoteEventLiquidityInd.TryDecode(pointer, current, out var quoteEventLiquidityInd, out current))
            {
                message.AppendInt(QuoteEventLiquidityInd.FixTag, quoteEventLiquidityInd);
            }

            if (QuoteEventReason.TryDecode(pointer, current, out var quoteEventReason, out current))
            {
                message.AppendInt(QuoteEventReason.FixTag, quoteEventReason);
            }

            current += Pad4.Length;

        }
    }
}
