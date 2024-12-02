using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mm Parameter Definition Request Message Methods
    /// </summary>

    public partial class MmParameterDefinitionRequest
    {
        /// <summary>
        ///  Eti Identifier for Mm Parameter Definition Request
        /// </summary>
        public const string Identifier = "Mm Parameter Definition Request";

        /// <summary>
        ///  Encode Mm Parameter Definition Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.MmParameterDefinitionRequest, out current);

            // --- encode mm parameter definition request message ---

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

            var exposureDuration = message.GetLong(ExposureDuration.FixTag);
            ExposureDuration.Encode(pointer, current, exposureDuration, out current);

            var cumQty = message.GetDouble(CumQty.FixTag);
            CumQty.Encode(pointer, current, cumQty, out current);

            var delta = message.GetDouble(Delta.FixTag);
            Delta.Encode(pointer, current, delta, out current);

            var vega = message.GetDouble(Vega.FixTag);
            Vega.Encode(pointer, current, vega, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var targetPartyIdSessionId = (uint)message.GetInt(TargetPartyIdSessionId.FixTag);
            TargetPartyIdSessionId.Encode(pointer, current, targetPartyIdSessionId, out current);

            var pctCount = message.GetInt(PctCount.FixTag);
            PctCount.Encode(pointer, current, pctCount, out current);

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Mm Parameter Definition Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = MmParameterDefinitionRequest.Identifier;

            // --- decode mm parameter definition request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var exposureDuration = ExposureDuration.Decode(pointer, current, out current);
            message.AppendLong(ExposureDuration.FixTag, exposureDuration);

            var cumQty = CumQty.Decode(pointer, current, out current);
            message.AppendDouble(CumQty.FixTag, cumQty);

            var delta = Delta.Decode(pointer, current, out current);
            message.AppendDouble(Delta.FixTag, delta);

            var vega = Vega.Decode(pointer, current, out current);
            message.AppendDouble(Vega.FixTag, vega);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var targetPartyIdSessionId = (int)TargetPartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdSessionId.FixTag, targetPartyIdSessionId);

            var pctCount = PctCount.Decode(pointer, current, out current);
            message.AppendInt(PctCount.FixTag, pctCount);

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}