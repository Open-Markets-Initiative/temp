namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Instrument Event Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrumentEventGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.InstrumentEventGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.EventDate.FixTag,
                Eurex.EtiDerivatives.v130.EventType.FixTag,
                Eurex.EtiDerivatives.v130.Pad3.FixTag,
            }
        };
    }
}