using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Add Complex Instrument Request Message Methods
    /// </summary>

    public partial class AddComplexInstrumentRequest
    {
        /// <summary>
        ///  Eti Identifier for Add Complex Instrument Request
        /// </summary>
        public const string Identifier = "Add Complex Instrument Request";

        /// <summary>
        ///  Encode Add Complex Instrument Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.AddComplexInstrumentRequest, out current);

            // --- encode add complex instrument request message ---

            var start = current;

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = (uint)message.GetInt(SenderSubId.FixTag);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var securitySubType = message.GetInt(SecuritySubType.FixTag);
            SecuritySubType.Encode(pointer, current, securitySubType, out current);

            var quantityScalingFactor = (ushort)message.GetInt(QuantityScalingFactor.FixTag);
            QuantityScalingFactor.Encode(pointer, current, quantityScalingFactor, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var noLegOnbooks = (byte)message.GetInt(NoLegOnbooks.FixTag);
            NoLegOnbooks.Encode(pointer, current, noLegOnbooks, out current);

            var multilegModel = (byte)message.GetInt(MultilegModel.FixTag);
            MultilegModel.Encode(pointer, current, multilegModel, out current);

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            var legSecurityId = group.GetLong(LegSecurityId.FixTag);
            LegSecurityId.Encode(pointer, current, legSecurityId, out current);

            var legPrice = group.GetDouble(LegPrice.FixTag);
            LegPrice.Encode(pointer, current, legPrice, out current);

            var legSymbol = group.GetInt(LegSymbol.FixTag);
            LegSymbol.Encode(pointer, current, legSymbol, out current);

            var legRatioQty = (uint)group.GetInt(LegRatioQty.FixTag);
            LegRatioQty.Encode(pointer, current, legRatioQty, out current);

            var legSide = (byte)group.GetInt(LegSide.FixTag);
            LegSide.Encode(pointer, current, legSide, out current);

            var legSecurityType = (byte)group.GetInt(LegSecurityType.FixTag);
            LegSecurityType.Encode(pointer, current, legSecurityType, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Add Complex Instrument Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = AddComplexInstrumentRequest.Identifier;

            // --- decode add complex instrument request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var securitySubType = SecuritySubType.Decode(pointer, current, out current);
            message.AppendInt(SecuritySubType.FixTag, securitySubType);

            var quantityScalingFactor = (short)QuantityScalingFactor.Decode(pointer, current, out current);
            message.AppendInt(QuantityScalingFactor.FixTag, quantityScalingFactor);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var noLegOnbooks = NoLegOnbooks.Decode(pointer, current, out current);
            message.AppendInt(NoLegOnbooks.FixTag, noLegOnbooks);

            var multilegModel = MultilegModel.Decode(pointer, current, out current);
            message.AppendInt(MultilegModel.FixTag, multilegModel);

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad7.Length;

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legPrice = LegPrice.Decode(pointer, current, out current);
            message.AppendDouble(LegPrice.FixTag, legPrice);

            var legSymbol = LegSymbol.Decode(pointer, current, out current);
            message.AppendInt(LegSymbol.FixTag, legSymbol);

            var legRatioQty = (int)LegRatioQty.Decode(pointer, current, out current);
            message.AppendInt(LegRatioQty.FixTag, legRatioQty);

            var legSide = LegSide.Decode(pointer, current, out current);
            message.AppendInt(LegSide.FixTag, legSide);

            var legSecurityType = LegSecurityType.Decode(pointer, current, out current);
            message.AppendInt(LegSecurityType.FixTag, legSecurityType);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}