using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Clip Response Message Methods
    /// </summary>

    public partial class ClipResponse
    {
        /// <summary>
        ///  Eti Identifier for Clip Response
        /// </summary>
        public const string Identifier = "10133";

        /// <summary>
        ///  Encode Clip Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ClipResponse, out current);

            // --- encode clip response message ---

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

            var execId = message.GetULong(ExecId.FixTag);
            ExecId.Encode(pointer, current, execId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var crossRequestId = message.GetInt(CrossRequestId.FixTag);
            CrossRequestId.Encode(pointer, current, crossRequestId, out current);

            var noSides = (byte)message.GetInt(NoSides.FixTag);
            NoSides.Encode(pointer, current, noSides, out current);

            var impliedCheckPriceIndicator = (byte)message.GetInt(ImpliedCheckPriceIndicator.FixTag);
            ImpliedCheckPriceIndicator.Encode(pointer, current, impliedCheckPriceIndicator, out current);

            Pad6.Encode(pointer, current, out current);

            var crossRequestAckSideGrpComp = (byte)message.GetInt(CrossRequestAckSideGrpComp.FixTag);
            CrossRequestAckSideGrpComp.Encode(message, pointer, current, crossRequestAckSideGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Clip Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ClipResponse.Identifier;

            // --- decode clip response message ---

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

            var execId = ExecId.Decode(pointer, current, out current);
            message.AppendULong(ExecId.FixTag, execId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var crossRequestId = CrossRequestId.Decode(pointer, current, out current);
            message.AppendInt(CrossRequestId.FixTag, crossRequestId);

            var noSides = NoSides.Decode(pointer, current, out current);
            message.AppendInt(NoSides.FixTag, noSides);

            var impliedCheckPriceIndicator = ImpliedCheckPriceIndicator.Decode(pointer, current, out current);
            message.AppendInt(ImpliedCheckPriceIndicator.FixTag, impliedCheckPriceIndicator);

            current += Pad6.Length;

            CrossRequestAckSideGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}