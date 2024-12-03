using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Entry Ack Grp Comp Message Methods
    /// </summary>

    public partial class QuoteEntryAckGrpComp
    {
        /// <summary>
        ///  Fix Tag for Quote Entry Ack Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39124;

        /// <summary>
        ///  Length of Quote Entry Ack Grp Comp in bytes
        /// </summary>
        public const int Length = 24;

        /// <summary>
        ///  Encode Quote Entry Ack Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode quote entry ack grp comp ---

            if (!message.TryGetGroup(QuoteEntryAckGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(QuoteEntryAckGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            QuoteEntryAckGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}