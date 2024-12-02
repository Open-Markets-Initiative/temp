namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Smart Party Detail Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SmartPartyDetailGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SmartPartyDetailGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.PartyDetailExecutingUnit.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.Pad5.FixTag,
            }
        };
    }
}