namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Sessions Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SessionsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SessionsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.PartyIdSessionId.FixTag,
                Eurex.EtiDerivatives.v130.SessionMode.FixTag,
                Eurex.EtiDerivatives.v130.SessionSubMode.FixTag,
                Eurex.EtiDerivatives.v130.Pad2.FixTag,
            }
        };
    }
}