using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Add Flexible Instrument Request Message Methods
    /// </summary>

    public static partial class AddFlexibleInstrumentRequest
    {
        /// <summary>
        ///  Eti Identifier for Add Flexible Instrument Request
        /// </summary>
        public const string Identifier = "10309";

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

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            if (message.TryGetDouble(StrikePrice.FixTag, out var strikePrice))
            {
                StrikePrice.Encode(pointer, current, strikePrice, out current);
            }
            else
            {
                StrikePrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MaturityDate.FixTag, out var maturityDate))
            {
                MaturityDate.Encode(pointer, current, (uint)maturityDate, out current);
            }
            else
            {
                MaturityDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ContractDate.FixTag, out var contractDate))
            {
                ContractDate.Encode(pointer, current, (uint)contractDate, out current);
            }
            else
            {
                ContractDate.SetNull(pointer, current, out current);
            }

            var settlMethod = message.GetToken(SettlMethod.FixTag);
            SettlMethod.Encode(pointer, current, settlMethod, out current);

            if (message.TryGetInt(OptAttribute.FixTag, out var optAttribute))
            {
                OptAttribute.Encode(pointer, current, (byte)optAttribute, out current);
            }
            else
            {
                OptAttribute.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PutOrCall.FixTag, out var putOrCall))
            {
                PutOrCall.Encode(pointer, current, (byte)putOrCall, out current);
            }
            else
            {
                PutOrCall.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ExerciseStyle.FixTag, out var exerciseStyle))
            {
                ExerciseStyle.Encode(pointer, current, (byte)exerciseStyle, out current);
            }
            else
            {
                ExerciseStyle.SetNull(pointer, current, out current);
            }

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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (StrikePrice.TryDecode(pointer, current, out var strikePrice, out current))
            {
                message.AppendDouble(StrikePrice.FixTag, strikePrice);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (MaturityDate.TryDecode(pointer, current, out var maturityDate, out current))
            {
                message.AppendInt(MaturityDate.FixTag, (int)maturityDate);
            }

            if (ContractDate.TryDecode(pointer, current, out var contractDate, out current))
            {
                message.AppendInt(ContractDate.FixTag, (int)contractDate);
            }

            var settlMethod = SettlMethod.Decode(pointer, current, out current);
            message.AppendToken(SettlMethod.FixTag, settlMethod);

            if (OptAttribute.TryDecode(pointer, current, out var optAttribute, out current))
            {
                message.AppendInt(OptAttribute.FixTag, optAttribute);
            }

            if (PutOrCall.TryDecode(pointer, current, out var putOrCall, out current))
            {
                message.AppendInt(PutOrCall.FixTag, putOrCall);
            }

            if (ExerciseStyle.TryDecode(pointer, current, out var exerciseStyle, out current))
            {
                message.AppendInt(ExerciseStyle.FixTag, exerciseStyle);
            }

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}