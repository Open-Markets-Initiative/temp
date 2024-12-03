using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Inquire Margin Based Risk Limit Response Message Methods
    /// </summary>

    public partial class InquireMarginBasedRiskLimitResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire Margin Based Risk Limit Response
        /// </summary>
        public const string Identifier = "Inquire Margin Based Risk Limit Response";

        /// <summary>
        ///  Encode Inquire Margin Based Risk Limit Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireMarginBasedRiskLimitResponse, out current);

            // --- encode inquire margin based risk limit response message ---

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

            var marginBasedRiskLimitLong = message.GetDouble(MarginBasedRiskLimitLong.FixTag);
            MarginBasedRiskLimitLong.Encode(pointer, current, marginBasedRiskLimitLong, out current);

            var marginBasedRiskLimitShort = message.GetDouble(MarginBasedRiskLimitShort.FixTag);
            MarginBasedRiskLimitShort.Encode(pointer, current, marginBasedRiskLimitShort, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Inquire Margin Based Risk Limit Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireMarginBasedRiskLimitResponse.Identifier;

            // --- decode inquire margin based risk limit response message ---

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

            var marginBasedRiskLimitLong = MarginBasedRiskLimitLong.Decode(pointer, current, out current);
            message.AppendDouble(MarginBasedRiskLimitLong.FixTag, marginBasedRiskLimitLong);

            var marginBasedRiskLimitShort = MarginBasedRiskLimitShort.Decode(pointer, current, out current);
            message.AppendDouble(MarginBasedRiskLimitShort.FixTag, marginBasedRiskLimitShort);

            return FixErrorCode.None;
        }
    }
}