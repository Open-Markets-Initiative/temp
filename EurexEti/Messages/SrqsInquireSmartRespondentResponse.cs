using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Inquire Smart Respondent Response Message Methods
    /// </summary>

    public partial class SrqsInquireSmartRespondentResponse
    {
        /// <summary>
        ///  Eti Identifier for Srqs Inquire Smart Respondent Response
        /// </summary>
        public const string Identifier = "10719";

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

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var noPartyDetails = (ushort)message.GetInt(NoPartyDetails.FixTag);
            NoPartyDetails.Encode(pointer, current, noPartyDetails, out current);

            Pad2.Encode(pointer, current, out current);

            var smartPartyDetailGrpComp = (byte)message.GetInt(SmartPartyDetailGrpComp.FixTag);
            SmartPartyDetailGrpComp.Encode(message, pointer, current, smartPartyDetailGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            current += Pad4.Length;

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noPartyDetails = (short)NoPartyDetails.Decode(pointer, current, out current);
            message.AppendInt(NoPartyDetails.FixTag, noPartyDetails);

            current += Pad2.Length;

            SmartPartyDetailGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}