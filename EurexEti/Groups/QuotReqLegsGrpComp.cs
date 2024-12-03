using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quot Req Legs Grp Comp Message Methods
    /// </summary>

    public partial class QuotReqLegsGrpComp
    {
        /// <summary>
        ///  Length of Quot Req Legs Grp Comp in bytes
        /// </summary>
        public const int Length = 24;

        /// <summary>
        ///  Encode Quot Req Legs Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode quot req legs grp comp ---

            if (!message.TryGetGroup(QuotReqLegsGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(QuotReqLegsGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legRatioQty = (uint)group.GetInt(LegRatioQty.FixTag);
                LegRatioQty.Encode(pointer, current, legRatioQty, out current);

                var legSymbol = group.GetInt(LegSymbol.FixTag);
                LegSymbol.Encode(pointer, current, legSymbol, out current);

                var legSecurityType = (byte)group.GetInt(LegSecurityType.FixTag);
                LegSecurityType.Encode(pointer, current, legSecurityType, out current);

                var legSide = (byte)group.GetInt(LegSide.FixTag);
                LegSide.Encode(pointer, current, legSide, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Quot Req Legs Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legRatioQty = (int)LegRatioQty.Decode(pointer, current, out current);
            message.AppendInt(LegRatioQty.FixTag, legRatioQty);

            var legSymbol = LegSymbol.Decode(pointer, current, out current);
            message.AppendInt(LegSymbol.FixTag, legSymbol);

            var legSecurityType = LegSecurityType.Decode(pointer, current, out current);
            message.AppendInt(LegSecurityType.FixTag, legSecurityType);

            var legSide = LegSide.Decode(pointer, current, out current);
            message.AppendInt(LegSide.FixTag, legSide);

            current += Pad6.Length;

        }
    }
}