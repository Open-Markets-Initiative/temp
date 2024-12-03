using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Add Complex Instrument Response Message Methods
    /// </summary>

    public partial class AddComplexInstrumentResponse
    {
        /// <summary>
        ///  Eti Identifier for Add Complex Instrument Response
        /// </summary>
        public const string Identifier = "Add Complex Instrument Response";

        /// <summary>
        ///  Encode Add Complex Instrument Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.AddComplexInstrumentResponse, out current);

            // --- encode add complex instrument response message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var lowLimitPrice = message.GetDouble(LowLimitPrice.FixTag);
            LowLimitPrice.Encode(pointer, current, lowLimitPrice, out current);

            var highLimitPrice = message.GetDouble(HighLimitPrice.FixTag);
            HighLimitPrice.Encode(pointer, current, highLimitPrice, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var lastUpdateTime = message.GetULong(LastUpdateTime.FixTag);
            LastUpdateTime.Encode(pointer, current, lastUpdateTime, out current);

            var securityResponseId = message.GetULong(SecurityResponseId.FixTag);
            SecurityResponseId.Encode(pointer, current, securityResponseId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var numberOfSecurities = message.GetInt(NumberOfSecurities.FixTag);
            NumberOfSecurities.Encode(pointer, current, numberOfSecurities, out current);

            var securitySubType = message.GetInt(SecuritySubType.FixTag);
            SecuritySubType.Encode(pointer, current, securitySubType, out current);

            var quantityScalingFactor = (ushort)message.GetInt(QuantityScalingFactor.FixTag);
            QuantityScalingFactor.Encode(pointer, current, quantityScalingFactor, out current);

            var multilegModel = (byte)message.GetInt(MultilegModel.FixTag);
            MultilegModel.Encode(pointer, current, multilegModel, out current);

            var impliedMarketIndicator = (byte)message.GetInt(ImpliedMarketIndicator.FixTag);
            ImpliedMarketIndicator.Encode(pointer, current, impliedMarketIndicator, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var noLegOnbooks = (byte)message.GetInt(NoLegOnbooks.FixTag);
            NoLegOnbooks.Encode(pointer, current, noLegOnbooks, out current);

            Pad6.Encode(pointer, current, out current);

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
        ///  Decode Add Complex Instrument Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = AddComplexInstrumentResponse.Identifier;

            // --- decode add complex instrument response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var trdRegTsTimeIn = TrdRegTsTimeIn.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var responseIn = ResponseIn.Decode(pointer, current, out current);
            message.AppendULong(ResponseIn.FixTag, responseIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var lowLimitPrice = LowLimitPrice.Decode(pointer, current, out current);
            message.AppendDouble(LowLimitPrice.FixTag, lowLimitPrice);

            var highLimitPrice = HighLimitPrice.Decode(pointer, current, out current);
            message.AppendDouble(HighLimitPrice.FixTag, highLimitPrice);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var lastUpdateTime = LastUpdateTime.Decode(pointer, current, out current);
            message.AppendULong(LastUpdateTime.FixTag, lastUpdateTime);

            var securityResponseId = SecurityResponseId.Decode(pointer, current, out current);
            message.AppendULong(SecurityResponseId.FixTag, securityResponseId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var numberOfSecurities = NumberOfSecurities.Decode(pointer, current, out current);
            message.AppendInt(NumberOfSecurities.FixTag, numberOfSecurities);

            var securitySubType = SecuritySubType.Decode(pointer, current, out current);
            message.AppendInt(SecuritySubType.FixTag, securitySubType);

            var quantityScalingFactor = (short)QuantityScalingFactor.Decode(pointer, current, out current);
            message.AppendInt(QuantityScalingFactor.FixTag, quantityScalingFactor);

            var multilegModel = MultilegModel.Decode(pointer, current, out current);
            message.AppendInt(MultilegModel.FixTag, multilegModel);

            var impliedMarketIndicator = ImpliedMarketIndicator.Decode(pointer, current, out current);
            message.AppendInt(ImpliedMarketIndicator.FixTag, impliedMarketIndicator);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var noLegOnbooks = NoLegOnbooks.Decode(pointer, current, out current);
            message.AppendInt(NoLegOnbooks.FixTag, noLegOnbooks);

            current += Pad6.Length;

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