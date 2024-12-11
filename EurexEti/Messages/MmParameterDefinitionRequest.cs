using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mm Parameter Definition Request Message Methods
    /// </summary>

    public static partial class MmParameterDefinitionRequest
    {
        /// <summary>
        ///  Eti Identifier for Mm Parameter Definition Request
        /// </summary>
        public const string Identifier = "10303";

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

            if (message.TryGetLong(ExposureDuration.FixTag, out var exposureDuration))
            {
                ExposureDuration.Encode(pointer, current, exposureDuration, out current);
            }
            else
            {
                ExposureDuration.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(CumQty.FixTag, out var cumQty))
            {
                CumQty.Encode(pointer, current, cumQty, out current);
            }
            else
            {
                CumQty.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(Delta.FixTag, out var delta))
            {
                Delta.Encode(pointer, current, delta, out current);
            }
            else
            {
                Delta.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(Vega.FixTag, out var vega))
            {
                Vega.Encode(pointer, current, vega, out current);
            }
            else
            {
                Vega.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MmRiskLimitActionType.FixTag, out var mmRiskLimitActionType))
            {
                MmRiskLimitActionType.Encode(pointer, current, (byte)mmRiskLimitActionType, out current);
            }
            else
            {
                MmRiskLimitActionType.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TargetPartyIdSessionId.FixTag, out var targetPartyIdSessionId))
            {
                TargetPartyIdSessionId.Encode(pointer, current, (uint)targetPartyIdSessionId, out current);
            }
            else
            {
                TargetPartyIdSessionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PctCount.FixTag, out var pctCount))
            {
                PctCount.Encode(pointer, current, pctCount, out current);
            }
            else
            {
                PctCount.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (ExposureDuration.TryDecode(pointer, current, out var exposureDuration, out current))
            {
                message.AppendLong(ExposureDuration.FixTag, exposureDuration);
            }

            if (CumQty.TryDecode(pointer, current, out var cumQty, out current))
            {
                message.AppendDouble(CumQty.FixTag, cumQty);
            }

            if (Delta.TryDecode(pointer, current, out var delta, out current))
            {
                message.AppendDouble(Delta.FixTag, delta);
            }

            if (Vega.TryDecode(pointer, current, out var vega, out current))
            {
                message.AppendDouble(Vega.FixTag, vega);
            }

            if (MmRiskLimitActionType.TryDecode(pointer, current, out var mmRiskLimitActionType, out current))
            {
                message.AppendInt(MmRiskLimitActionType.FixTag, mmRiskLimitActionType);
            }

            current += Pad3.Length;

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (TargetPartyIdSessionId.TryDecode(pointer, current, out var targetPartyIdSessionId, out current))
            {
                message.AppendInt(TargetPartyIdSessionId.FixTag, (int)targetPartyIdSessionId);
            }

            if (PctCount.TryDecode(pointer, current, out var pctCount, out current))
            {
                message.AppendInt(PctCount.FixTag, pctCount);
            }

            return FixErrorCode.None;
        }
    }
}