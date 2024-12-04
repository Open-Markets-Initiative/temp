namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Instrument Attribute Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrumentAttributeGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.InstrumentAttributeGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.InstrAttribType.FixTag,
                Eurex.EtiDerivatives.v130.InstrAttribValue.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}