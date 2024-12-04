namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Not Affected Orders Grp Comp
        /// </summary>
        public static readonly FixComponentBlock NotAffectedOrdersGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.NotAffectedOrdersGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.NotAffectedOrderId.FixTag,
                Eurex.EtiDerivatives.v130.NotAffOrigClOrdId.FixTag,
            }
        };
    }
}