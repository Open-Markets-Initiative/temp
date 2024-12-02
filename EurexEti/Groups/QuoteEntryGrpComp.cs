using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Entry Grp Comp Message Methods
    /// </summary>

    public partial class QuoteEntryGrpComp
    {
        /// <summary>
        ///  Length of Quote Entry Grp Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Quote Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, QuoteEntryGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode quote entry grp comp ---

            if (!message.TryGetGroup(QuoteEntryGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(QuoteEntryGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var bidPx = group.GetDouble(BidPx.FixTag);
                BidPx.Encode(pointer, current, bidPx, out current);

                var bidSize = group.GetDouble(BidSize.FixTag);
                BidSize.Encode(pointer, current, bidSize, out current);

                var offerPx = group.GetDouble(OfferPx.FixTag);
                OfferPx.Encode(pointer, current, offerPx, out current);

                var offerSize = group.GetDouble(OfferSize.FixTag);
                OfferSize.Encode(pointer, current, offerSize, out current);

            }
        }

        /// <summary>
        ///  Decode Quote Entry Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode quote entry grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode quote entry grp comp group ---

            message.AppendInt(QuoteEntryGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var bidPx = BidPx.Decode(pointer, current, out current);
                message.AppendDouble(BidPx.FixTag, bidPx);

                var bidSize = BidSize.Decode(pointer, current, out current);
                message.AppendDouble(BidSize.FixTag, bidSize);

                var offerPx = OfferPx.Decode(pointer, current, out current);
                message.AppendDouble(OfferPx.FixTag, offerPx);

                var offerSize = OfferSize.Decode(pointer, current, out current);
                message.AppendDouble(OfferSize.FixTag, offerSize);

            }
        }
    }
}