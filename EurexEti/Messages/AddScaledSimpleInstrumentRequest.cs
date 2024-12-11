using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Add Scaled Simple Instrument Request Message Methods
    /// </summary>

    public static partial class AddScaledSimpleInstrumentRequest
    {
        /// <summary>
        ///  Eti Identifier for Add Scaled Simple Instrument Request
        /// </summary>
        public const string Identifier = "10327";

        /// <summary>
        ///  Encode Add Scaled Simple Instrument Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.AddScaledSimpleInstrumentRequest, out current);

            // --- encode add scaled simple instrument request message ---

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

            if (message.TryGetLong(RelatedSecurityId.FixTag, out var relatedSecurityId))
            {
                RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);
            }
            else
            {
                RelatedSecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
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

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Add Scaled Simple Instrument Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = AddScaledSimpleInstrumentRequest.Identifier;

            // --- decode add scaled simple instrument request message ---

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

            if (RelatedSecurityId.TryDecode(pointer, current, out var relatedSecurityId, out current))
            {
                message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (QuantityScalingFactor.TryDecode(pointer, current, out var quantityScalingFactor, out current))
            {
                message.AppendInt(QuantityScalingFactor.FixTag, (short)quantityScalingFactor);
            }

            if (MultilegModel.TryDecode(pointer, current, out var multilegModel, out current))
            {
                message.AppendInt(MultilegModel.FixTag, multilegModel);
            }

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}