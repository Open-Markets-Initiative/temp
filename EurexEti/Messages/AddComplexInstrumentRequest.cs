using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Add Complex Instrument Request Message Methods
    /// </summary>

    public partial class AddComplexInstrumentRequest
    {
        /// <summary>
        ///  Eti Identifier for Add Complex Instrument Request
        /// </summary>
        public const string Identifier = "10301";

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

            var senderSubId = uint.Parse(message.sendersubid);
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

            var instrmtLegGrpComp = (byte)message.GetInt(InstrmtLegGrpComp.FixTag);
            InstrmtLegGrpComp.Encode(message, pointer, current, instrmtLegGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubId = senderSubId.ToString();

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

            InstrmtLegGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}