using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Clip Response Message Methods
    /// </summary>

    public static partial class ClipResponse
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

            if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
            {
                RequestTime.Encode(pointer, current, requestTime, out current);
            }
            else
            {
                RequestTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TrdRegTsTimeIn.FixTag, out var trdRegTsTimeIn))
            {
                TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);
            }
            else
            {
                TrdRegTsTimeIn.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
            {
                TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
            }
            else
            {
                TrdRegTsTimeOut.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ResponseIn.FixTag, out var responseIn))
            {
                ResponseIn.Encode(pointer, current, responseIn, out current);
            }
            else
            {
                ResponseIn.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            if (message.TryGetULong(ExecId.FixTag, out var execId))
            {
                ExecId.Encode(pointer, current, execId, out current);
            }
            else
            {
                ExecId.SetNull(pointer, current, out current);
            }

            if (message.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(CrossRequestId.FixTag, out var crossRequestId))
            {
                CrossRequestId.Encode(pointer, current, crossRequestId, out current);
            }
            else
            {
                CrossRequestId.SetNull(pointer, current, out current);
            }

            var isCrossRequestAckSideGrpComp = message.TryGetGroup(NoSides.FixTag, out var crossRequestAckSideGrpComp) && crossRequestAckSideGrpComp.sectionList.Count > 0;
            if (isCrossRequestAckSideGrpComp)
            {
                var noSides = (byte)crossRequestAckSideGrpComp.sectionList.Count;
                NoSides.Encode(pointer, current, noSides, out current);
            }
            else
            {
                NoSides.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(ImpliedCheckPriceIndicator.FixTag, out var impliedCheckPriceIndicator))
            {
                ImpliedCheckPriceIndicator.Encode(pointer, current, (byte)impliedCheckPriceIndicator, out current);
            }
            else
            {
                ImpliedCheckPriceIndicator.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            if (isCrossRequestAckSideGrpComp)
            {
                CrossRequestAckSideGrpComp.Encode(pointer, current, crossRequestAckSideGrpComp, out current);
            }

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

            if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
            {
                message.AppendULong(RequestTime.FixTag, requestTime);
            }

            if (TrdRegTsTimeIn.TryDecode(pointer, current, out var trdRegTsTimeIn, out current))
            {
                message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);
            }

            if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
            {
                message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
            }

            if (ResponseIn.TryDecode(pointer, current, out var responseIn, out current))
            {
                message.AppendULong(ResponseIn.FixTag, responseIn);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad3.Length;

            if (ExecId.TryDecode(pointer, current, out var execId, out current))
            {
                message.AppendULong(ExecId.FixTag, execId);
            }

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (CrossRequestId.TryDecode(pointer, current, out var crossRequestId, out current))
            {
                message.AppendInt(CrossRequestId.FixTag, crossRequestId);
            }

            var noSides = (int)NoSides.Decode(pointer, current, out current);

            if (ImpliedCheckPriceIndicator.TryDecode(pointer, current, out var impliedCheckPriceIndicator, out current))
            {
                message.AppendInt(ImpliedCheckPriceIndicator.FixTag, impliedCheckPriceIndicator);
            }

            current += Pad6.Length;

            CrossRequestAckSideGrpComp.Decode(ref message, pointer, current, noSides, out current);

            return FixErrorCode.None;
        }
    }
}