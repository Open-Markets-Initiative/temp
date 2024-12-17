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

            if (uint.TryParse(message.senderSubID, out var senderSubId))
            {
                SenderSubId.Encode(pointer, current, senderSubId, out current);
            }
            else
            {
                SenderSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(Price.FixTag, out var price))
            {
                Price.Encode(pointer, current, price, out current);
            }
            else
            {
                Price.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OrderQty.FixTag, out var orderQty))
            {
                OrderQty.Encode(pointer, current, orderQty, out current);
            }
            else
            {
                OrderQty.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(CrossId.FixTag, out var crossId))
            {
                CrossId.Encode(pointer, current, crossId, out current);
            }
            else
            {
                CrossId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(CrossRequestId.FixTag, out var crossRequestId))
            {
                CrossRequestId.Encode(pointer, current, crossRequestId, out current);
            }
            else
            {
                CrossRequestId.SetNull(pointer, current, out current);
            }

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

            if (message.TryGetInt(CrossRequestType.FixTag, out var crossRequestType))
            {
                CrossRequestType.Encode(pointer, current, (byte)crossRequestType, out current);
            }
            else
            {
                CrossRequestType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(CrossType.FixTag, out var crossType))
            {
                CrossType.Encode(pointer, current, (byte)crossType, out current);
            }
            else
            {
                CrossType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(CrossPrioritization.FixTag, out var crossPrioritization))
            {
                CrossPrioritization.Encode(pointer, current, (byte)crossPrioritization, out current);
            }
            else
            {
                CrossPrioritization.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SideDisclosureInstruction.FixTag, out var sideDisclosureInstruction))
            {
                SideDisclosureInstruction.Encode(pointer, current, (byte)sideDisclosureInstruction, out current);
            }
            else
            {
                SideDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PriceDisclosureInstruction.FixTag, out var priceDisclosureInstruction))
            {
                PriceDisclosureInstruction.Encode(pointer, current, (byte)priceDisclosureInstruction, out current);
            }
            else
            {
                PriceDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrderQtyDisclosureInstruction.FixTag, out var orderQtyDisclosureInstruction))
            {
                OrderQtyDisclosureInstruction.Encode(pointer, current, (byte)orderQtyDisclosureInstruction, out current);
            }
            else
            {
                OrderQtyDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PriceValidityCheckType.FixTag, out var priceValidityCheckType))
            {
                PriceValidityCheckType.Encode(pointer, current, (byte)priceValidityCheckType, out current);
            }
            else
            {
                PriceValidityCheckType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ValueCheckTypeValue.FixTag, out var valueCheckTypeValue))
            {
                ValueCheckTypeValue.Encode(pointer, current, (byte)valueCheckTypeValue, out current);
            }
            else
            {
                ValueCheckTypeValue.SetNull(pointer, current, out current);
            }

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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (Price.TryDecode(pointer, current, out var price, out current))
            {
                message.AppendDouble(Price.FixTag, price);
            }

            if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
            {
                message.AppendDouble(OrderQty.FixTag, orderQty);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (CrossId.TryDecode(pointer, current, out var crossId, out current))
            {
                message.AppendInt(CrossId.FixTag, crossId);
            }

            if (CrossRequestId.TryDecode(pointer, current, out var crossRequestId, out current))
            {
                message.AppendInt(CrossRequestId.FixTag, crossRequestId);
            }

            var noSides = (int)NoSides.Decode(pointer, current, out current);

            var noCrossLegs = (int)NoCrossLegs.Decode(pointer, current, out current);

            if (CrossRequestType.TryDecode(pointer, current, out var crossRequestType, out current))
            {
                message.AppendInt(CrossRequestType.FixTag, crossRequestType);
            }

            if (CrossType.TryDecode(pointer, current, out var crossType, out current))
            {
                message.AppendInt(CrossType.FixTag, crossType);
            }

            if (CrossPrioritization.TryDecode(pointer, current, out var crossPrioritization, out current))
            {
                message.AppendInt(CrossPrioritization.FixTag, crossPrioritization);
            }

            if (SideDisclosureInstruction.TryDecode(pointer, current, out var sideDisclosureInstruction, out current))
            {
                message.AppendInt(SideDisclosureInstruction.FixTag, sideDisclosureInstruction);
            }

            if (PriceDisclosureInstruction.TryDecode(pointer, current, out var priceDisclosureInstruction, out current))
            {
                message.AppendInt(PriceDisclosureInstruction.FixTag, priceDisclosureInstruction);
            }

            if (OrderQtyDisclosureInstruction.TryDecode(pointer, current, out var orderQtyDisclosureInstruction, out current))
            {
                message.AppendInt(OrderQtyDisclosureInstruction.FixTag, orderQtyDisclosureInstruction);
            }

            if (PriceValidityCheckType.TryDecode(pointer, current, out var priceValidityCheckType, out current))
            {
                message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);
            }

            if (ValueCheckTypeValue.TryDecode(pointer, current, out var valueCheckTypeValue, out current))
            {
                message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);
            }

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