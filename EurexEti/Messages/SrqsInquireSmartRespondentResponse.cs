using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Srqs Inquire Smart Respondent Response Message Methods
    /// </summary>

    public partial class SrqsInquireSmartRespondentResponse
    {
        /// <summary>
        ///  Eti Identifier for Srqs Inquire Smart Respondent Response
        /// </summary>
        public const string Identifier = "Srqs Inquire Smart Respondent Response";

        /// <summary>
        ///  Encode Srqs Inquire Smart Respondent Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsInquireSmartRespondentResponse, out current);

            // --- encode srqs inquire smart respondent response message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var noPartyDetails = (ushort)message.GetInt(NoPartyDetails.FixTag);
            NoPartyDetails.Encode(pointer, current, noPartyDetails, out current);

            Pad2.Encode(pointer, current, out current);

            if (group.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
            {
                PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
            }
            else
            {
                PartyDetailExecutingUnit.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyDetailExecutingTrader.FixTag, out var partyDetailExecutingTrader))
            {
                PartyDetailExecutingTrader.Encode(pointer, current, partyDetailExecutingTrader, out current);
            }
            else
            {
                PartyDetailExecutingTrader.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Srqs Inquire Smart Respondent Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsInquireSmartRespondentResponse.Identifier;

            // --- decode srqs inquire smart respondent response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noPartyDetails = (short)NoPartyDetails.Decode(pointer, current, out current);
            message.AppendInt(NoPartyDetails.FixTag, noPartyDetails);

            current += Pad2.Length;

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            if (PartyDetailExecutingTrader.TryDecode(pointer, current, out var partyDetailExecutingTrader, out current))
            {
                message.AppendString(PartyDetailExecutingTrader.FixTag, partyDetailExecutingTrader);
            }

            current += Pad5.Length;

            return FixErrorCode.None;
        }
    }
}