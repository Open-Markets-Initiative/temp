using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Side Alloc Grp Comp Message Methods
    /// </summary>

    public partial class SideAllocGrpComp
    {
        /// <summary>
        ///  Fix Tag for Side Alloc Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39135;

        /// <summary>
        ///  Length of Side Alloc Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode side alloc grp comp ---

            if (!message.TryGetGroup(SideAllocGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SideAllocGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var allocQty = group.GetDouble(AllocQty.FixTag);
                AllocQty.Encode(pointer, current, allocQty, out current);

                var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
                IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

                var tesEnrichmentRuleId = (uint)group.GetInt(TesEnrichmentRuleId.FixTag);
                TesEnrichmentRuleId.Encode(pointer, current, tesEnrichmentRuleId, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
                {
                    PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
                }
                else
                {
                    PartyExecutingFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
                {
                    PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
                }
                else
                {
                    PartyExecutingTrader.SetNull(pointer, current, out current);
                }

                Pad4.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Side Alloc Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            SideAllocGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}