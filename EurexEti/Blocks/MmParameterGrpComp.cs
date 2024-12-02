namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Mm Parameter Grp Comp
        /// </summary>
        public static readonly FixComponentBlock MmParameterGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.MmParameterGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.ExposureDuration.FixTag,
                Eurex.EtiDerivatives.v121.CumQty.FixTag,
                Eurex.EtiDerivatives.v121.Delta.FixTag,
                Eurex.EtiDerivatives.v121.Vega.FixTag,
                Eurex.EtiDerivatives.v121.PctCount.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyIdSessionId.FixTag,
            }
        };
    }
}