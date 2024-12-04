namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Smart Party Detail Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SmartPartyDetailGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SmartPartyDetailGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.PartyDetailExecutingUnit.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.Pad5.FixTag,
            }
        };
    }
}