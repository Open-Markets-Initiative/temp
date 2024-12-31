using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Retransmit Response Message Methods
    /// </summary>

    public static partial class RetransmitResponse
    {
        /// <summary>
        ///  Eti Identifier for Retransmit Response
        /// </summary>
        public const string Identifier = "10009";

        /// <summary>
        ///  Encode Retransmit Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.RetransmitResponse, out current);

            // --- encode retransmit response message ---

            Pad2.Encode(pointer, current, out current);

            if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
            {
                RequestTime.Encode(pointer, current, requestTime, out current);
            }
            else
            {
                RequestTime.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            if (message.TryGetULong(ApplEndSeqNum.FixTag, out var applEndSeqNum))
            {
                ApplEndSeqNum.Encode(pointer, current, applEndSeqNum, out current);
            }
            else
            {
                ApplEndSeqNum.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(RefApplLastSeqNum.FixTag, out var refApplLastSeqNum))
            {
                RefApplLastSeqNum.Encode(pointer, current, refApplLastSeqNum, out current);
            }
            else
            {
                RefApplLastSeqNum.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplTotalMessageCount.FixTag, out var applTotalMessageCount))
            {
                ApplTotalMessageCount.Encode(pointer, current, (ushort)applTotalMessageCount, out current);
            }
            else
            {
                ApplTotalMessageCount.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Retransmit Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = RetransmitResponse.Identifier;

            // --- decode retransmit response message ---

            current += Pad2.Length;

            if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
            {
                message.AppendULong(RequestTime.FixTag, requestTime);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            current += Pad4.Length;

            if (ApplEndSeqNum.TryDecode(pointer, current, out var applEndSeqNum, out current))
            {
                message.AppendULong(ApplEndSeqNum.FixTag, applEndSeqNum);
            }

            if (RefApplLastSeqNum.TryDecode(pointer, current, out var refApplLastSeqNum, out current))
            {
                message.AppendULong(RefApplLastSeqNum.FixTag, refApplLastSeqNum);
            }

            if (ApplTotalMessageCount.TryDecode(pointer, current, out var applTotalMessageCount, out current))
            {
                message.AppendInt(ApplTotalMessageCount.FixTag, (short)applTotalMessageCount);
            }

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}