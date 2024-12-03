using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Delete Order Request Message Methods
    /// </summary>

    public partial class DeleteOrderRequest
    {
        /// <summary>
        ///  Eti Identifier for Delete Order Request
        /// </summary>
        public const string Identifier = "Delete Order Request";

        /// <summary>
        ///  Encode Delete Order Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.DeleteOrderRequest, out current);

            // --- encode delete order request message ---

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

            var orderId = message.GetULong(OrderId.FixTag);
            OrderId.Encode(pointer, current, orderId, out current);

            var clOrdId = message.GetULong(ClOrdId.FixTag);
            ClOrdId.Encode(pointer, current, clOrdId, out current);

            var origClOrdId = message.GetULong(OrigClOrdId.FixTag);
            OrigClOrdId.Encode(pointer, current, origClOrdId, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var partyIdInvestmentDecisionMaker = message.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var executingTrader = message.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var targetPartyIdSessionId = (uint)message.GetInt(TargetPartyIdSessionId.FixTag);
            TargetPartyIdSessionId.Encode(pointer, current, targetPartyIdSessionId, out current);

            var orderOrigination = (byte)message.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)message.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            var executingTraderQualifier = (byte)message.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            if (message.TryGetString(FixClOrdId.FixTag, out var fixClOrdId))
            {
                FixClOrdId.Encode(pointer, current, fixClOrdId, out current);
            }
            else
            {
                FixClOrdId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Delete Order Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = DeleteOrderRequest.Identifier;

            // --- decode delete order request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var orderId = OrderId.Decode(pointer, current, out current);
            message.AppendULong(OrderId.FixTag, orderId);

            var clOrdId = ClOrdId.Decode(pointer, current, out current);
            message.AppendULong(ClOrdId.FixTag, clOrdId);

            var origClOrdId = OrigClOrdId.Decode(pointer, current, out current);
            message.AppendULong(OrigClOrdId.FixTag, origClOrdId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var targetPartyIdSessionId = (int)TargetPartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdSessionId.FixTag, targetPartyIdSessionId);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            if (FixClOrdId.TryDecode(pointer, current, out var fixClOrdId, out current))
            {
                message.AppendString(FixClOrdId.FixTag, fixClOrdId);
            }

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad5.Length;

            return FixErrorCode.None;
        }
    }
}