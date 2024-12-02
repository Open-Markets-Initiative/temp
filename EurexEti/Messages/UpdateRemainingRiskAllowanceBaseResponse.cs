using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Update Remaining Risk Allowance Base Response Message Methods
    /// </summary>

    public partial class UpdateRemainingRiskAllowanceBaseResponse
    {
        /// <summary>
        ///  Eti Identifier for Update Remaining Risk Allowance Base Response
        /// </summary>
        public const string Identifier = "Update Remaining Risk Allowance Base Response";

        /// <summary>
        ///  Encode Update Remaining Risk Allowance Base Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UpdateRemainingRiskAllowanceBaseResponse, out current);

            // --- encode update remaining risk allowance base response message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var noPartyRiskLimits = (ushort)message.GetInt(NoPartyRiskLimits.FixTag);
            NoPartyRiskLimits.Encode(pointer, current, noPartyRiskLimits, out current);

            Pad6.Encode(pointer, current, out current);

            if (group.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
            {
                PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
            }
            else
            {
                PartyDetailExecutingUnit.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            var riskLimitResult = (ushort)group.GetInt(RiskLimitResult.FixTag);
            RiskLimitResult.Encode(pointer, current, riskLimitResult, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Update Remaining Risk Allowance Base Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UpdateRemainingRiskAllowanceBaseResponse.Identifier;

            // --- decode update remaining risk allowance base response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var trdRegTsTimeIn = TrdRegTsTimeIn.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var responseIn = ResponseIn.Decode(pointer, current, out current);
            message.AppendULong(ResponseIn.FixTag, responseIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var noPartyRiskLimits = (short)NoPartyRiskLimits.Decode(pointer, current, out current);
            message.AppendInt(NoPartyRiskLimits.FixTag, noPartyRiskLimits);

            current += Pad6.Length;

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad1.Length;

            var riskLimitResult = (short)RiskLimitResult.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitResult.FixTag, riskLimitResult);

            return FixErrorCode.None;
        }
    }
}