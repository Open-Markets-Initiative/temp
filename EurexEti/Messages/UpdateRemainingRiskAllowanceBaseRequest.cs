using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Update Remaining Risk Allowance Base Request Message Methods
    /// </summary>

    public partial class UpdateRemainingRiskAllowanceBaseRequest
    {
        /// <summary>
        ///  Eti Identifier for Update Remaining Risk Allowance Base Request
        /// </summary>
        public const string Identifier = "Update Remaining Risk Allowance Base Request";

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

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var noPartyRiskLimits = (ushort)message.GetInt(NoPartyRiskLimits.FixTag);
            NoPartyRiskLimits.Encode(pointer, current, noPartyRiskLimits, out current);

            Pad4.Encode(pointer, current, out current);

            var remainingRiskAllowanceBaseLong = group.GetDouble(RemainingRiskAllowanceBaseLong.FixTag);
            RemainingRiskAllowanceBaseLong.Encode(pointer, current, remainingRiskAllowanceBaseLong, out current);

            var remainingRiskAllowanceBaseShort = group.GetDouble(RemainingRiskAllowanceBaseShort.FixTag);
            RemainingRiskAllowanceBaseShort.Encode(pointer, current, remainingRiskAllowanceBaseShort, out current);

            var riskLimitId = (uint)group.GetInt(RiskLimitId.FixTag);
            RiskLimitId.Encode(pointer, current, riskLimitId, out current);

            if (group.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
            {
                PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
            }
            else
            {
                PartyDetailExecutingUnit.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
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

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var noPartyRiskLimits = (short)NoPartyRiskLimits.Decode(pointer, current, out current);
            message.AppendInt(NoPartyRiskLimits.FixTag, noPartyRiskLimits);

            current += Pad4.Length;

            var remainingRiskAllowanceBaseLong = RemainingRiskAllowanceBaseLong.Decode(pointer, current, out current);
            message.AppendDouble(RemainingRiskAllowanceBaseLong.FixTag, remainingRiskAllowanceBaseLong);

            var remainingRiskAllowanceBaseShort = RemainingRiskAllowanceBaseShort.Decode(pointer, current, out current);
            message.AppendDouble(RemainingRiskAllowanceBaseShort.FixTag, remainingRiskAllowanceBaseShort);

            var riskLimitId = (int)RiskLimitId.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitId.FixTag, riskLimitId);

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad7.Length;

            return FixErrorCode.None;
        }
    }
}