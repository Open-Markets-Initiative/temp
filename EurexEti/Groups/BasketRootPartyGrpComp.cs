using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Root Party Grp Comp Message Methods
    /// </summary>

    public static partial class BasketRootPartyGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Root Party Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39102;

        /// <summary>
        ///  Encode Basket Root Party Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup basketRootPartyGrpComp, out int current)
        {
            current = offset;

            foreach (var group in basketRootPartyGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoBasketRootPartyGrps.FixTag, count);

            while (count-- > 0)
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