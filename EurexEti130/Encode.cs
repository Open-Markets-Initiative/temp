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
            case Eurex.Eti.v130.AddComplexInstrumentRequest.Identifier:
                Eurex.Eti.v130.AddComplexInstrumentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.AddComplexInstrumentResponse.Identifier:
                Eurex.Eti.v130.AddComplexInstrumentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.AddFlexibleInstrumentRequest.Identifier:
                Eurex.Eti.v130.AddFlexibleInstrumentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.AddFlexibleInstrumentResponse.Identifier:
                Eurex.Eti.v130.AddFlexibleInstrumentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.AddScaledSimpleInstrumentRequest.Identifier:
                Eurex.Eti.v130.AddScaledSimpleInstrumentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.AddScaledSimpleInstrumentResponse.Identifier:
                Eurex.Eti.v130.AddScaledSimpleInstrumentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.AmendBasketTradeRequest.Identifier:
                Eurex.Eti.v130.AmendBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ApproveBasketTradeRequest.Identifier:
                Eurex.Eti.v130.ApproveBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ApproveReverseTesTradeRequest.Identifier:
                Eurex.Eti.v130.ApproveReverseTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ApproveTesTradeRequest.Identifier:
                Eurex.Eti.v130.ApproveTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketApproveBroadcast.Identifier:
                Eurex.Eti.v130.BasketApproveBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketBroadcast.Identifier:
                Eurex.Eti.v130.BasketBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketDeleteBroadcast.Identifier:
                Eurex.Eti.v130.BasketDeleteBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketExecutionBroadcast.Identifier:
                Eurex.Eti.v130.BasketExecutionBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketResponse.Identifier:
                Eurex.Eti.v130.BasketResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketRollBroadcast.Identifier:
                Eurex.Eti.v130.BasketRollBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BasketRollRequest.Identifier:
                Eurex.Eti.v130.BasketRollRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.BroadcastErrorNotification.Identifier:
                Eurex.Eti.v130.BroadcastErrorNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ClipDeletionNotification.Identifier:
                Eurex.Eti.v130.ClipDeletionNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ClipExecutionNotification.Identifier:
                Eurex.Eti.v130.ClipExecutionNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ClipResponse.Identifier:
                Eurex.Eti.v130.ClipResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.CrossRequest.Identifier:
                Eurex.Eti.v130.CrossRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.CrossRequestResponse.Identifier:
                Eurex.Eti.v130.CrossRequestResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllOrderBroadcast.Identifier:
                Eurex.Eti.v130.DeleteAllOrderBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllOrderNrResponse.Identifier:
                Eurex.Eti.v130.DeleteAllOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllOrderQuoteEventBroadcast.Identifier:
                Eurex.Eti.v130.DeleteAllOrderQuoteEventBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllOrderRequest.Identifier:
                Eurex.Eti.v130.DeleteAllOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllOrderResponse.Identifier:
                Eurex.Eti.v130.DeleteAllOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllQuoteBroadcast.Identifier:
                Eurex.Eti.v130.DeleteAllQuoteBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllQuoteRequest.Identifier:
                Eurex.Eti.v130.DeleteAllQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteAllQuoteResponse.Identifier:
                Eurex.Eti.v130.DeleteAllQuoteResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteBasketTradeRequest.Identifier:
                Eurex.Eti.v130.DeleteBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteClipRequest.Identifier:
                Eurex.Eti.v130.DeleteClipRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteOrderBroadcast.Identifier:
                Eurex.Eti.v130.DeleteOrderBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteOrderComplexRequest.Identifier:
                Eurex.Eti.v130.DeleteOrderComplexRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteOrderNrResponse.Identifier:
                Eurex.Eti.v130.DeleteOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteOrderRequest.Identifier:
                Eurex.Eti.v130.DeleteOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteOrderResponse.Identifier:
                Eurex.Eti.v130.DeleteOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteOrderSingleRequest.Identifier:
                Eurex.Eti.v130.DeleteOrderSingleRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.DeleteTesTradeRequest.Identifier:
                Eurex.Eti.v130.DeleteTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.EnterBasketTradeRequest.Identifier:
                Eurex.Eti.v130.EnterBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.EnterClipRequest.Identifier:
                Eurex.Eti.v130.EnterClipRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.EnterTesTradeRequest.Identifier:
                Eurex.Eti.v130.EnterTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ForcedLogoutNotification.Identifier:
                Eurex.Eti.v130.ForcedLogoutNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ForcedUserLogoutNotification.Identifier:
                Eurex.Eti.v130.ForcedUserLogoutNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.Heartbeat.Identifier:
                Eurex.Eti.v130.Heartbeat.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.HeartbeatNotification.Identifier:
                Eurex.Eti.v130.HeartbeatNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireEnrichmentRuleIdListRequest.Identifier:
                Eurex.Eti.v130.InquireEnrichmentRuleIdListRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireEnrichmentRuleIdListResponse.Identifier:
                Eurex.Eti.v130.InquireEnrichmentRuleIdListResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireMmParameterRequest.Identifier:
                Eurex.Eti.v130.InquireMmParameterRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireMmParameterResponse.Identifier:
                Eurex.Eti.v130.InquireMmParameterResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireMarginBasedRiskLimitRequest.Identifier:
                Eurex.Eti.v130.InquireMarginBasedRiskLimitRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireMarginBasedRiskLimitResponse.Identifier:
                Eurex.Eti.v130.InquireMarginBasedRiskLimitResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquirePreTradeRiskLimitsRequest.Identifier:
                Eurex.Eti.v130.InquirePreTradeRiskLimitsRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireSessionListRequest.Identifier:
                Eurex.Eti.v130.InquireSessionListRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireSessionListResponse.Identifier:
                Eurex.Eti.v130.InquireSessionListResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireUserRequest.Identifier:
                Eurex.Eti.v130.InquireUserRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.InquireUserResponse.Identifier:
                Eurex.Eti.v130.InquireUserResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.LegalNotificationBroadcast.Identifier:
                Eurex.Eti.v130.LegalNotificationBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.LogonRequest.Identifier:
                Eurex.Eti.v130.LogonRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.LogonRequestEncrypted.Identifier:
                Eurex.Eti.v130.LogonRequestEncrypted.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.LogonResponse.Identifier:
                Eurex.Eti.v130.LogonResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.LogoutRequest.Identifier:
                Eurex.Eti.v130.LogoutRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.LogoutResponse.Identifier:
                Eurex.Eti.v130.LogoutResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.MmParameterDefinitionRequest.Identifier:
                Eurex.Eti.v130.MmParameterDefinitionRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.MmParameterDefinitionResponse.Identifier:
                Eurex.Eti.v130.MmParameterDefinitionResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.MassOrder.Identifier:
                Eurex.Eti.v130.MassOrder.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.MassOrderAck.Identifier:
                Eurex.Eti.v130.MassOrderAck.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.MassQuoteRequest.Identifier:
                Eurex.Eti.v130.MassQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.MassQuoteResponse.Identifier:
                Eurex.Eti.v130.MassQuoteResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyBasketTradeRequest.Identifier:
                Eurex.Eti.v130.ModifyBasketTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderComplexRequest.Identifier:
                Eurex.Eti.v130.ModifyOrderComplexRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderComplexShortRequest.Identifier:
                Eurex.Eti.v130.ModifyOrderComplexShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderNrResponse.Identifier:
                Eurex.Eti.v130.ModifyOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderRequest.Identifier:
                Eurex.Eti.v130.ModifyOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderResponse.Identifier:
                Eurex.Eti.v130.ModifyOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderShortRequest.Identifier:
                Eurex.Eti.v130.ModifyOrderShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderSingleRequest.Identifier:
                Eurex.Eti.v130.ModifyOrderSingleRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyOrderSingleShortRequest.Identifier:
                Eurex.Eti.v130.ModifyOrderSingleShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ModifyTesTradeRequest.Identifier:
                Eurex.Eti.v130.ModifyTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderComplexRequest.Identifier:
                Eurex.Eti.v130.NewOrderComplexRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderComplexShortRequest.Identifier:
                Eurex.Eti.v130.NewOrderComplexShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderNrResponse.Identifier:
                Eurex.Eti.v130.NewOrderNrResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderRequest.Identifier:
                Eurex.Eti.v130.NewOrderRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderResponse.Identifier:
                Eurex.Eti.v130.NewOrderResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderShortRequest.Identifier:
                Eurex.Eti.v130.NewOrderShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderSingleRequest.Identifier:
                Eurex.Eti.v130.NewOrderSingleRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewOrderSingleShortRequest.Identifier:
                Eurex.Eti.v130.NewOrderSingleShortRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.NewsBroadcast.Identifier:
                Eurex.Eti.v130.NewsBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.OrderExecNotification.Identifier:
                Eurex.Eti.v130.OrderExecNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.OrderExecReportBroadcast.Identifier:
                Eurex.Eti.v130.OrderExecReportBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.OrderExecResponse.Identifier:
                Eurex.Eti.v130.OrderExecResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.PartyActionReport.Identifier:
                Eurex.Eti.v130.PartyActionReport.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.PartyEntitlementsUpdateReport.Identifier:
                Eurex.Eti.v130.PartyEntitlementsUpdateReport.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.PingRequest.Identifier:
                Eurex.Eti.v130.PingRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.PingResponse.Identifier:
                Eurex.Eti.v130.PingResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.PreTradeRiskLimitResponse.Identifier:
                Eurex.Eti.v130.PreTradeRiskLimitResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.PreTradeRiskLimitsDefinitionRequest.Identifier:
                Eurex.Eti.v130.PreTradeRiskLimitsDefinitionRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.QuoteActivationNotification.Identifier:
                Eurex.Eti.v130.QuoteActivationNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.QuoteActivationRequest.Identifier:
                Eurex.Eti.v130.QuoteActivationRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.QuoteActivationResponse.Identifier:
                Eurex.Eti.v130.QuoteActivationResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.QuoteExecutionReport.Identifier:
                Eurex.Eti.v130.QuoteExecutionReport.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RfqRequest.Identifier:
                Eurex.Eti.v130.RfqRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RfqResponse.Identifier:
                Eurex.Eti.v130.RfqResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.Reject.Identifier:
                Eurex.Eti.v130.Reject.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RetransmitMeMessageRequest.Identifier:
                Eurex.Eti.v130.RetransmitMeMessageRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RetransmitMeMessageResponse.Identifier:
                Eurex.Eti.v130.RetransmitMeMessageResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RetransmitRequest.Identifier:
                Eurex.Eti.v130.RetransmitRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RetransmitResponse.Identifier:
                Eurex.Eti.v130.RetransmitResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ReverseTesTradeRequest.Identifier:
                Eurex.Eti.v130.ReverseTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.RiskNotificationBroadcast.Identifier:
                Eurex.Eti.v130.RiskNotificationBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsCreateDealNotification.Identifier:
                Eurex.Eti.v130.SrqsCreateDealNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsDealNotification.Identifier:
                Eurex.Eti.v130.SrqsDealNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsDealResponse.Identifier:
                Eurex.Eti.v130.SrqsDealResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsEnterQuoteRequest.Identifier:
                Eurex.Eti.v130.SrqsEnterQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsHitQuoteRequest.Identifier:
                Eurex.Eti.v130.SrqsHitQuoteRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsInquireSmartRespondentRequest.Identifier:
                Eurex.Eti.v130.SrqsInquireSmartRespondentRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsInquireSmartRespondentResponse.Identifier:
                Eurex.Eti.v130.SrqsInquireSmartRespondentResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsNegotiationNotification.Identifier:
                Eurex.Eti.v130.SrqsNegotiationNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsNegotiationRequesterNotification.Identifier:
                Eurex.Eti.v130.SrqsNegotiationRequesterNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsNegotiationStatusNotification.Identifier:
                Eurex.Eti.v130.SrqsNegotiationStatusNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsOpenNegotiationNotification.Identifier:
                Eurex.Eti.v130.SrqsOpenNegotiationNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsOpenNegotiationRequest.Identifier:
                Eurex.Eti.v130.SrqsOpenNegotiationRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsOpenNegotiationRequesterNotification.Identifier:
                Eurex.Eti.v130.SrqsOpenNegotiationRequesterNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsQuoteNotification.Identifier:
                Eurex.Eti.v130.SrqsQuoteNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsQuoteResponse.Identifier:
                Eurex.Eti.v130.SrqsQuoteResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsQuoteSnapshotNotification.Identifier:
                Eurex.Eti.v130.SrqsQuoteSnapshotNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsQuoteSnapshotRequest.Identifier:
                Eurex.Eti.v130.SrqsQuoteSnapshotRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsQuotingStatusRequest.Identifier:
                Eurex.Eti.v130.SrqsQuotingStatusRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsResponse.Identifier:
                Eurex.Eti.v130.SrqsResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsStatusBroadcast.Identifier:
                Eurex.Eti.v130.SrqsStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsUpdateDealStatusRequest.Identifier:
                Eurex.Eti.v130.SrqsUpdateDealStatusRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SrqsUpdateNegotiationRequest.Identifier:
                Eurex.Eti.v130.SrqsUpdateNegotiationRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ServiceAvailabilityBroadcast.Identifier:
                Eurex.Eti.v130.ServiceAvailabilityBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ServiceAvailabilityMarketBroadcast.Identifier:
                Eurex.Eti.v130.ServiceAvailabilityMarketBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.StatusBroadcast.Identifier:
                Eurex.Eti.v130.StatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SubscribeRequest.Identifier:
                Eurex.Eti.v130.SubscribeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.SubscribeResponse.Identifier:
                Eurex.Eti.v130.SubscribeResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesApproveBroadcast.Identifier:
                Eurex.Eti.v130.TesApproveBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesBroadcast.Identifier:
                Eurex.Eti.v130.TesBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesDeleteBroadcast.Identifier:
                Eurex.Eti.v130.TesDeleteBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesExecutionBroadcast.Identifier:
                Eurex.Eti.v130.TesExecutionBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesResponse.Identifier:
                Eurex.Eti.v130.TesResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesReversalBroadcast.Identifier:
                Eurex.Eti.v130.TesReversalBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesTradeBroadcast.Identifier:
                Eurex.Eti.v130.TesTradeBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesTradingSessionStatusBroadcast.Identifier:
                Eurex.Eti.v130.TesTradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TesUploadBroadcast.Identifier:
                Eurex.Eti.v130.TesUploadBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TmTradingSessionStatusBroadcast.Identifier:
                Eurex.Eti.v130.TmTradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.ThrottleUpdateNotification.Identifier:
                Eurex.Eti.v130.ThrottleUpdateNotification.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TradeBroadcast.Identifier:
                Eurex.Eti.v130.TradeBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.TradingSessionStatusBroadcast.Identifier:
                Eurex.Eti.v130.TradingSessionStatusBroadcast.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UnsubscribeRequest.Identifier:
                Eurex.Eti.v130.UnsubscribeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UnsubscribeResponse.Identifier:
                Eurex.Eti.v130.UnsubscribeResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UpdateRemainingRiskAllowanceBaseRequest.Identifier:
                Eurex.Eti.v130.UpdateRemainingRiskAllowanceBaseRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UpdateRemainingRiskAllowanceBaseResponse.Identifier:
                Eurex.Eti.v130.UpdateRemainingRiskAllowanceBaseResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UploadTesTradeRequest.Identifier:
                Eurex.Eti.v130.UploadTesTradeRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UserLoginRequest.Identifier:
                Eurex.Eti.v130.UserLoginRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UserLoginRequestEncrypted.Identifier:
                Eurex.Eti.v130.UserLoginRequestEncrypted.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UserLoginResponse.Identifier:
                Eurex.Eti.v130.UserLoginResponse.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UserLogoutRequest.Identifier:
                Eurex.Eti.v130.UserLogoutRequest.Encode(message, pointer, current, length, out current);
                break;

            case Eurex.Eti.v130.UserLogoutResponse.Identifier:
                Eurex.Eti.v130.UserLogoutResponse.Encode(message, pointer, current, length, out current);
                break;

            default:
                throw new System.Exception("Unknown Eti Message Type");
        }
    }
};
