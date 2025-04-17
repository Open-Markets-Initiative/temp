namespace SRFixBase;

public static partial class Eti131
{
    /// <summary>
    ///  Encode Payload
    /// </summary>
    public unsafe static void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        switch (message.msgType)
        {
            case Eurex.Eti.v131.AddComplexInstrumentRequest.Identifier:
                Eurex.Eti.v131.AddComplexInstrumentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.AddComplexInstrumentResponse.Identifier:
                Eurex.Eti.v131.AddComplexInstrumentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.AddFlexibleInstrumentRequest.Identifier:
                Eurex.Eti.v131.AddFlexibleInstrumentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.AddFlexibleInstrumentResponse.Identifier:
                Eurex.Eti.v131.AddFlexibleInstrumentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.AddScaledSimpleInstrumentRequest.Identifier:
                Eurex.Eti.v131.AddScaledSimpleInstrumentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.AddScaledSimpleInstrumentResponse.Identifier:
                Eurex.Eti.v131.AddScaledSimpleInstrumentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.AmendBasketTradeRequest.Identifier:
                Eurex.Eti.v131.AmendBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ApproveBasketTradeRequest.Identifier:
                Eurex.Eti.v131.ApproveBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ApproveReverseTesTradeRequest.Identifier:
                Eurex.Eti.v131.ApproveReverseTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ApproveTesTradeRequest.Identifier:
                Eurex.Eti.v131.ApproveTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketApproveBroadcast.Identifier:
                Eurex.Eti.v131.BasketApproveBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketBroadcast.Identifier:
                Eurex.Eti.v131.BasketBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketDeleteBroadcast.Identifier:
                Eurex.Eti.v131.BasketDeleteBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketExecutionBroadcast.Identifier:
                Eurex.Eti.v131.BasketExecutionBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketResponse.Identifier:
                Eurex.Eti.v131.BasketResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketRollBroadcast.Identifier:
                Eurex.Eti.v131.BasketRollBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BasketRollRequest.Identifier:
                Eurex.Eti.v131.BasketRollRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.BroadcastErrorNotification.Identifier:
                Eurex.Eti.v131.BroadcastErrorNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ClipDeletionNotification.Identifier:
                Eurex.Eti.v131.ClipDeletionNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ClipExecutionNotification.Identifier:
                Eurex.Eti.v131.ClipExecutionNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ClipResponse.Identifier:
                Eurex.Eti.v131.ClipResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.CrossRequest.Identifier:
                Eurex.Eti.v131.CrossRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.CrossRequestResponse.Identifier:
                Eurex.Eti.v131.CrossRequestResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllOrderBroadcast.Identifier:
                Eurex.Eti.v131.DeleteAllOrderBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllOrderNrResponse.Identifier:
                Eurex.Eti.v131.DeleteAllOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllOrderQuoteEventBroadcast.Identifier:
                Eurex.Eti.v131.DeleteAllOrderQuoteEventBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllOrderRequest.Identifier:
                Eurex.Eti.v131.DeleteAllOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllOrderResponse.Identifier:
                Eurex.Eti.v131.DeleteAllOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllQuoteBroadcast.Identifier:
                Eurex.Eti.v131.DeleteAllQuoteBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllQuoteRequest.Identifier:
                Eurex.Eti.v131.DeleteAllQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteAllQuoteResponse.Identifier:
                Eurex.Eti.v131.DeleteAllQuoteResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteBasketTradeRequest.Identifier:
                Eurex.Eti.v131.DeleteBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteClipRequest.Identifier:
                Eurex.Eti.v131.DeleteClipRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteOrderBroadcast.Identifier:
                Eurex.Eti.v131.DeleteOrderBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteOrderComplexRequest.Identifier:
                Eurex.Eti.v131.DeleteOrderComplexRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteOrderNrResponse.Identifier:
                Eurex.Eti.v131.DeleteOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteOrderRequest.Identifier:
                Eurex.Eti.v131.DeleteOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteOrderResponse.Identifier:
                Eurex.Eti.v131.DeleteOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteOrderSingleRequest.Identifier:
                Eurex.Eti.v131.DeleteOrderSingleRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.DeleteTesTradeRequest.Identifier:
                Eurex.Eti.v131.DeleteTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.EnterBasketTradeRequest.Identifier:
                Eurex.Eti.v131.EnterBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.EnterClipRequest.Identifier:
                Eurex.Eti.v131.EnterClipRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.EnterTesTradeRequest.Identifier:
                Eurex.Eti.v131.EnterTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ForcedLogoutNotification.Identifier:
                Eurex.Eti.v131.ForcedLogoutNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ForcedUserLogoutNotification.Identifier:
                Eurex.Eti.v131.ForcedUserLogoutNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.Heartbeat.Identifier:
                Eurex.Eti.v131.Heartbeat.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.HeartbeatNotification.Identifier:
                Eurex.Eti.v131.HeartbeatNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireEnrichmentRuleIdListRequest.Identifier:
                Eurex.Eti.v131.InquireEnrichmentRuleIdListRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireEnrichmentRuleIdListResponse.Identifier:
                Eurex.Eti.v131.InquireEnrichmentRuleIdListResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireMmParameterRequest.Identifier:
                Eurex.Eti.v131.InquireMmParameterRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireMmParameterResponse.Identifier:
                Eurex.Eti.v131.InquireMmParameterResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireMarginBasedRiskLimitRequest.Identifier:
                Eurex.Eti.v131.InquireMarginBasedRiskLimitRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireMarginBasedRiskLimitResponse.Identifier:
                Eurex.Eti.v131.InquireMarginBasedRiskLimitResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquirePreTradeRiskLimitsRequest.Identifier:
                Eurex.Eti.v131.InquirePreTradeRiskLimitsRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireSessionListRequest.Identifier:
                Eurex.Eti.v131.InquireSessionListRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireSessionListResponse.Identifier:
                Eurex.Eti.v131.InquireSessionListResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireUserRequest.Identifier:
                Eurex.Eti.v131.InquireUserRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.InquireUserResponse.Identifier:
                Eurex.Eti.v131.InquireUserResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.LegalNotificationBroadcast.Identifier:
                Eurex.Eti.v131.LegalNotificationBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.LogonRequest.Identifier:
                Eurex.Eti.v131.LogonRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.LogonRequestEncrypted.Identifier:
                Eurex.Eti.v131.LogonRequestEncrypted.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.LogonResponse.Identifier:
                Eurex.Eti.v131.LogonResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.LogoutRequest.Identifier:
                Eurex.Eti.v131.LogoutRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.LogoutResponse.Identifier:
                Eurex.Eti.v131.LogoutResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.MmParameterDefinitionRequest.Identifier:
                Eurex.Eti.v131.MmParameterDefinitionRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.MmParameterDefinitionResponse.Identifier:
                Eurex.Eti.v131.MmParameterDefinitionResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.MassOrder.Identifier:
                Eurex.Eti.v131.MassOrder.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.MassOrderAck.Identifier:
                Eurex.Eti.v131.MassOrderAck.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.MassQuoteRequest.Identifier:
                Eurex.Eti.v131.MassQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.MassQuoteResponse.Identifier:
                Eurex.Eti.v131.MassQuoteResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyBasketTradeRequest.Identifier:
                Eurex.Eti.v131.ModifyBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderComplexRequest.Identifier:
                Eurex.Eti.v131.ModifyOrderComplexRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderComplexShortRequest.Identifier:
                Eurex.Eti.v131.ModifyOrderComplexShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderNrResponse.Identifier:
                Eurex.Eti.v131.ModifyOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderRequest.Identifier:
                Eurex.Eti.v131.ModifyOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderResponse.Identifier:
                Eurex.Eti.v131.ModifyOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderShortRequest.Identifier:
                Eurex.Eti.v131.ModifyOrderShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderSingleRequest.Identifier:
                Eurex.Eti.v131.ModifyOrderSingleRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyOrderSingleShortRequest.Identifier:
                Eurex.Eti.v131.ModifyOrderSingleShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ModifyTesTradeRequest.Identifier:
                Eurex.Eti.v131.ModifyTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderComplexRequest.Identifier:
                Eurex.Eti.v131.NewOrderComplexRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderComplexShortRequest.Identifier:
                Eurex.Eti.v131.NewOrderComplexShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderNrResponse.Identifier:
                Eurex.Eti.v131.NewOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderRequest.Identifier:
                Eurex.Eti.v131.NewOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderResponse.Identifier:
                Eurex.Eti.v131.NewOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderShortRequest.Identifier:
                Eurex.Eti.v131.NewOrderShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderSingleRequest.Identifier:
                Eurex.Eti.v131.NewOrderSingleRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewOrderSingleShortRequest.Identifier:
                Eurex.Eti.v131.NewOrderSingleShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.NewsBroadcast.Identifier:
                Eurex.Eti.v131.NewsBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.OrderExecNotification.Identifier:
                Eurex.Eti.v131.OrderExecNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.OrderExecReportBroadcast.Identifier:
                Eurex.Eti.v131.OrderExecReportBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.OrderExecResponse.Identifier:
                Eurex.Eti.v131.OrderExecResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.PartyActionReport.Identifier:
                Eurex.Eti.v131.PartyActionReport.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.PartyEntitlementsUpdateReport.Identifier:
                Eurex.Eti.v131.PartyEntitlementsUpdateReport.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.PingRequest.Identifier:
                Eurex.Eti.v131.PingRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.PingResponse.Identifier:
                Eurex.Eti.v131.PingResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.PreTradeRiskLimitResponse.Identifier:
                Eurex.Eti.v131.PreTradeRiskLimitResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.PreTradeRiskLimitsDefinitionRequest.Identifier:
                Eurex.Eti.v131.PreTradeRiskLimitsDefinitionRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.QuoteActivationNotification.Identifier:
                Eurex.Eti.v131.QuoteActivationNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.QuoteActivationRequest.Identifier:
                Eurex.Eti.v131.QuoteActivationRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.QuoteActivationResponse.Identifier:
                Eurex.Eti.v131.QuoteActivationResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.QuoteExecutionReport.Identifier:
                Eurex.Eti.v131.QuoteExecutionReport.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RfqRequest.Identifier:
                Eurex.Eti.v131.RfqRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RfqResponse.Identifier:
                Eurex.Eti.v131.RfqResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.Reject.Identifier:
                Eurex.Eti.v131.Reject.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RetransmitMeMessageRequest.Identifier:
                Eurex.Eti.v131.RetransmitMeMessageRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RetransmitMeMessageResponse.Identifier:
                Eurex.Eti.v131.RetransmitMeMessageResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RetransmitRequest.Identifier:
                Eurex.Eti.v131.RetransmitRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RetransmitResponse.Identifier:
                Eurex.Eti.v131.RetransmitResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ReverseTesTradeRequest.Identifier:
                Eurex.Eti.v131.ReverseTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.RiskNotificationBroadcast.Identifier:
                Eurex.Eti.v131.RiskNotificationBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsCreateDealNotification.Identifier:
                Eurex.Eti.v131.SrqsCreateDealNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsDealNotification.Identifier:
                Eurex.Eti.v131.SrqsDealNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsDealResponse.Identifier:
                Eurex.Eti.v131.SrqsDealResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsEnterQuoteRequest.Identifier:
                Eurex.Eti.v131.SrqsEnterQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsHitQuoteRequest.Identifier:
                Eurex.Eti.v131.SrqsHitQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsInquireSmartRespondentRequest.Identifier:
                Eurex.Eti.v131.SrqsInquireSmartRespondentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsInquireSmartRespondentResponse.Identifier:
                Eurex.Eti.v131.SrqsInquireSmartRespondentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsNegotiationNotification.Identifier:
                Eurex.Eti.v131.SrqsNegotiationNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsNegotiationRequesterNotification.Identifier:
                Eurex.Eti.v131.SrqsNegotiationRequesterNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsNegotiationStatusNotification.Identifier:
                Eurex.Eti.v131.SrqsNegotiationStatusNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsOpenNegotiationNotification.Identifier:
                Eurex.Eti.v131.SrqsOpenNegotiationNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsOpenNegotiationRequest.Identifier:
                Eurex.Eti.v131.SrqsOpenNegotiationRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsOpenNegotiationRequesterNotification.Identifier:
                Eurex.Eti.v131.SrqsOpenNegotiationRequesterNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsQuoteNotification.Identifier:
                Eurex.Eti.v131.SrqsQuoteNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsQuoteResponse.Identifier:
                Eurex.Eti.v131.SrqsQuoteResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsQuoteSnapshotNotification.Identifier:
                Eurex.Eti.v131.SrqsQuoteSnapshotNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsQuoteSnapshotRequest.Identifier:
                Eurex.Eti.v131.SrqsQuoteSnapshotRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsQuotingStatusRequest.Identifier:
                Eurex.Eti.v131.SrqsQuotingStatusRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsResponse.Identifier:
                Eurex.Eti.v131.SrqsResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsStatusBroadcast.Identifier:
                Eurex.Eti.v131.SrqsStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsUpdateDealStatusRequest.Identifier:
                Eurex.Eti.v131.SrqsUpdateDealStatusRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SrqsUpdateNegotiationRequest.Identifier:
                Eurex.Eti.v131.SrqsUpdateNegotiationRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ServiceAvailabilityBroadcast.Identifier:
                Eurex.Eti.v131.ServiceAvailabilityBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ServiceAvailabilityMarketBroadcast.Identifier:
                Eurex.Eti.v131.ServiceAvailabilityMarketBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.StatusBroadcast.Identifier:
                Eurex.Eti.v131.StatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SubscribeRequest.Identifier:
                Eurex.Eti.v131.SubscribeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.SubscribeResponse.Identifier:
                Eurex.Eti.v131.SubscribeResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesApproveBroadcast.Identifier:
                Eurex.Eti.v131.TesApproveBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesBroadcast.Identifier:
                Eurex.Eti.v131.TesBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesDeleteBroadcast.Identifier:
                Eurex.Eti.v131.TesDeleteBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesExecutionBroadcast.Identifier:
                Eurex.Eti.v131.TesExecutionBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesResponse.Identifier:
                Eurex.Eti.v131.TesResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesReversalBroadcast.Identifier:
                Eurex.Eti.v131.TesReversalBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesTradeBroadcast.Identifier:
                Eurex.Eti.v131.TesTradeBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesTradingSessionStatusBroadcast.Identifier:
                Eurex.Eti.v131.TesTradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TesUploadBroadcast.Identifier:
                Eurex.Eti.v131.TesUploadBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TmTradingSessionStatusBroadcast.Identifier:
                Eurex.Eti.v131.TmTradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.ThrottleUpdateNotification.Identifier:
                Eurex.Eti.v131.ThrottleUpdateNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TradeBroadcast.Identifier:
                Eurex.Eti.v131.TradeBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.TradingSessionStatusBroadcast.Identifier:
                Eurex.Eti.v131.TradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UnsubscribeRequest.Identifier:
                Eurex.Eti.v131.UnsubscribeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UnsubscribeResponse.Identifier:
                Eurex.Eti.v131.UnsubscribeResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UpdateRemainingRiskAllowanceBaseRequest.Identifier:
                Eurex.Eti.v131.UpdateRemainingRiskAllowanceBaseRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UpdateRemainingRiskAllowanceBaseResponse.Identifier:
                Eurex.Eti.v131.UpdateRemainingRiskAllowanceBaseResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UploadTesTradeRequest.Identifier:
                Eurex.Eti.v131.UploadTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UserLoginRequest.Identifier:
                Eurex.Eti.v131.UserLoginRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UserLoginRequestEncrypted.Identifier:
                Eurex.Eti.v131.UserLoginRequestEncrypted.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UserLoginResponse.Identifier:
                Eurex.Eti.v131.UserLoginResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UserLogoutRequest.Identifier:
                Eurex.Eti.v131.UserLogoutRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v131.UserLogoutResponse.Identifier:
                Eurex.Eti.v131.UserLogoutResponse.Encode(message, pointer, current, length, out current);
                break;

            default:
                throw new System.Exception("Unknown Eti Message Type");
        }
    }
};
