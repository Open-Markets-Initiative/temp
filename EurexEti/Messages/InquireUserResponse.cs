using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Inquire User Response Message Methods
    /// </summary>

    public partial class InquireUserResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire User Response
        /// </summary>
        public const string Identifier = "Inquire User Response";

        /// <summary>
        ///  Encode Inquire User Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireUserResponse, out current);

            // --- encode inquire user response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var lastEntityProcessed = message.GetData(LastEntityProcessed.FixTag);
            LastEntityProcessed.Encode(pointer, current, lastEntityProcessed, out current);

            var noPartyDetails = (ushort)message.GetInt(NoPartyDetails.FixTag);
            NoPartyDetails.Encode(pointer, current, noPartyDetails, out current);

            Pad6.Encode(pointer, current, out current);

            var partyDetailIdExecutingTrader = (uint)group.GetInt(PartyDetailIdExecutingTrader.FixTag);
            PartyDetailIdExecutingTrader.Encode(pointer, current, partyDetailIdExecutingTrader, out current);

            if (group.TryGetString(PartyDetailExecutingTrader.FixTag, out var partyDetailExecutingTrader))
            {
                PartyDetailExecutingTrader.Encode(pointer, current, partyDetailExecutingTrader, out current);
            }
            else
            {
                PartyDetailExecutingTrader.SetNull(pointer, current, out current);
            }

            var partyDetailRoleQualifier = (byte)group.GetInt(PartyDetailRoleQualifier.FixTag);
            PartyDetailRoleQualifier.Encode(pointer, current, partyDetailRoleQualifier, out current);

            var partyDetailStatus = (byte)group.GetInt(PartyDetailStatus.FixTag);
            PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

            if (group.TryGetString(PartyDetailDeskId.FixTag, out var partyDetailDeskId))
            {
                PartyDetailDeskId.Encode(pointer, current, partyDetailDeskId, out current);
            }
            else
            {
                PartyDetailDeskId.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Inquire User Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireUserResponse.Identifier;

            // --- decode inquire user response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var lastEntityProcessed = LastEntityProcessed.Decode(pointer, current, out current);
            message.AppendData(LastEntityProcessed.FixTag, lastEntityProcessed);

            var noPartyDetails = (short)NoPartyDetails.Decode(pointer, current, out current);
            message.AppendInt(NoPartyDetails.FixTag, noPartyDetails);

            current += Pad6.Length;

            var partyDetailIdExecutingTrader = (int)PartyDetailIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailIdExecutingTrader.FixTag, partyDetailIdExecutingTrader);

            if (PartyDetailExecutingTrader.TryDecode(pointer, current, out var partyDetailExecutingTrader, out current))
            {
                message.AppendString(PartyDetailExecutingTrader.FixTag, partyDetailExecutingTrader);
            }

            var partyDetailRoleQualifier = PartyDetailRoleQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailRoleQualifier.FixTag, partyDetailRoleQualifier);

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            if (PartyDetailDeskId.TryDecode(pointer, current, out var partyDetailDeskId, out current))
            {
                message.AppendString(PartyDetailDeskId.FixTag, partyDetailDeskId);
            }

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}