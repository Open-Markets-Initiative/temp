using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Inquire Mm Parameter Response Message Methods
    /// </summary>

    public partial class InquireMmParameterResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire Mm Parameter Response
        /// </summary>
        public const string Identifier = "Inquire Mm Parameter Response";

        /// <summary>
        ///  Encode Inquire Mm Parameter Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireMmParameterResponse, out current);

            // --- encode inquire mm parameter response message ---

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

            var mmParameterReportId = message.GetULong(MmParameterReportId.FixTag);
            MmParameterReportId.Encode(pointer, current, mmParameterReportId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var noMmParameters = (byte)message.GetInt(NoMmParameters.FixTag);
            NoMmParameters.Encode(pointer, current, noMmParameters, out current);

            Pad3.Encode(pointer, current, out current);

            var exposureDuration = group.GetLong(ExposureDuration.FixTag);
            ExposureDuration.Encode(pointer, current, exposureDuration, out current);

            var cumQty = group.GetDouble(CumQty.FixTag);
            CumQty.Encode(pointer, current, cumQty, out current);

            var delta = group.GetDouble(Delta.FixTag);
            Delta.Encode(pointer, current, delta, out current);

            var vega = group.GetDouble(Vega.FixTag);
            Vega.Encode(pointer, current, vega, out current);

            var pctCount = group.GetInt(PctCount.FixTag);
            PctCount.Encode(pointer, current, pctCount, out current);

            var targetPartyIdSessionId = (uint)group.GetInt(TargetPartyIdSessionId.FixTag);
            TargetPartyIdSessionId.Encode(pointer, current, targetPartyIdSessionId, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Inquire Mm Parameter Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireMmParameterResponse.Identifier;

            // --- decode inquire mm parameter response message ---

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

            var mmParameterReportId = MmParameterReportId.Decode(pointer, current, out current);
            message.AppendULong(MmParameterReportId.FixTag, mmParameterReportId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noMmParameters = NoMmParameters.Decode(pointer, current, out current);
            message.AppendInt(NoMmParameters.FixTag, noMmParameters);

            current += Pad3.Length;

            var exposureDuration = ExposureDuration.Decode(pointer, current, out current);
            message.AppendLong(ExposureDuration.FixTag, exposureDuration);

            var cumQty = CumQty.Decode(pointer, current, out current);
            message.AppendDouble(CumQty.FixTag, cumQty);

            var delta = Delta.Decode(pointer, current, out current);
            message.AppendDouble(Delta.FixTag, delta);

            var vega = Vega.Decode(pointer, current, out current);
            message.AppendDouble(Vega.FixTag, vega);

            var pctCount = PctCount.Decode(pointer, current, out current);
            message.AppendInt(PctCount.FixTag, pctCount);

            var targetPartyIdSessionId = (int)TargetPartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdSessionId.FixTag, targetPartyIdSessionId);

            return FixErrorCode.None;
        }
    }
}