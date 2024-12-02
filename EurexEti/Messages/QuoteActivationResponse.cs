using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Activation Response Message Methods
    /// </summary>

    public partial class QuoteActivationResponse
    {
        /// <summary>
        ///  Eti Identifier for Quote Activation Response
        /// </summary>
        public const string Identifier = "Quote Activation Response";

        /// <summary>
        ///  Encode Quote Activation Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.QuoteActivationResponse, out current);

            // --- encode quote activation response message ---

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

            var massActionReportId = message.GetULong(MassActionReportId.FixTag);
            MassActionReportId.Encode(pointer, current, massActionReportId, out current);

            var noNotAffectedSecurities = (ushort)message.GetInt(NoNotAffectedSecurities.FixTag);
            NoNotAffectedSecurities.Encode(pointer, current, noNotAffectedSecurities, out current);

            Pad6.Encode(pointer, current, out current);

            var notAffectedSecurityId = group.GetULong(NotAffectedSecurityId.FixTag);
            NotAffectedSecurityId.Encode(pointer, current, notAffectedSecurityId, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Quote Activation Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = QuoteActivationResponse.Identifier;

            // --- decode quote activation response message ---

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

            var massActionReportId = MassActionReportId.Decode(pointer, current, out current);
            message.AppendULong(MassActionReportId.FixTag, massActionReportId);

            var noNotAffectedSecurities = (short)NoNotAffectedSecurities.Decode(pointer, current, out current);
            message.AppendInt(NoNotAffectedSecurities.FixTag, noNotAffectedSecurities);

            current += Pad6.Length;

            var notAffectedSecurityId = NotAffectedSecurityId.Decode(pointer, current, out current);
            message.AppendULong(NotAffectedSecurityId.FixTag, notAffectedSecurityId);

            return FixErrorCode.None;
        }
    }
}