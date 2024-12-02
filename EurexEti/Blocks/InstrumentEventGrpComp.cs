namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Instrument Event Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrumentEventGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.InstrumentEventGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.EventDate.FixTag,
                Eurex.EtiDerivatives.v121.EventType.FixTag,
                Eurex.EtiDerivatives.v121.Pad3.FixTag,
            }
        };
    }
}