using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Root Party Grp Comp Message Methods
    /// </summary>

    public partial class BasketRootPartyGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Root Party Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39102;

        /// <summary>
        ///  Length of Basket Root Party Grp Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Basket Root Party Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode basket root party grp comp ---

            if (!message.TryGetGroup(BasketRootPartyGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(BasketRootPartyGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var rootPartySubIdType = (ushort)group.GetInt(RootPartySubIdType.FixTag);
                RootPartySubIdType.Encode(pointer, current, rootPartySubIdType, out current);

                if (group.TryGetString(RootPartyContraFirm.FixTag, out var rootPartyContraFirm))
                {
                    RootPartyContraFirm.Encode(pointer, current, rootPartyContraFirm, out current);
                }
                else
                {
                    RootPartyContraFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(RootPartyContraTrader.FixTag, out var rootPartyContraTrader))
                {
                    RootPartyContraTrader.Encode(pointer, current, rootPartyContraTrader, out current);
                }
                else
                {
                    RootPartyContraTrader.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(BasketSideTradeReportId.FixTag, out var basketSideTradeReportId))
                {
                    BasketSideTradeReportId.Encode(pointer, current, basketSideTradeReportId, out current);
                }
                else
                {
                    BasketSideTradeReportId.SetNull(pointer, current, out current);
                }

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Basket Root Party Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            BasketRootPartyGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}