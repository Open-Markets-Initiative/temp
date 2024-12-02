namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Instrument Attribute Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrumentAttributeGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.InstrumentAttributeGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.InstrAttribType.FixTag,
                Eurex.EtiDerivatives.v121.InstrAttribValue.FixTag,
                Eurex.EtiDerivatives.v121.Pad7.FixTag,
            }
        };
    }
}