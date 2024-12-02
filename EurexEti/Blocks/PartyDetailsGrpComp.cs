namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Party Details Grp Comp
        /// </summary>
        public static readonly FixComponentBlock PartyDetailsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.PartyDetailsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.PartyDetailIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailRoleQualifier.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailStatus.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailDeskId.FixTag,
                Eurex.EtiDerivatives.v121.Pad1.FixTag,
            }
        };
    }
}