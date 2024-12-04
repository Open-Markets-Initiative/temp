namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Not Affected Securities Grp Comp
        /// </summary>
        public static readonly FixComponentBlock NotAffectedSecuritiesGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.NotAffectedSecuritiesGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.NotAffectedSecurityId.FixTag,
            }
        };
    }
}