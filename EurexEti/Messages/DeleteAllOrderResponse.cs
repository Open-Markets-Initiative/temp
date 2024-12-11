using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delete All Order Response Message Methods
    /// </summary>

    public static partial class DeleteAllOrderResponse
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

            if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(MassActionReportId.FixTag, out var massActionReportId))
            {
                MassActionReportId.Encode(pointer, current, massActionReportId, out current);
            }
            else
            {
                MassActionReportId.SetNull(pointer, current, out current);
            }

            var isNotAffectedOrdersGrpComp = message.TryGetGroup(NoNotAffectedOrders.FixTag, out var notAffectedOrdersGrpComp) && notAffectedOrdersGrpComp.sectionList.Count > 0;
            if (isNotAffectedOrdersGrpComp)
            {
                var noNotAffectedOrders = (ushort)notAffectedOrdersGrpComp.sectionList.Count;
                NoNotAffectedOrders.Encode(pointer, current, noNotAffectedOrders, out current);
            }
            else
            {
                NoNotAffectedOrders.Zero(pointer, current, out current);
            }

            var isAffectedOrderRequestsGrpComp = message.TryGetGroup(NoAffectedOrderRequests.FixTag, out var affectedOrderRequestsGrpComp) && affectedOrderRequestsGrpComp.sectionList.Count > 0;
            if (isAffectedOrderRequestsGrpComp)
            {
                var noAffectedOrderRequests = (ushort)affectedOrderRequestsGrpComp.sectionList.Count;
                NoAffectedOrderRequests.Encode(pointer, current, noAffectedOrderRequests, out current);
            }
            else
            {
                NoAffectedOrderRequests.Zero(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            if (isNotAffectedOrdersGrpComp)
            {
                NotAffectedOrdersGrpComp.Encode(pointer, current, notAffectedOrdersGrpComp, out current);
            }

            if (isAffectedOrderRequestsGrpComp)
            {
                AffectedOrderRequestsGrpComp.Encode(pointer, current, affectedOrderRequestsGrpComp, out current);
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

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            if (MassActionReportId.TryDecode(pointer, current, out var massActionReportId, out current))
            {
                message.AppendULong(MassActionReportId.FixTag, massActionReportId);
            }

            var noNotAffectedOrders = (int)NoNotAffectedOrders.Decode(pointer, current, out current);

            var noAffectedOrderRequests = (int)NoAffectedOrderRequests.Decode(pointer, current, out current);

            current += Pad4.Length;

            NotAffectedOrdersGrpComp.Decode(ref message, pointer, current, noNotAffectedOrders, out current);

            AffectedOrderRequestsGrpComp.Decode(ref message, pointer, current, noAffectedOrderRequests, out current);

            return FixErrorCode.None;
        }
    }
}