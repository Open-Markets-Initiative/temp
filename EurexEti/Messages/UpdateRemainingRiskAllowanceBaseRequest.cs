using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Update Remaining Risk Allowance Base Request Message Methods
    /// </summary>

    public static partial class UpdateRemainingRiskAllowanceBaseRequest
    {
        /// <summary>
        ///  Eti Identifier for Update Remaining Risk Allowance Base Request
        /// </summary>
        public const string Identifier = "10325";

        /// <summary>
        ///  Encode Update Remaining Risk Allowance Base Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UpdateRemainingRiskAllowanceBaseRequest, out current);

            // --- encode update remaining risk allowance base request message ---

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

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var isRraUpdateBasePartyGrpComp = message.TryGetGroup(NoPartyRiskLimits.FixTag, out var rraUpdateBasePartyGrpComp) && rraUpdateBasePartyGrpComp.sectionList.Count > 0;
            if (isRraUpdateBasePartyGrpComp)
            {
                var noPartyRiskLimits = (ushort)rraUpdateBasePartyGrpComp.sectionList.Count;
                NoPartyRiskLimits.Encode(pointer, current, noPartyRiskLimits, out current);
            }
            else
            {
                NoPartyRiskLimits.Zero(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            if (isRraUpdateBasePartyGrpComp)
            {
                RraUpdateBasePartyGrpComp.Encode(pointer, current, rraUpdateBasePartyGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Update Remaining Risk Allowance Base Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UpdateRemainingRiskAllowanceBaseRequest.Identifier;

            // --- decode update remaining risk allowance base request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var noPartyRiskLimits = (int)NoPartyRiskLimits.Decode(pointer, current, out current);

            current += Pad4.Length;

            RraUpdateBasePartyGrpComp.Decode(ref message, pointer, current, noPartyRiskLimits, out current);

            return FixErrorCode.None;
        }
    }
}