using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delete All Quote Response Message Methods
    /// </summary>

    public partial class DeleteAllQuoteResponse
    {
        /// <summary>
        ///  Eti Identifier for Delete All Quote Response
        /// </summary>
        public const string Identifier = "10409";

        /// <summary>
        ///  Encode Delete All Quote Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.DeleteAllQuoteResponse, out current);

            // --- encode delete all quote response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var massActionReportId = message.GetULong(MassActionReportId.FixTag);
            MassActionReportId.Encode(pointer, current, massActionReportId, out current);

            var isNotAffectedSecuritiesGrpComp = message.TryGetGroup(NoNotAffectedSecurities.FixTag, out var notAffectedSecuritiesGrpComp) && NotAffectedSecuritiesGrpComp.sectionList.Length > 0;
            if (isNotAffectedSecuritiesGrpComp)
            {
                var noNotAffectedSecurities = (ushort)notAffectedSecuritiesGrpComp.sectionList.Length;
                NoNotAffectedSecurities.Encode(pointer, current, noNotAffectedSecurities, out current);
            }
            else
            {
                NoNotAffectedSecurities.Zero(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            if (isNotAffectedSecuritiesGrpComp)
            {
                NotAffectedSecuritiesGrpComp.Encode(pointer, current, notAffectedSecuritiesGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Delete All Quote Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = DeleteAllQuoteResponse.Identifier;

            // --- decode delete all quote response message ---

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
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var massActionReportId = MassActionReportId.Decode(pointer, current, out current);
            message.AppendULong(MassActionReportId.FixTag, massActionReportId);

            var noNotAffectedSecurities = (int)NoNotAffectedSecurities.Decode(pointer, current, out current);

            current += Pad6.Length;

            NotAffectedSecuritiesGrpComp.Decode(ref message, pointer, current, noNotAffectedSecurities, out current);

            return FixErrorCode.None;
        }
    }
}