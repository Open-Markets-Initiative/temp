namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Mm Parameter Grp Comp
        /// </summary>
        public static readonly FixComponentBlock MmParameterGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.MmParameterGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.ExposureDuration.FixTag,
                Eurex.EtiDerivatives.v130.CumQty.FixTag,
                Eurex.EtiDerivatives.v130.Delta.FixTag,
                Eurex.EtiDerivatives.v130.Vega.FixTag,
                Eurex.EtiDerivatives.v130.PctCount.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyIdSessionId.FixTag,
                Eurex.EtiDerivatives.v130.MmRiskLimitActionType.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}