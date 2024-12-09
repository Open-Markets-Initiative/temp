using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Inquire User Response Message Methods
    /// </summary>

    public partial class InquireUserResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire User Response
        /// </summary>
        public const string Identifier = "10039";

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

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var lastEntityProcessed = message.GetData(LastEntityProcessed.FixTag);
            LastEntityProcessed.Encode(pointer, current, lastEntityProcessed, out current);

            var isPartyDetailsGrpComp = message.TryGetGroup(NoPartyDetails.FixTag, out var partyDetailsGrpComp) && partyDetailsGrpComp.sectionList.Count > 0;
            if (isPartyDetailsGrpComp)
            {
                var noPartyDetails = (ushort)partyDetailsGrpComp.sectionList.Count;
                NoPartyDetails.Encode(pointer, current, noPartyDetails, out current);
            }
            else
            {
                NoPartyDetails.Zero(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            if (isPartyDetailsGrpComp)
            {
                PartyDetailsGrpComp.Encode(pointer, current, partyDetailsGrpComp, out current);
            }

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
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            current += Pad4.Length;

            var lastEntityProcessed = LastEntityProcessed.Decode(pointer, current, out current);
            message.AppendData(LastEntityProcessed.FixTag, lastEntityProcessed);

            var noPartyDetails = (int)NoPartyDetails.Decode(pointer, current, out current);

            current += Pad6.Length;

            PartyDetailsGrpComp.Decode(ref message, pointer, current, noPartyDetails, out current);

            return FixErrorCode.None;
        }
    }
}