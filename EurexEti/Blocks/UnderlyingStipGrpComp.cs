namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Underlying Stip Grp Comp
        /// </summary>
        public static readonly FixComponentBlock UnderlyingStipGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.UnderlyingStipGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.UnderlyingStipValue.FixTag,
                Eurex.EtiDerivatives.v121.UnderlyingStipType.FixTag,
                Eurex.EtiDerivatives.v121.Pad1.FixTag,
            }
        };
    }
}