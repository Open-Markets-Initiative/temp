namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Party Details Grp Comp
        /// </summary>
        public static readonly FixComponentBlock PartyDetailsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.PartyDetailsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.PartyDetailIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailRoleQualifier.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailStatus.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailDeskId.FixTag,
                Eurex.EtiDerivatives.v130.Pad1.FixTag,
            }
        };
    }
}