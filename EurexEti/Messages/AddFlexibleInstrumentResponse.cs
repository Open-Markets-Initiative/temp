using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Add Flexible Instrument Response Message Methods
    /// </summary>

    public partial class AddFlexibleInstrumentResponse
    {
        /// <summary>
        ///  Eti Identifier for Add Flexible Instrument Response
        /// </summary>
        public const string Identifier = "Add Flexible Instrument Response";

        /// <summary>
        ///  Encode Add Flexible Instrument Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.AddFlexibleInstrumentResponse, out current);

            // --- encode add flexible instrument response message ---

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

            var securityResponseId = message.GetULong(SecurityResponseId.FixTag);
            SecurityResponseId.Encode(pointer, current, securityResponseId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var strikePrice = message.GetDouble(StrikePrice.FixTag);
            StrikePrice.Encode(pointer, current, strikePrice, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var maturityDate = (uint)message.GetInt(MaturityDate.FixTag);
            MaturityDate.Encode(pointer, current, maturityDate, out current);

            var contractDate = (uint)message.GetInt(ContractDate.FixTag);
            ContractDate.Encode(pointer, current, contractDate, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var settlMethod = message.GetToken(SettlMethod.FixTag);
            SettlMethod.Encode(pointer, current, settlMethod, out current);

            var optAttribute = (byte)message.GetInt(OptAttribute.FixTag);
            OptAttribute.Encode(pointer, current, optAttribute, out current);

            var putOrCall = (byte)message.GetInt(PutOrCall.FixTag);
            PutOrCall.Encode(pointer, current, putOrCall, out current);

            var exerciseStyle = (byte)message.GetInt(ExerciseStyle.FixTag);
            ExerciseStyle.Encode(pointer, current, exerciseStyle, out current);

            Pad7.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Add Flexible Instrument Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = AddFlexibleInstrumentResponse.Identifier;

            // --- decode add flexible instrument response message ---

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

            var securityResponseId = SecurityResponseId.Decode(pointer, current, out current);
            message.AppendULong(SecurityResponseId.FixTag, securityResponseId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var strikePrice = StrikePrice.Decode(pointer, current, out current);
            message.AppendDouble(StrikePrice.FixTag, strikePrice);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var maturityDate = (int)MaturityDate.Decode(pointer, current, out current);
            message.AppendInt(MaturityDate.FixTag, maturityDate);

            var contractDate = (int)ContractDate.Decode(pointer, current, out current);
            message.AppendInt(ContractDate.FixTag, contractDate);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var settlMethod = SettlMethod.Decode(pointer, current, out current);
            message.AppendToken(SettlMethod.FixTag, settlMethod);

            var optAttribute = OptAttribute.Decode(pointer, current, out current);
            message.AppendInt(OptAttribute.FixTag, optAttribute);

            var putOrCall = PutOrCall.Decode(pointer, current, out current);
            message.AppendInt(PutOrCall.FixTag, putOrCall);

            var exerciseStyle = ExerciseStyle.Decode(pointer, current, out current);
            message.AppendInt(ExerciseStyle.FixTag, exerciseStyle);

            current += Pad7.Length;

            return FixErrorCode.None;
        }
    }
}