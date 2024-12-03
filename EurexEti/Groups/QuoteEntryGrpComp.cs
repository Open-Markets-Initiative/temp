using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Entry Grp Comp Message Methods
    /// </summary>

    public partial class QuoteEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Quote Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39125;

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

            // --- TODO ---

            QuoteEntryGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}