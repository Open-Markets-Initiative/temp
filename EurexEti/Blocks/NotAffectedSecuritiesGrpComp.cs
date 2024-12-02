namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Not Affected Securities Grp Comp
        /// </summary>
        public static readonly FixComponentBlock NotAffectedSecuritiesGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.NotAffectedSecuritiesGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.NotAffectedSecurityId.FixTag,
            }
        };
    }
}