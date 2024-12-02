namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Sessions Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SessionsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SessionsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.PartyIdSessionId.FixTag,
                Eurex.EtiDerivatives.v121.SessionMode.FixTag,
                Eurex.EtiDerivatives.v121.SessionSubMode.FixTag,
                Eurex.EtiDerivatives.v121.Pad2.FixTag,
            }
        };
    }
}