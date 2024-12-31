using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Add Complex Instrument Response Message Methods
    /// </summary>

    public static partial class AddComplexInstrumentResponse
    {
        /// <summary>
        ///  Eti Identifier for Add Complex Instrument Response
        /// </summary>
        public const string Identifier = "10302";

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

            Pad2.Encode(pointer, current, out current);

            if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
            {
                RequestTime.Encode(pointer, current, requestTime, out current);
            }
            else
            {
                RequestTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TrdRegTsTimeIn.FixTag, out var trdRegTsTimeIn))
            {
                TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);
            }
            else
            {
                TrdRegTsTimeIn.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
            {
                TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
            }
            else
            {
                TrdRegTsTimeOut.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ResponseIn.FixTag, out var responseIn))
            {
                ResponseIn.Encode(pointer, current, responseIn, out current);
            }
            else
            {
                ResponseIn.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            if (message.TryGetDouble(LowLimitPrice.FixTag, out var lowLimitPrice))
            {
                LowLimitPrice.Encode(pointer, current, lowLimitPrice, out current);
            }
            else
            {
                LowLimitPrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(HighLimitPrice.FixTag, out var highLimitPrice))
            {
                HighLimitPrice.Encode(pointer, current, highLimitPrice, out current);
            }
            else
            {
                HighLimitPrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(LastUpdateTime.FixTag, out var lastUpdateTime))
            {
                LastUpdateTime.Encode(pointer, current, lastUpdateTime, out current);
            }
            else
            {
                LastUpdateTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(SecurityResponseId.FixTag, out var securityResponseId))
            {
                SecurityResponseId.Encode(pointer, current, securityResponseId, out current);
            }
            else
            {
                SecurityResponseId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(NumberOfSecurities.FixTag, out var numberOfSecurities))
            {
                NumberOfSecurities.Encode(pointer, current, numberOfSecurities, out current);
            }
            else
            {
                NumberOfSecurities.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SecuritySubType.FixTag, out var securitySubType))
            {
                SecuritySubType.Encode(pointer, current, securitySubType, out current);
            }
            else
            {
                SecuritySubType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuantityScalingFactor.FixTag, out var quantityScalingFactor))
            {
                QuantityScalingFactor.Encode(pointer, current, (ushort)quantityScalingFactor, out current);
            }
            else
            {
                QuantityScalingFactor.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MultilegModel.FixTag, out var multilegModel))
            {
                MultilegModel.Encode(pointer, current, (byte)multilegModel, out current);
            }
            else
            {
                MultilegModel.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ImpliedMarketIndicator.FixTag, out var impliedMarketIndicator))
            {
                ImpliedMarketIndicator.Encode(pointer, current, (byte)impliedMarketIndicator, out current);
            }
            else
            {
                ImpliedMarketIndicator.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
            {
                ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
            }
            else
            {
                ProductComplex.SetNull(pointer, current, out current);
            }

            var isInstrmtLegGrpComp = message.TryGetGroup(NoLegOnbooks.FixTag, out var instrmtLegGrpComp) && instrmtLegGrpComp.sectionList.Count > 0;
            if (isInstrmtLegGrpComp)
            {
                var noLegOnbooks = (byte)instrmtLegGrpComp.sectionList.Count;
                NoLegOnbooks.Encode(pointer, current, noLegOnbooks, out current);
            }
            else
            {
                NoLegOnbooks.Zero(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            if (isInstrmtLegGrpComp)
            {
                InstrmtLegGrpComp.Encode(pointer, current, instrmtLegGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Add Complex Instrument Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = AddComplexInstrumentResponse.Identifier;

            // --- decode add complex instrument response message ---

            current += Pad2.Length;

            if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
            {
                message.AppendULong(RequestTime.FixTag, requestTime);
            }

            if (TrdRegTsTimeIn.TryDecode(pointer, current, out var trdRegTsTimeIn, out current))
            {
                message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);
            }

            if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
            {
                message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
            }

            if (ResponseIn.TryDecode(pointer, current, out var responseIn, out current))
            {
                message.AppendULong(ResponseIn.FixTag, responseIn);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad3.Length;

            if (LowLimitPrice.TryDecode(pointer, current, out var lowLimitPrice, out current))
            {
                message.AppendDouble(LowLimitPrice.FixTag, lowLimitPrice);
            }

            if (HighLimitPrice.TryDecode(pointer, current, out var highLimitPrice, out current))
            {
                message.AppendDouble(HighLimitPrice.FixTag, highLimitPrice);
            }

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (LastUpdateTime.TryDecode(pointer, current, out var lastUpdateTime, out current))
            {
                message.AppendULong(LastUpdateTime.FixTag, lastUpdateTime);
            }

            if (SecurityResponseId.TryDecode(pointer, current, out var securityResponseId, out current))
            {
                message.AppendULong(SecurityResponseId.FixTag, securityResponseId);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (NumberOfSecurities.TryDecode(pointer, current, out var numberOfSecurities, out current))
            {
                message.AppendInt(NumberOfSecurities.FixTag, numberOfSecurities);
            }

            if (SecuritySubType.TryDecode(pointer, current, out var securitySubType, out current))
            {
                message.AppendInt(SecuritySubType.FixTag, securitySubType);
            }

            if (QuantityScalingFactor.TryDecode(pointer, current, out var quantityScalingFactor, out current))
            {
                message.AppendInt(QuantityScalingFactor.FixTag, (short)quantityScalingFactor);
            }

            if (MultilegModel.TryDecode(pointer, current, out var multilegModel, out current))
            {
                message.AppendInt(MultilegModel.FixTag, multilegModel);
            }

            if (ImpliedMarketIndicator.TryDecode(pointer, current, out var impliedMarketIndicator, out current))
            {
                message.AppendInt(ImpliedMarketIndicator.FixTag, impliedMarketIndicator);
            }

            if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
            {
                message.AppendInt(ProductComplex.FixTag, productComplex);
            }

            var noLegOnbooks = (int)NoLegOnbooks.Decode(pointer, current, out current);

            current += Pad6.Length;

            InstrmtLegGrpComp.Decode(ref message, pointer, current, noLegOnbooks, out current);

            return FixErrorCode.None;
        }
    }
}