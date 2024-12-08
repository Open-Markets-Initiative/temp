using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Enter Clip Request Message Methods
    /// </summary>

    public static partial class EnterClipRequest
    {
        /// <summary>
        ///  Eti Identifier for Enter Clip Request
        /// </summary>
        public const string Identifier = "10131";

        /// <summary>
        ///  Encode Enter Clip Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.EnterClipRequest, out current);

            // --- encode enter clip request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var price = message.GetDouble(Price.FixTag);
            Price.Encode(pointer, current, price, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var crossId = message.GetInt(CrossId.FixTag);
            CrossId.Encode(pointer, current, crossId, out current);

            var crossRequestId = message.GetInt(CrossRequestId.FixTag);
            CrossRequestId.Encode(pointer, current, crossRequestId, out current);

            var isCrossRequestSideGrpComp = message.TryGetGroup(NoSides.FixTag, out var crossRequestSideGrpComp) && crossRequestSideGrpComp.sectionList.Count > 0;
            if (isCrossRequestSideGrpComp)
            {
                var noSides = (byte)crossRequestSideGrpComp.sectionList.Count;
                NoSides.Encode(pointer, current, noSides, out current);
            }
            else
            {
                NoSides.Zero(pointer, current, out current);
            }

            var isSideCrossLegGrpComp = message.TryGetGroup(NoCrossLegs.FixTag, out var sideCrossLegGrpComp) && sideCrossLegGrpComp.sectionList.Count > 0;
            if (isSideCrossLegGrpComp)
            {
                var noCrossLegs = (byte)sideCrossLegGrpComp.sectionList.Count;
                NoCrossLegs.Encode(pointer, current, noCrossLegs, out current);
            }
            else
            {
                NoCrossLegs.Zero(pointer, current, out current);
            }

            var crossRequestType = (byte)message.GetInt(CrossRequestType.FixTag);
            CrossRequestType.Encode(pointer, current, crossRequestType, out current);

            var crossType = (byte)message.GetInt(CrossType.FixTag);
            CrossType.Encode(pointer, current, crossType, out current);

            var crossPrioritization = (byte)message.GetInt(CrossPrioritization.FixTag);
            CrossPrioritization.Encode(pointer, current, crossPrioritization, out current);

            var sideDisclosureInstruction = (byte)message.GetInt(SideDisclosureInstruction.FixTag);
            SideDisclosureInstruction.Encode(pointer, current, sideDisclosureInstruction, out current);

            var priceDisclosureInstruction = (byte)message.GetInt(PriceDisclosureInstruction.FixTag);
            PriceDisclosureInstruction.Encode(pointer, current, priceDisclosureInstruction, out current);

            var orderQtyDisclosureInstruction = (byte)message.GetInt(OrderQtyDisclosureInstruction.FixTag);
            OrderQtyDisclosureInstruction.Encode(pointer, current, orderQtyDisclosureInstruction, out current);

            var priceValidityCheckType = (byte)message.GetInt(PriceValidityCheckType.FixTag);
            PriceValidityCheckType.Encode(pointer, current, priceValidityCheckType, out current);

            var valueCheckTypeValue = (byte)message.GetInt(ValueCheckTypeValue.FixTag);
            ValueCheckTypeValue.Encode(pointer, current, valueCheckTypeValue, out current);

            if (message.TryGetString(RootPartyContraFirm.FixTag, out var rootPartyContraFirm))
            {
                RootPartyContraFirm.Encode(pointer, current, rootPartyContraFirm, out current);
            }
            else
            {
                RootPartyContraFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(RootPartyContraTrader.FixTag, out var rootPartyContraTrader))
            {
                RootPartyContraTrader.Encode(pointer, current, rootPartyContraTrader, out current);
            }
            else
            {
                RootPartyContraTrader.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (isCrossRequestSideGrpComp)
            {
                CrossRequestSideGrpComp.Encode(pointer, current, crossRequestSideGrpComp, out current);
            }

            if (isSideCrossLegGrpComp)
            {
                SideCrossLegGrpComp.Encode(pointer, current, sideCrossLegGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Enter Clip Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = EnterClipRequest.Identifier;

            // --- decode enter clip request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var price = Price.Decode(pointer, current, out current);
            message.AppendDouble(Price.FixTag, price);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var crossId = CrossId.Decode(pointer, current, out current);
            message.AppendInt(CrossId.FixTag, crossId);

            var crossRequestId = CrossRequestId.Decode(pointer, current, out current);
            message.AppendInt(CrossRequestId.FixTag, crossRequestId);

            var noSides = (int)NoSides.Decode(pointer, current, out current);

            var noCrossLegs = (int)NoCrossLegs.Decode(pointer, current, out current);

            var crossRequestType = CrossRequestType.Decode(pointer, current, out current);
            message.AppendInt(CrossRequestType.FixTag, crossRequestType);

            var crossType = CrossType.Decode(pointer, current, out current);
            message.AppendInt(CrossType.FixTag, crossType);

            var crossPrioritization = CrossPrioritization.Decode(pointer, current, out current);
            message.AppendInt(CrossPrioritization.FixTag, crossPrioritization);

            var sideDisclosureInstruction = SideDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(SideDisclosureInstruction.FixTag, sideDisclosureInstruction);

            var priceDisclosureInstruction = PriceDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(PriceDisclosureInstruction.FixTag, priceDisclosureInstruction);

            var orderQtyDisclosureInstruction = OrderQtyDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(OrderQtyDisclosureInstruction.FixTag, orderQtyDisclosureInstruction);

            var priceValidityCheckType = PriceValidityCheckType.Decode(pointer, current, out current);
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);

            var valueCheckTypeValue = ValueCheckTypeValue.Decode(pointer, current, out current);
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);

            if (RootPartyContraFirm.TryDecode(pointer, current, out var rootPartyContraFirm, out current))
            {
                message.AppendString(RootPartyContraFirm.FixTag, rootPartyContraFirm);
            }

            if (RootPartyContraTrader.TryDecode(pointer, current, out var rootPartyContraTrader, out current))
            {
                message.AppendString(RootPartyContraTrader.FixTag, rootPartyContraTrader);
            }

            current += Pad7.Length;

            CrossRequestSideGrpComp.Decode(ref message, pointer, current, noSides, out current);

            SideCrossLegGrpComp.Decode(ref message, pointer, current, noCrossLegs, out current);

            return FixErrorCode.None;
        }
    }
}