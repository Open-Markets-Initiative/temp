using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Target Party Trd Grp Comp Message Methods
    /// </summary>

    public partial static class SrqsTargetPartyTrdGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Target Party Trd Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39145;

        /// <summary>
        ///  Encode Srqs Target Party Trd Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int srqsTargetPartyTrdGrpComp, out int current)
        {
            current = offset;

            foreach (var group in srqsTargetPartyTrdGrpComp.sectionList)
            {
                var sideLastQty = group.GetDouble(SideLastQty.FixTag);
                SideLastQty.Encode(pointer, current, sideLastQty, out current);

                var quoteId = group.GetULong(QuoteId.FixTag);
                QuoteId.Encode(pointer, current, quoteId, out current);

                var targetPartyIdExecutingTrader = (uint)group.GetInt(TargetPartyIdExecutingTrader.FixTag);
                TargetPartyIdExecutingTrader.Encode(pointer, current, targetPartyIdExecutingTrader, out current);

                if (group.TryGetString(TargetPartyExecutingFirm.FixTag, out var targetPartyExecutingFirm))
                {
                    TargetPartyExecutingFirm.Encode(pointer, current, targetPartyExecutingFirm, out current);
                }
                else
                {
                    TargetPartyExecutingFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(TargetPartyExecutingTrader.FixTag, out var targetPartyExecutingTrader))
                {
                    TargetPartyExecutingTrader.Encode(pointer, current, targetPartyExecutingTrader, out current);
                }
                else
                {
                    TargetPartyExecutingTrader.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(TargetPartyEnteringTrader.FixTag, out var targetPartyEnteringTrader))
                {
                    TargetPartyEnteringTrader.Encode(pointer, current, targetPartyEnteringTrader, out current);
                }
                else
                {
                    TargetPartyEnteringTrader.SetNull(pointer, current, out current);
                }

                Pad3.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Srqs Target Party Trd Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noSrqsTargetPartyTrdGrps.FixTag, count);

            while (count--)
            {
                var sideLastQty = SideLastQty.Decode(pointer, current, out current);
                message.AppendDouble(SideLastQty.FixTag, sideLastQty);

                var quoteId = QuoteId.Decode(pointer, current, out current);
                message.AppendULong(QuoteId.FixTag, quoteId);

                var targetPartyIdExecutingTrader = (int)TargetPartyIdExecutingTrader.Decode(pointer, current, out current);
                message.AppendInt(TargetPartyIdExecutingTrader.FixTag, targetPartyIdExecutingTrader);

                if (TargetPartyExecutingFirm.TryDecode(pointer, current, out var targetPartyExecutingFirm, out current))
                {
                    message.AppendString(TargetPartyExecutingFirm.FixTag, targetPartyExecutingFirm);
                }

                if (TargetPartyExecutingTrader.TryDecode(pointer, current, out var targetPartyExecutingTrader, out current))
                {
                    message.AppendString(TargetPartyExecutingTrader.FixTag, targetPartyExecutingTrader);
                }

                if (TargetPartyEnteringTrader.TryDecode(pointer, current, out var targetPartyEnteringTrader, out current))
                {
                    message.AppendString(TargetPartyEnteringTrader.FixTag, targetPartyEnteringTrader);
                }

                current += Pad3.Length;

            }
        }
    }
}