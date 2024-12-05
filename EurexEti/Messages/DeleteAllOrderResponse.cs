using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delete All Order Response Message Methods
    /// </summary>

    public partial class DeleteAllOrderResponse
    {
        /// <summary>
        ///  Eti Identifier for Delete All Order Response
        /// </summary>
        public const string Identifier = "10121";

        /// <summary>
        ///  Encode Delete All Order Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.DeleteAllOrderResponse, out current);

            // --- encode delete all order response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            var massActionReportId = message.GetULong(MassActionReportId.FixTag);
            MassActionReportId.Encode(pointer, current, massActionReportId, out current);

            var noNotAffectedOrders = (ushort)message.GetInt(NoNotAffectedOrders.FixTag);
            NoNotAffectedOrders.Encode(pointer, current, noNotAffectedOrders, out current);

            var noAffectedOrderRequests = (ushort)message.GetInt(NoAffectedOrderRequests.FixTag);
            NoAffectedOrderRequests.Encode(pointer, current, noAffectedOrderRequests, out current);

            Pad4.Encode(pointer, current, out current);

            if (isNotAffectedOrdersGrpComp)
            {
                message.Encode(pointer, current, notAffectedOrdersGrpComp, out current);
            }

            if (isAffectedOrderRequestsGrpComp)
            {
                message.Encode(pointer, current, affectedOrderRequestsGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Delete All Order Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = DeleteAllOrderResponse.Identifier;

            // --- decode delete all order response message ---

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
            message.sendingTime = new DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            var massActionReportId = MassActionReportId.Decode(pointer, current, out current);
            message.AppendULong(MassActionReportId.FixTag, massActionReportId);

            var noNotAffectedOrders = (short)NoNotAffectedOrders.Decode(pointer, current, out current);
            message.AppendInt(NoNotAffectedOrders.FixTag, noNotAffectedOrders);

            var noAffectedOrderRequests = (short)NoAffectedOrderRequests.Decode(pointer, current, out current);
            message.AppendInt(NoAffectedOrderRequests.FixTag, noAffectedOrderRequests);

            current += Pad4.Length;

            NotAffectedOrdersGrpComp.Decode(ref message, pointer, current, out current);

            AffectedOrderRequestsGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}