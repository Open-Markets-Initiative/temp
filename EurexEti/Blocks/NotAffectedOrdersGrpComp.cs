namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Not Affected Orders Grp Comp
        /// </summary>
        public static readonly FixComponentBlock NotAffectedOrdersGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.NotAffectedOrdersGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.NotAffectedOrderId.FixTag,
                Eurex.EtiDerivatives.v121.NotAffOrigClOrdId.FixTag,
            }
        };
    }
}