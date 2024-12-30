namespace SRFixBase;

public static partial class Eti130
{
    /// <summary>
    ///  Encode Payload
    /// </summary>
    public unsafe static void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        switch (message.msgType)
        {
            case Eurex.EtiDerivatives.v130.AddComplexInstrumentRequest.Identifier:
                Eurex.EtiDerivatives.v130.AddComplexInstrumentRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.AddComplexInstrumentResponse.Identifier:
                Eurex.EtiDerivatives.v130.AddComplexInstrumentResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.AddFlexibleInstrumentRequest.Identifier:
                Eurex.EtiDerivatives.v130.AddFlexibleInstrumentRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.AddFlexibleInstrumentResponse.Identifier:
                Eurex.EtiDerivatives.v130.AddFlexibleInstrumentResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.AddScaledSimpleInstrumentRequest.Identifier:
                Eurex.EtiDerivatives.v130.AddScaledSimpleInstrumentRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.AddScaledSimpleInstrumentResponse.Identifier:
                Eurex.EtiDerivatives.v130.AddScaledSimpleInstrumentResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.AmendBasketTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.AmendBasketTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ApproveBasketTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.ApproveBasketTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ApproveReverseTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.ApproveReverseTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ApproveTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.ApproveTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketApproveBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.BasketApproveBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.BasketBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketDeleteBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.BasketDeleteBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketExecutionBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.BasketExecutionBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketResponse.Identifier:
                Eurex.EtiDerivatives.v130.BasketResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketRollBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.BasketRollBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BasketRollRequest.Identifier:
                Eurex.EtiDerivatives.v130.BasketRollRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.BroadcastErrorNotification.Identifier:
                Eurex.EtiDerivatives.v130.BroadcastErrorNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ClipDeletionNotification.Identifier:
                Eurex.EtiDerivatives.v130.ClipDeletionNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ClipExecutionNotification.Identifier:
                Eurex.EtiDerivatives.v130.ClipExecutionNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ClipResponse.Identifier:
                Eurex.EtiDerivatives.v130.ClipResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.CrossRequest.Identifier:
                Eurex.EtiDerivatives.v130.CrossRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.CrossRequestResponse.Identifier:
                Eurex.EtiDerivatives.v130.CrossRequestResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllOrderBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllOrderBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllOrderNrResponse.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllOrderNrResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllOrderQuoteEventBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllOrderQuoteEventBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllOrderRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllOrderRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllOrderResponse.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllOrderResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllQuoteBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllQuoteBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllQuoteRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllQuoteRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteAllQuoteResponse.Identifier:
                Eurex.EtiDerivatives.v130.DeleteAllQuoteResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteBasketTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteBasketTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteClipRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteClipRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteOrderBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.DeleteOrderBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteOrderComplexRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteOrderComplexRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteOrderNrResponse.Identifier:
                Eurex.EtiDerivatives.v130.DeleteOrderNrResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteOrderRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteOrderRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteOrderResponse.Identifier:
                Eurex.EtiDerivatives.v130.DeleteOrderResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteOrderSingleRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteOrderSingleRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.DeleteTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.DeleteTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.EnterBasketTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.EnterBasketTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.EnterClipRequest.Identifier:
                Eurex.EtiDerivatives.v130.EnterClipRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.EnterTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.EnterTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ForcedLogoutNotification.Identifier:
                Eurex.EtiDerivatives.v130.ForcedLogoutNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ForcedUserLogoutNotification.Identifier:
                Eurex.EtiDerivatives.v130.ForcedUserLogoutNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.Heartbeat.Identifier:
                Eurex.EtiDerivatives.v130.Heartbeat.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.HeartbeatNotification.Identifier:
                Eurex.EtiDerivatives.v130.HeartbeatNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireEnrichmentRuleIdListRequest.Identifier:
                Eurex.EtiDerivatives.v130.InquireEnrichmentRuleIdListRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireEnrichmentRuleIdListResponse.Identifier:
                Eurex.EtiDerivatives.v130.InquireEnrichmentRuleIdListResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireMmParameterRequest.Identifier:
                Eurex.EtiDerivatives.v130.InquireMmParameterRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireMmParameterResponse.Identifier:
                Eurex.EtiDerivatives.v130.InquireMmParameterResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireMarginBasedRiskLimitRequest.Identifier:
                Eurex.EtiDerivatives.v130.InquireMarginBasedRiskLimitRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireMarginBasedRiskLimitResponse.Identifier:
                Eurex.EtiDerivatives.v130.InquireMarginBasedRiskLimitResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquirePreTradeRiskLimitsRequest.Identifier:
                Eurex.EtiDerivatives.v130.InquirePreTradeRiskLimitsRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireSessionListRequest.Identifier:
                Eurex.EtiDerivatives.v130.InquireSessionListRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireSessionListResponse.Identifier:
                Eurex.EtiDerivatives.v130.InquireSessionListResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireUserRequest.Identifier:
                Eurex.EtiDerivatives.v130.InquireUserRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.InquireUserResponse.Identifier:
                Eurex.EtiDerivatives.v130.InquireUserResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.LegalNotificationBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.LegalNotificationBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.LogonRequest.Identifier:
                Eurex.EtiDerivatives.v130.LogonRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.LogonRequestEncrypted.Identifier:
                Eurex.EtiDerivatives.v130.LogonRequestEncrypted.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.LogonResponse.Identifier:
                Eurex.EtiDerivatives.v130.LogonResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.LogoutRequest.Identifier:
                Eurex.EtiDerivatives.v130.LogoutRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.LogoutResponse.Identifier:
                Eurex.EtiDerivatives.v130.LogoutResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.MmParameterDefinitionRequest.Identifier:
                Eurex.EtiDerivatives.v130.MmParameterDefinitionRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.MmParameterDefinitionResponse.Identifier:
                Eurex.EtiDerivatives.v130.MmParameterDefinitionResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.MassOrder.Identifier:
                Eurex.EtiDerivatives.v130.MassOrder.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.MassOrderAck.Identifier:
                Eurex.EtiDerivatives.v130.MassOrderAck.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.MassQuoteRequest.Identifier:
                Eurex.EtiDerivatives.v130.MassQuoteRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.MassQuoteResponse.Identifier:
                Eurex.EtiDerivatives.v130.MassQuoteResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyBasketTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyBasketTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderComplexRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderComplexRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderComplexShortRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderComplexShortRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderNrResponse.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderNrResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderResponse.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderShortRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderShortRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderSingleRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderSingleRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyOrderSingleShortRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyOrderSingleShortRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ModifyTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.ModifyTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderComplexRequest.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderComplexRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderComplexShortRequest.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderComplexShortRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderNrResponse.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderNrResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderRequest.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderResponse.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderShortRequest.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderShortRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderSingleRequest.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderSingleRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewOrderSingleShortRequest.Identifier:
                Eurex.EtiDerivatives.v130.NewOrderSingleShortRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.NewsBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.NewsBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.OrderExecNotification.Identifier:
                Eurex.EtiDerivatives.v130.OrderExecNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.OrderExecReportBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.OrderExecReportBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.OrderExecResponse.Identifier:
                Eurex.EtiDerivatives.v130.OrderExecResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.PartyActionReport.Identifier:
                Eurex.EtiDerivatives.v130.PartyActionReport.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.PartyEntitlementsUpdateReport.Identifier:
                Eurex.EtiDerivatives.v130.PartyEntitlementsUpdateReport.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.PingRequest.Identifier:
                Eurex.EtiDerivatives.v130.PingRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.PingResponse.Identifier:
                Eurex.EtiDerivatives.v130.PingResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.PreTradeRiskLimitResponse.Identifier:
                Eurex.EtiDerivatives.v130.PreTradeRiskLimitResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.PreTradeRiskLimitsDefinitionRequest.Identifier:
                Eurex.EtiDerivatives.v130.PreTradeRiskLimitsDefinitionRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.QuoteActivationNotification.Identifier:
                Eurex.EtiDerivatives.v130.QuoteActivationNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.QuoteActivationRequest.Identifier:
                Eurex.EtiDerivatives.v130.QuoteActivationRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.QuoteActivationResponse.Identifier:
                Eurex.EtiDerivatives.v130.QuoteActivationResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.QuoteExecutionReport.Identifier:
                Eurex.EtiDerivatives.v130.QuoteExecutionReport.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RfqRequest.Identifier:
                Eurex.EtiDerivatives.v130.RfqRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RfqResponse.Identifier:
                Eurex.EtiDerivatives.v130.RfqResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.Reject.Identifier:
                Eurex.EtiDerivatives.v130.Reject.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RetransmitMeMessageRequest.Identifier:
                Eurex.EtiDerivatives.v130.RetransmitMeMessageRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RetransmitMeMessageResponse.Identifier:
                Eurex.EtiDerivatives.v130.RetransmitMeMessageResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RetransmitRequest.Identifier:
                Eurex.EtiDerivatives.v130.RetransmitRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RetransmitResponse.Identifier:
                Eurex.EtiDerivatives.v130.RetransmitResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ReverseTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.ReverseTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.RiskNotificationBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.RiskNotificationBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsCreateDealNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsCreateDealNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsDealNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsDealNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsDealResponse.Identifier:
                Eurex.EtiDerivatives.v130.SrqsDealResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsEnterQuoteRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsEnterQuoteRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsHitQuoteRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsHitQuoteRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsInquireSmartRespondentRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsInquireSmartRespondentRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsInquireSmartRespondentResponse.Identifier:
                Eurex.EtiDerivatives.v130.SrqsInquireSmartRespondentResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsNegotiationNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsNegotiationNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsNegotiationRequesterNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsNegotiationRequesterNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsNegotiationStatusNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsNegotiationStatusNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsOpenNegotiationNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsOpenNegotiationNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsOpenNegotiationRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsOpenNegotiationRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsOpenNegotiationRequesterNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsOpenNegotiationRequesterNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsQuoteNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsQuoteNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsQuoteResponse.Identifier:
                Eurex.EtiDerivatives.v130.SrqsQuoteResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsQuoteSnapshotNotification.Identifier:
                Eurex.EtiDerivatives.v130.SrqsQuoteSnapshotNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsQuoteSnapshotRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsQuoteSnapshotRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsQuotingStatusRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsQuotingStatusRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsResponse.Identifier:
                Eurex.EtiDerivatives.v130.SrqsResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsStatusBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.SrqsStatusBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsUpdateDealStatusRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsUpdateDealStatusRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SrqsUpdateNegotiationRequest.Identifier:
                Eurex.EtiDerivatives.v130.SrqsUpdateNegotiationRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ServiceAvailabilityBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.ServiceAvailabilityBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ServiceAvailabilityMarketBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.ServiceAvailabilityMarketBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.StatusBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.StatusBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SubscribeRequest.Identifier:
                Eurex.EtiDerivatives.v130.SubscribeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.SubscribeResponse.Identifier:
                Eurex.EtiDerivatives.v130.SubscribeResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesApproveBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesApproveBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesDeleteBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesDeleteBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesExecutionBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesExecutionBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesResponse.Identifier:
                Eurex.EtiDerivatives.v130.TesResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesReversalBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesReversalBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesTradeBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesTradeBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesTradingSessionStatusBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesTradingSessionStatusBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TesUploadBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TesUploadBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TmTradingSessionStatusBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TmTradingSessionStatusBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.ThrottleUpdateNotification.Identifier:
                Eurex.EtiDerivatives.v130.ThrottleUpdateNotification.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TradeBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TradeBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.TradingSessionStatusBroadcast.Identifier:
                Eurex.EtiDerivatives.v130.TradingSessionStatusBroadcast.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UnsubscribeRequest.Identifier:
                Eurex.EtiDerivatives.v130.UnsubscribeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UnsubscribeResponse.Identifier:
                Eurex.EtiDerivatives.v130.UnsubscribeResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UpdateRemainingRiskAllowanceBaseRequest.Identifier:
                Eurex.EtiDerivatives.v130.UpdateRemainingRiskAllowanceBaseRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UpdateRemainingRiskAllowanceBaseResponse.Identifier:
                Eurex.EtiDerivatives.v130.UpdateRemainingRiskAllowanceBaseResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UploadTesTradeRequest.Identifier:
                Eurex.EtiDerivatives.v130.UploadTesTradeRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UserLoginRequest.Identifier:
                Eurex.EtiDerivatives.v130.UserLoginRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UserLoginRequestEncrypted.Identifier:
                Eurex.EtiDerivatives.v130.UserLoginRequestEncrypted.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UserLoginResponse.Identifier:
                Eurex.EtiDerivatives.v130.UserLoginResponse.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UserLogoutRequest.Identifier:
                Eurex.EtiDerivatives.v130.UserLogoutRequest.Encode(message, pointer, current, out current);
                break;

            case Eurex.EtiDerivatives.v130.UserLogoutResponse.Identifier:
                Eurex.EtiDerivatives.v130.UserLogoutResponse.Encode(message, pointer, current, out current);
                break;

            default:
                throw new System.Exception("Unknown Eti Message Type");
        }
    }
};
