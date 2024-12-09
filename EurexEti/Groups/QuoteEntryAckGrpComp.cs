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
                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var cxlSize = group.GetDouble(CxlSize.FixTag);
                CxlSize.Encode(pointer, current, cxlSize, out current);

                var quoteEntryRejectReason = (uint)group.GetInt(QuoteEntryRejectReason.FixTag);
                QuoteEntryRejectReason.Encode(pointer, current, quoteEntryRejectReason, out current);

                var quoteEntryStatus = (byte)group.GetInt(QuoteEntryStatus.FixTag);
                QuoteEntryStatus.Encode(pointer, current, quoteEntryStatus, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

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

            message.AppendInt(noQuoteSideEntries.FixTag, count);

            while (count--)
            {
                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var cxlSize = CxlSize.Decode(pointer, current, out current);
                message.AppendDouble(CxlSize.FixTag, cxlSize);

                var quoteEntryRejectReason = (int)QuoteEntryRejectReason.Decode(pointer, current, out current);
                message.AppendInt(QuoteEntryRejectReason.FixTag, quoteEntryRejectReason);

                var quoteEntryStatus = QuoteEntryStatus.Decode(pointer, current, out current);
                message.AppendInt(QuoteEntryStatus.FixTag, quoteEntryStatus);

                var side = Side.Decode(pointer, current, out current);
                message.AppendInt(Side.FixTag, side);

                current += Pad2.Length;

            }
        }
    }
}