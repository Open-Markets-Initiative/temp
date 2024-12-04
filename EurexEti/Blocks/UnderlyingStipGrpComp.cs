namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Underlying Stip Grp Comp
        /// </summary>
        public static readonly FixComponentBlock UnderlyingStipGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.UnderlyingStipGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.UnderlyingStipValue.FixTag,
                Eurex.EtiDerivatives.v130.UnderlyingStipType.FixTag,
                Eurex.EtiDerivatives.v130.Pad1.FixTag,
            }
        };
    }
}