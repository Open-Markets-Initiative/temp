using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Delete All Quote Request Message Methods
    /// </summary>

    public partial class DeleteAllQuoteRequest
    {
        /// <summary>
        ///  Eti Identifier for Delete All Quote Request
        /// </summary>
        public const string Identifier = "Delete All Quote Request";

        /// <summary>
        ///  Encode Delete All Quote Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.DeleteAllQuoteRequest, out current);

            // --- encode delete all quote request message ---

            var start = current;

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = (uint)message.GetInt(SenderSubId.FixTag);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var partyIdInvestmentDecisionMaker = message.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var executingTrader = message.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var targetPartyIdSessionId = (uint)message.GetInt(TargetPartyIdSessionId.FixTag);
            TargetPartyIdSessionId.Encode(pointer, current, targetPartyIdSessionId, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)message.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            var executingTraderQualifier = (byte)message.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Delete All Quote Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = DeleteAllQuoteRequest.Identifier;

            // --- decode delete all quote request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var targetPartyIdSessionId = (int)TargetPartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdSessionId.FixTag, targetPartyIdSessionId);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}