using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Add Flexible Instrument Request Message Methods
    /// </summary>

    public partial class AddFlexibleInstrumentRequest
    {
        /// <summary>
        ///  Eti Identifier for Add Flexible Instrument Request
        /// </summary>
        public const string Identifier = "Add Flexible Instrument Request";

        /// <summary>
        ///  Encode Add Flexible Instrument Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.AddFlexibleInstrumentRequest, out current);

            // --- encode add flexible instrument request message ---

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

            var strikePrice = message.GetDouble(StrikePrice.FixTag);
            StrikePrice.Encode(pointer, current, strikePrice, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var maturityDate = (uint)message.GetInt(MaturityDate.FixTag);
            MaturityDate.Encode(pointer, current, maturityDate, out current);

            var contractDate = (uint)message.GetInt(ContractDate.FixTag);
            ContractDate.Encode(pointer, current, contractDate, out current);

            var settlMethod = message.GetToken(SettlMethod.FixTag);
            SettlMethod.Encode(pointer, current, settlMethod, out current);

            var optAttribute = (byte)message.GetInt(OptAttribute.FixTag);
            OptAttribute.Encode(pointer, current, optAttribute, out current);

            var putOrCall = (byte)message.GetInt(PutOrCall.FixTag);
            PutOrCall.Encode(pointer, current, putOrCall, out current);

            var exerciseStyle = (byte)message.GetInt(ExerciseStyle.FixTag);
            ExerciseStyle.Encode(pointer, current, exerciseStyle, out current);

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Add Flexible Instrument Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = AddFlexibleInstrumentRequest.Identifier;

            // --- decode add flexible instrument request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var strikePrice = StrikePrice.Decode(pointer, current, out current);
            message.AppendDouble(StrikePrice.FixTag, strikePrice);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var maturityDate = (int)MaturityDate.Decode(pointer, current, out current);
            message.AppendInt(MaturityDate.FixTag, maturityDate);

            var contractDate = (int)ContractDate.Decode(pointer, current, out current);
            message.AppendInt(ContractDate.FixTag, contractDate);

            var settlMethod = SettlMethod.Decode(pointer, current, out current);
            message.AppendToken(SettlMethod.FixTag, settlMethod);

            var optAttribute = OptAttribute.Decode(pointer, current, out current);
            message.AppendInt(OptAttribute.FixTag, optAttribute);

            var putOrCall = PutOrCall.Decode(pointer, current, out current);
            message.AppendInt(PutOrCall.FixTag, putOrCall);

            var exerciseStyle = ExerciseStyle.Decode(pointer, current, out current);
            message.AppendInt(ExerciseStyle.FixTag, exerciseStyle);

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}