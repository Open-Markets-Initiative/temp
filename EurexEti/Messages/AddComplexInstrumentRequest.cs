using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Add Complex Instrument Request Message Methods
    /// </summary>

    public static partial class AddComplexInstrumentRequest
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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(MultilegModel.FixTag, out var multilegModel))
            {
                MultilegModel.Encode(pointer, current, (byte)multilegModel, out current);
            }
            else
            {
                MultilegModel.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (isInstrmtLegGrpComp)
            {
                InstrmtLegGrpComp.Encode(pointer, current, instrmtLegGrpComp, out current);
            }

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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (SecuritySubType.TryDecode(pointer, current, out var securitySubType, out current))
            {
                message.AppendInt(SecuritySubType.FixTag, securitySubType);
            }

            if (QuantityScalingFactor.TryDecode(pointer, current, out var quantityScalingFactor, out current))
            {
                message.AppendInt(QuantityScalingFactor.FixTag, (short)quantityScalingFactor);
            }

            if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
            {
                message.AppendInt(ProductComplex.FixTag, productComplex);
            }

            var noLegOnbooks = (int)NoLegOnbooks.Decode(pointer, current, out current);

            if (MultilegModel.TryDecode(pointer, current, out var multilegModel, out current))
            {
                message.AppendInt(MultilegModel.FixTag, multilegModel);
            }

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad7.Length;

            InstrmtLegGrpComp.Decode(ref message, pointer, current, noLegOnbooks, out current);

            return FixErrorCode.None;
        }
    }
}