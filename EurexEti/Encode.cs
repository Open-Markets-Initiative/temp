namespace SRFixBase
{
    public static partial class Ilink3v7
    {
        /// <summary>
        ///  Encode Payload
        /// </summary>
        public unsafe static void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            switch (message.msgType)
            {
                case Eurex.EtiDerivatives.v121.AddComplexInstrumentRequest.Identifier:
                    Eurex.EtiDerivatives.v121.AddComplexInstrumentRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.AddComplexInstrumentResponse.Identifier:
                    Eurex.EtiDerivatives.v121.AddComplexInstrumentResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.AddFlexibleInstrumentRequest.Identifier:
                    Eurex.EtiDerivatives.v121.AddFlexibleInstrumentRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.AddFlexibleInstrumentResponse.Identifier:
                    Eurex.EtiDerivatives.v121.AddFlexibleInstrumentResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.AddScaledSimpleInstrumentRequest.Identifier:
                    Eurex.EtiDerivatives.v121.AddScaledSimpleInstrumentRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.AddScaledSimpleInstrumentResponse.Identifier:
                    Eurex.EtiDerivatives.v121.AddScaledSimpleInstrumentResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.AmendBasketTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.AmendBasketTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ApproveBasketTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ApproveBasketTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ApproveReverseTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ApproveReverseTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ApproveTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ApproveTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.BasketApproveBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.BasketApproveBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.BasketBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.BasketBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.BasketDeleteBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.BasketDeleteBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.BasketExecutionBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.BasketExecutionBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.BasketResponse.Identifier:
                    Eurex.EtiDerivatives.v121.BasketResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.BroadcastErrorNotification.Identifier:
                    Eurex.EtiDerivatives.v121.BroadcastErrorNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ClipDeletionNotification.Identifier:
                    Eurex.EtiDerivatives.v121.ClipDeletionNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ClipExecutionNotification.Identifier:
                    Eurex.EtiDerivatives.v121.ClipExecutionNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ClipResponse.Identifier:
                    Eurex.EtiDerivatives.v121.ClipResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.CrossRequest.Identifier:
                    Eurex.EtiDerivatives.v121.CrossRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.CrossRequestResponse.Identifier:
                    Eurex.EtiDerivatives.v121.CrossRequestResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllOrderBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllOrderBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllOrderNrResponse.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllOrderNrResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllOrderQuoteEventBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllOrderQuoteEventBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllOrderRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllOrderRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllOrderResponse.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllOrderResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllQuoteBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllQuoteBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllQuoteRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllQuoteRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteAllQuoteResponse.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteAllQuoteResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteBasketTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteBasketTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteClipRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteClipRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteOrderBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteOrderBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteOrderComplexRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteOrderComplexRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteOrderNrResponse.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteOrderNrResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteOrderRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteOrderRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteOrderResponse.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteOrderResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteOrderSingleRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteOrderSingleRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.DeleteTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.DeleteTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.EnterBasketTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.EnterBasketTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.EnterClipRequest.Identifier:
                    Eurex.EtiDerivatives.v121.EnterClipRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.EnterTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.EnterTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ForcedLogoutNotification.Identifier:
                    Eurex.EtiDerivatives.v121.ForcedLogoutNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ForcedUserLogoutNotification.Identifier:
                    Eurex.EtiDerivatives.v121.ForcedUserLogoutNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.Heartbeat.Identifier:
                    Eurex.EtiDerivatives.v121.Heartbeat.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.HeartbeatNotification.Identifier:
                    Eurex.EtiDerivatives.v121.HeartbeatNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireEnrichmentRuleIdListRequest.Identifier:
                    Eurex.EtiDerivatives.v121.InquireEnrichmentRuleIdListRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireEnrichmentRuleIdListResponse.Identifier:
                    Eurex.EtiDerivatives.v121.InquireEnrichmentRuleIdListResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireMmParameterRequest.Identifier:
                    Eurex.EtiDerivatives.v121.InquireMmParameterRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireMmParameterResponse.Identifier:
                    Eurex.EtiDerivatives.v121.InquireMmParameterResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireMarginBasedRiskLimitRequest.Identifier:
                    Eurex.EtiDerivatives.v121.InquireMarginBasedRiskLimitRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireMarginBasedRiskLimitResponse.Identifier:
                    Eurex.EtiDerivatives.v121.InquireMarginBasedRiskLimitResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquirePreTradeRiskLimitsRequest.Identifier:
                    Eurex.EtiDerivatives.v121.InquirePreTradeRiskLimitsRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireSessionListRequest.Identifier:
                    Eurex.EtiDerivatives.v121.InquireSessionListRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireSessionListResponse.Identifier:
                    Eurex.EtiDerivatives.v121.InquireSessionListResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireUserRequest.Identifier:
                    Eurex.EtiDerivatives.v121.InquireUserRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.InquireUserResponse.Identifier:
                    Eurex.EtiDerivatives.v121.InquireUserResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.LegalNotificationBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.LegalNotificationBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.LogonRequest.Identifier:
                    Eurex.EtiDerivatives.v121.LogonRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.LogonRequestEncrypted.Identifier:
                    Eurex.EtiDerivatives.v121.LogonRequestEncrypted.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.LogonResponse.Identifier:
                    Eurex.EtiDerivatives.v121.LogonResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.LogoutRequest.Identifier:
                    Eurex.EtiDerivatives.v121.LogoutRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.LogoutResponse.Identifier:
                    Eurex.EtiDerivatives.v121.LogoutResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.MmParameterDefinitionRequest.Identifier:
                    Eurex.EtiDerivatives.v121.MmParameterDefinitionRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.MmParameterDefinitionResponse.Identifier:
                    Eurex.EtiDerivatives.v121.MmParameterDefinitionResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.MassOrder.Identifier:
                    Eurex.EtiDerivatives.v121.MassOrder.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.MassOrderAck.Identifier:
                    Eurex.EtiDerivatives.v121.MassOrderAck.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.MassQuoteRequest.Identifier:
                    Eurex.EtiDerivatives.v121.MassQuoteRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.MassQuoteResponse.Identifier:
                    Eurex.EtiDerivatives.v121.MassQuoteResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyBasketTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyBasketTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderComplexRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderComplexRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderComplexShortRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderComplexShortRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderNrResponse.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderNrResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderResponse.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderShortRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderShortRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderSingleRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderSingleRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyOrderSingleShortRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyOrderSingleShortRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ModifyTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ModifyTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderComplexRequest.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderComplexRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderComplexShortRequest.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderComplexShortRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderNrResponse.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderNrResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderRequest.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderResponse.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderShortRequest.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderShortRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderSingleRequest.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderSingleRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewOrderSingleShortRequest.Identifier:
                    Eurex.EtiDerivatives.v121.NewOrderSingleShortRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.NewsBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.NewsBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.OrderExecNotification.Identifier:
                    Eurex.EtiDerivatives.v121.OrderExecNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.OrderExecReportBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.OrderExecReportBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.OrderExecResponse.Identifier:
                    Eurex.EtiDerivatives.v121.OrderExecResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.PartyActionReport.Identifier:
                    Eurex.EtiDerivatives.v121.PartyActionReport.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.PartyEntitlementsUpdateReport.Identifier:
                    Eurex.EtiDerivatives.v121.PartyEntitlementsUpdateReport.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.PingRequest.Identifier:
                    Eurex.EtiDerivatives.v121.PingRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.PingResponse.Identifier:
                    Eurex.EtiDerivatives.v121.PingResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.PreTradeRiskLimitResponse.Identifier:
                    Eurex.EtiDerivatives.v121.PreTradeRiskLimitResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.PreTradeRiskLimitsDefinitionRequest.Identifier:
                    Eurex.EtiDerivatives.v121.PreTradeRiskLimitsDefinitionRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.QuoteActivationNotification.Identifier:
                    Eurex.EtiDerivatives.v121.QuoteActivationNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.QuoteActivationRequest.Identifier:
                    Eurex.EtiDerivatives.v121.QuoteActivationRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.QuoteActivationResponse.Identifier:
                    Eurex.EtiDerivatives.v121.QuoteActivationResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.QuoteExecutionReport.Identifier:
                    Eurex.EtiDerivatives.v121.QuoteExecutionReport.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RfqRequest.Identifier:
                    Eurex.EtiDerivatives.v121.RfqRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RfqResponse.Identifier:
                    Eurex.EtiDerivatives.v121.RfqResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.Reject.Identifier:
                    Eurex.EtiDerivatives.v121.Reject.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RetransmitMeMessageRequest.Identifier:
                    Eurex.EtiDerivatives.v121.RetransmitMeMessageRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RetransmitMeMessageResponse.Identifier:
                    Eurex.EtiDerivatives.v121.RetransmitMeMessageResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RetransmitRequest.Identifier:
                    Eurex.EtiDerivatives.v121.RetransmitRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RetransmitResponse.Identifier:
                    Eurex.EtiDerivatives.v121.RetransmitResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ReverseTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.ReverseTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.RiskNotificationBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.RiskNotificationBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsCreateDealNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsCreateDealNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsDealNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsDealNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsDealResponse.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsDealResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsEnterQuoteRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsEnterQuoteRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsHitQuoteRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsHitQuoteRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsInquireSmartRespondentRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsInquireSmartRespondentRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsInquireSmartRespondentResponse.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsInquireSmartRespondentResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsNegotiationNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsNegotiationNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsNegotiationRequesterNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsNegotiationRequesterNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsNegotiationStatusNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsNegotiationStatusNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsOpenNegotiationNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsOpenNegotiationNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsOpenNegotiationRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsOpenNegotiationRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsOpenNegotiationRequesterNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsOpenNegotiationRequesterNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsQuoteNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsQuoteNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsQuoteResponse.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsQuoteResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsQuoteSnapshotNotification.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsQuoteSnapshotNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsQuoteSnapshotRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsQuoteSnapshotRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsQuotingStatusRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsQuotingStatusRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsResponse.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsStatusBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsStatusBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsUpdateDealStatusRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsUpdateDealStatusRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SrqsUpdateNegotiationRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SrqsUpdateNegotiationRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ServiceAvailabilityBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.ServiceAvailabilityBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ServiceAvailabilityMarketBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.ServiceAvailabilityMarketBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.StatusBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.StatusBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SubscribeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.SubscribeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.SubscribeResponse.Identifier:
                    Eurex.EtiDerivatives.v121.SubscribeResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesApproveBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesApproveBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesDeleteBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesDeleteBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesExecutionBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesExecutionBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesResponse.Identifier:
                    Eurex.EtiDerivatives.v121.TesResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesReversalBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesReversalBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesTradeBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesTradeBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesTradingSessionStatusBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesTradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TesUploadBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TesUploadBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TmTradingSessionStatusBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TmTradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.ThrottleUpdateNotification.Identifier:
                    Eurex.EtiDerivatives.v121.ThrottleUpdateNotification.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TradeBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TradeBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.TradingSessionStatusBroadcast.Identifier:
                    Eurex.EtiDerivatives.v121.TradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UnsubscribeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.UnsubscribeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UnsubscribeResponse.Identifier:
                    Eurex.EtiDerivatives.v121.UnsubscribeResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UpdateRemainingRiskAllowanceBaseRequest.Identifier:
                    Eurex.EtiDerivatives.v121.UpdateRemainingRiskAllowanceBaseRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UpdateRemainingRiskAllowanceBaseResponse.Identifier:
                    Eurex.EtiDerivatives.v121.UpdateRemainingRiskAllowanceBaseResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UploadTesTradeRequest.Identifier:
                    Eurex.EtiDerivatives.v121.UploadTesTradeRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UserLoginRequest.Identifier:
                    Eurex.EtiDerivatives.v121.UserLoginRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UserLoginRequestEncrypted.Identifier:
                    Eurex.EtiDerivatives.v121.UserLoginRequestEncrypted.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UserLoginResponse.Identifier:
                    Eurex.EtiDerivatives.v121.UserLoginResponse.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UserLogoutRequest.Identifier:
                    Eurex.EtiDerivatives.v121.UserLogoutRequest.Encode(message, pointer, current, length, out current);
                    break;

                case Eurex.EtiDerivatives.v121.UserLogoutResponse.Identifier:
                    Eurex.EtiDerivatives.v121.UserLogoutResponse.Encode(message, pointer, current, length, out current);
                    break;

                default:
                    throw new System.Exception("Invalid Cme Message Type");
            }
        }
    };
}