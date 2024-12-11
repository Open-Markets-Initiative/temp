using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Entry Ack Grp Comp Message Methods
    /// </summary>

    public static partial class QuoteEntryAckGrpComp
    {
        /// <summary>
        ///  Fix Tag for Quote Entry Ack Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39128;

        /// <summary>
        ///  Encode Quote Entry Ack Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup quoteEntryAckGrpComp, out int current)
        {
            current = offset;

            foreach (var group in quoteEntryAckGrpComp.sectionList)
            {
                if (group.TryGetLong(SecurityId.FixTag, out var securityId))
                {
                    SecurityId.Encode(pointer, current, securityId, out current);
                }
                else
                {
                    SecurityId.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(CxlSize.FixTag, out var cxlSize))
                {
                    CxlSize.Encode(pointer, current, cxlSize, out current);
                }
                else
                {
                    CxlSize.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(QuoteEntryRejectReason.FixTag, out var quoteEntryRejectReason))
                {
                    QuoteEntryRejectReason.Encode(pointer, current, (uint)quoteEntryRejectReason, out current);
                }
                else
                {
                    QuoteEntryRejectReason.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(QuoteEntryStatus.FixTag, out var quoteEntryStatus))
                {
                    QuoteEntryStatus.Encode(pointer, current, (byte)quoteEntryStatus, out current);
                }
                else
                {
                    QuoteEntryStatus.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

                Pad2.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Quote Entry Ack Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoQuoteSideEntries.FixTag, count);

            while (count-- > 0)
            {
                if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
                {
                    message.AppendLong(SecurityId.FixTag, securityId);
                }

                if (CxlSize.TryDecode(pointer, current, out var cxlSize, out current))
                {
                    message.AppendDouble(CxlSize.FixTag, cxlSize);
                }

                if (QuoteEntryRejectReason.TryDecode(pointer, current, out var quoteEntryRejectReason, out current))
                {
                    message.AppendInt(QuoteEntryRejectReason.FixTag, (int)quoteEntryRejectReason);
                }

                if (QuoteEntryStatus.TryDecode(pointer, current, out var quoteEntryStatus, out current))
                {
                    message.AppendInt(QuoteEntryStatus.FixTag, quoteEntryStatus);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                current += Pad2.Length;

            }
        }
    }
}