using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Basket Root Party Grp Comp Message Methods
    /// </summary>

    public partial class BasketRootPartyGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, BasketRootPartyGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode basket root party grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode basket root party grp comp group ---

            message.AppendInt(BasketRootPartyGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var rootPartySubIdType = (short)RootPartySubIdType.Decode(pointer, current, out current);
                message.AppendInt(RootPartySubIdType.FixTag, rootPartySubIdType);

                if (RootPartyContraFirm.TryDecode(pointer, current, out var rootPartyContraFirm, out current))
                {
                    message.AppendString(RootPartyContraFirm.FixTag, rootPartyContraFirm);
                }

                if (RootPartyContraTrader.TryDecode(pointer, current, out var rootPartyContraTrader, out current))
                {
                    message.AppendString(RootPartyContraTrader.FixTag, rootPartyContraTrader);
                }

                if (BasketSideTradeReportId.TryDecode(pointer, current, out var basketSideTradeReportId, out current))
                {
                    message.AppendString(BasketSideTradeReportId.FixTag, basketSideTradeReportId);
                }

                current += Pad7.Length;

            }
        }
    }
}