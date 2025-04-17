namespace SRFixBase;

public static partial class Eti131
{
    /// <summary>
    ///  Decode Eti Binary to Fix Binary
    /// </summary>
    public unsafe static FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- eti message header ---

        var bodyLen = (int)Eurex.Eti.v131.BodyLen.Decode(pointer, current, out current);

        if (bodyLen + offset > length)
        {
            return FixErrorCode.PartialMessage;
        }

        var templateId = Eurex.Eti.v131.TemplateId.Decode(pointer, current, out current);

        switch (templateId)
        {
            case Eurex.Eti.v131.TemplateId.AddComplexInstrumentRequest:
                return Eurex.Eti.v131.AddComplexInstrumentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.AddComplexInstrumentResponse:
                return Eurex.Eti.v131.AddComplexInstrumentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.AddFlexibleInstrumentRequest:
                return Eurex.Eti.v131.AddFlexibleInstrumentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.AddFlexibleInstrumentResponse:
                return Eurex.Eti.v131.AddFlexibleInstrumentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.AddScaledSimpleInstrumentRequest:
                return Eurex.Eti.v131.AddScaledSimpleInstrumentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.AddScaledSimpleInstrumentResponse:
                return Eurex.Eti.v131.AddScaledSimpleInstrumentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.AmendBasketTradeRequest:
                return Eurex.Eti.v131.AmendBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ApproveBasketTradeRequest:
                return Eurex.Eti.v131.ApproveBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ApproveReverseTesTradeRequest:
                return Eurex.Eti.v131.ApproveReverseTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ApproveTesTradeRequest:
                return Eurex.Eti.v131.ApproveTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketApproveBroadcast:
                return Eurex.Eti.v131.BasketApproveBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketBroadcast:
                return Eurex.Eti.v131.BasketBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketDeleteBroadcast:
                return Eurex.Eti.v131.BasketDeleteBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketExecutionBroadcast:
                return Eurex.Eti.v131.BasketExecutionBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketResponse:
                return Eurex.Eti.v131.BasketResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketRollBroadcast:
                return Eurex.Eti.v131.BasketRollBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BasketRollRequest:
                return Eurex.Eti.v131.BasketRollRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.BroadcastErrorNotification:
                return Eurex.Eti.v131.BroadcastErrorNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ClipDeletionNotification:
                return Eurex.Eti.v131.ClipDeletionNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ClipExecutionNotification:
                return Eurex.Eti.v131.ClipExecutionNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ClipResponse:
                return Eurex.Eti.v131.ClipResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.CrossRequest:
                return Eurex.Eti.v131.CrossRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.CrossRequestResponse:
                return Eurex.Eti.v131.CrossRequestResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllOrderBroadcast:
                return Eurex.Eti.v131.DeleteAllOrderBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllOrderNrResponse:
                return Eurex.Eti.v131.DeleteAllOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllOrderQuoteEventBroadcast:
                return Eurex.Eti.v131.DeleteAllOrderQuoteEventBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllOrderRequest:
                return Eurex.Eti.v131.DeleteAllOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllOrderResponse:
                return Eurex.Eti.v131.DeleteAllOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllQuoteBroadcast:
                return Eurex.Eti.v131.DeleteAllQuoteBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllQuoteRequest:
                return Eurex.Eti.v131.DeleteAllQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteAllQuoteResponse:
                return Eurex.Eti.v131.DeleteAllQuoteResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteBasketTradeRequest:
                return Eurex.Eti.v131.DeleteBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteClipRequest:
                return Eurex.Eti.v131.DeleteClipRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteOrderBroadcast:
                return Eurex.Eti.v131.DeleteOrderBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteOrderComplexRequest:
                return Eurex.Eti.v131.DeleteOrderComplexRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteOrderNrResponse:
                return Eurex.Eti.v131.DeleteOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteOrderRequest:
                return Eurex.Eti.v131.DeleteOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteOrderResponse:
                return Eurex.Eti.v131.DeleteOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteOrderSingleRequest:
                return Eurex.Eti.v131.DeleteOrderSingleRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.DeleteTesTradeRequest:
                return Eurex.Eti.v131.DeleteTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.EnterBasketTradeRequest:
                return Eurex.Eti.v131.EnterBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.EnterClipRequest:
                return Eurex.Eti.v131.EnterClipRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.EnterTesTradeRequest:
                return Eurex.Eti.v131.EnterTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ForcedLogoutNotification:
                return Eurex.Eti.v131.ForcedLogoutNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ForcedUserLogoutNotification:
                return Eurex.Eti.v131.ForcedUserLogoutNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.Heartbeat:
                return Eurex.Eti.v131.Heartbeat.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.HeartbeatNotification:
                return Eurex.Eti.v131.HeartbeatNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireEnrichmentRuleIdListRequest:
                return Eurex.Eti.v131.InquireEnrichmentRuleIdListRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireEnrichmentRuleIdListResponse:
                return Eurex.Eti.v131.InquireEnrichmentRuleIdListResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireMmParameterRequest:
                return Eurex.Eti.v131.InquireMmParameterRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireMmParameterResponse:
                return Eurex.Eti.v131.InquireMmParameterResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireMarginBasedRiskLimitRequest:
                return Eurex.Eti.v131.InquireMarginBasedRiskLimitRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireMarginBasedRiskLimitResponse:
                return Eurex.Eti.v131.InquireMarginBasedRiskLimitResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquirePreTradeRiskLimitsRequest:
                return Eurex.Eti.v131.InquirePreTradeRiskLimitsRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireSessionListRequest:
                return Eurex.Eti.v131.InquireSessionListRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireSessionListResponse:
                return Eurex.Eti.v131.InquireSessionListResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireUserRequest:
                return Eurex.Eti.v131.InquireUserRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.InquireUserResponse:
                return Eurex.Eti.v131.InquireUserResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.LegalNotificationBroadcast:
                return Eurex.Eti.v131.LegalNotificationBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.LogonRequest:
                return Eurex.Eti.v131.LogonRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.LogonRequestEncrypted:
                return Eurex.Eti.v131.LogonRequestEncrypted.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.LogonResponse:
                return Eurex.Eti.v131.LogonResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.LogoutRequest:
                return Eurex.Eti.v131.LogoutRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.LogoutResponse:
                return Eurex.Eti.v131.LogoutResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.MmParameterDefinitionRequest:
                return Eurex.Eti.v131.MmParameterDefinitionRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.MmParameterDefinitionResponse:
                return Eurex.Eti.v131.MmParameterDefinitionResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.MassOrder:
                return Eurex.Eti.v131.MassOrder.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.MassOrderAck:
                return Eurex.Eti.v131.MassOrderAck.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.MassQuoteRequest:
                return Eurex.Eti.v131.MassQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.MassQuoteResponse:
                return Eurex.Eti.v131.MassQuoteResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyBasketTradeRequest:
                return Eurex.Eti.v131.ModifyBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderComplexRequest:
                return Eurex.Eti.v131.ModifyOrderComplexRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderComplexShortRequest:
                return Eurex.Eti.v131.ModifyOrderComplexShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderNrResponse:
                return Eurex.Eti.v131.ModifyOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderRequest:
                return Eurex.Eti.v131.ModifyOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderResponse:
                return Eurex.Eti.v131.ModifyOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderShortRequest:
                return Eurex.Eti.v131.ModifyOrderShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderSingleRequest:
                return Eurex.Eti.v131.ModifyOrderSingleRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyOrderSingleShortRequest:
                return Eurex.Eti.v131.ModifyOrderSingleShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ModifyTesTradeRequest:
                return Eurex.Eti.v131.ModifyTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderComplexRequest:
                return Eurex.Eti.v131.NewOrderComplexRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderComplexShortRequest:
                return Eurex.Eti.v131.NewOrderComplexShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderNrResponse:
                return Eurex.Eti.v131.NewOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderRequest:
                return Eurex.Eti.v131.NewOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderResponse:
                return Eurex.Eti.v131.NewOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderShortRequest:
                return Eurex.Eti.v131.NewOrderShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderSingleRequest:
                return Eurex.Eti.v131.NewOrderSingleRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewOrderSingleShortRequest:
                return Eurex.Eti.v131.NewOrderSingleShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.NewsBroadcast:
                return Eurex.Eti.v131.NewsBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.OrderExecNotification:
                return Eurex.Eti.v131.OrderExecNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.OrderExecReportBroadcast:
                return Eurex.Eti.v131.OrderExecReportBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.OrderExecResponse:
                return Eurex.Eti.v131.OrderExecResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.PartyActionReport:
                return Eurex.Eti.v131.PartyActionReport.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.PartyEntitlementsUpdateReport:
                return Eurex.Eti.v131.PartyEntitlementsUpdateReport.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.PingRequest:
                return Eurex.Eti.v131.PingRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.PingResponse:
                return Eurex.Eti.v131.PingResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.PreTradeRiskLimitResponse:
                return Eurex.Eti.v131.PreTradeRiskLimitResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.PreTradeRiskLimitsDefinitionRequest:
                return Eurex.Eti.v131.PreTradeRiskLimitsDefinitionRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.QuoteActivationNotification:
                return Eurex.Eti.v131.QuoteActivationNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.QuoteActivationRequest:
                return Eurex.Eti.v131.QuoteActivationRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.QuoteActivationResponse:
                return Eurex.Eti.v131.QuoteActivationResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.QuoteExecutionReport:
                return Eurex.Eti.v131.QuoteExecutionReport.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RfqRequest:
                return Eurex.Eti.v131.RfqRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RfqResponse:
                return Eurex.Eti.v131.RfqResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.Reject:
                return Eurex.Eti.v131.Reject.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RetransmitMeMessageRequest:
                return Eurex.Eti.v131.RetransmitMeMessageRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RetransmitMeMessageResponse:
                return Eurex.Eti.v131.RetransmitMeMessageResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RetransmitRequest:
                return Eurex.Eti.v131.RetransmitRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RetransmitResponse:
                return Eurex.Eti.v131.RetransmitResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ReverseTesTradeRequest:
                return Eurex.Eti.v131.ReverseTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.RiskNotificationBroadcast:
                return Eurex.Eti.v131.RiskNotificationBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsCreateDealNotification:
                return Eurex.Eti.v131.SrqsCreateDealNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsDealNotification:
                return Eurex.Eti.v131.SrqsDealNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsDealResponse:
                return Eurex.Eti.v131.SrqsDealResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsEnterQuoteRequest:
                return Eurex.Eti.v131.SrqsEnterQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsHitQuoteRequest:
                return Eurex.Eti.v131.SrqsHitQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsInquireSmartRespondentRequest:
                return Eurex.Eti.v131.SrqsInquireSmartRespondentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsInquireSmartRespondentResponse:
                return Eurex.Eti.v131.SrqsInquireSmartRespondentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsNegotiationNotification:
                return Eurex.Eti.v131.SrqsNegotiationNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsNegotiationRequesterNotification:
                return Eurex.Eti.v131.SrqsNegotiationRequesterNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsNegotiationStatusNotification:
                return Eurex.Eti.v131.SrqsNegotiationStatusNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsOpenNegotiationNotification:
                return Eurex.Eti.v131.SrqsOpenNegotiationNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsOpenNegotiationRequest:
                return Eurex.Eti.v131.SrqsOpenNegotiationRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsOpenNegotiationRequesterNotification:
                return Eurex.Eti.v131.SrqsOpenNegotiationRequesterNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsQuoteNotification:
                return Eurex.Eti.v131.SrqsQuoteNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsQuoteResponse:
                return Eurex.Eti.v131.SrqsQuoteResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsQuoteSnapshotNotification:
                return Eurex.Eti.v131.SrqsQuoteSnapshotNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsQuoteSnapshotRequest:
                return Eurex.Eti.v131.SrqsQuoteSnapshotRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsQuotingStatusRequest:
                return Eurex.Eti.v131.SrqsQuotingStatusRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsResponse:
                return Eurex.Eti.v131.SrqsResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsStatusBroadcast:
                return Eurex.Eti.v131.SrqsStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsUpdateDealStatusRequest:
                return Eurex.Eti.v131.SrqsUpdateDealStatusRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SrqsUpdateNegotiationRequest:
                return Eurex.Eti.v131.SrqsUpdateNegotiationRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ServiceAvailabilityBroadcast:
                return Eurex.Eti.v131.ServiceAvailabilityBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ServiceAvailabilityMarketBroadcast:
                return Eurex.Eti.v131.ServiceAvailabilityMarketBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.StatusBroadcast:
                return Eurex.Eti.v131.StatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SubscribeRequest:
                return Eurex.Eti.v131.SubscribeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.SubscribeResponse:
                return Eurex.Eti.v131.SubscribeResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesApproveBroadcast:
                return Eurex.Eti.v131.TesApproveBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesBroadcast:
                return Eurex.Eti.v131.TesBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesDeleteBroadcast:
                return Eurex.Eti.v131.TesDeleteBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesExecutionBroadcast:
                return Eurex.Eti.v131.TesExecutionBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesResponse:
                return Eurex.Eti.v131.TesResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesReversalBroadcast:
                return Eurex.Eti.v131.TesReversalBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesTradeBroadcast:
                return Eurex.Eti.v131.TesTradeBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesTradingSessionStatusBroadcast:
                return Eurex.Eti.v131.TesTradingSessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TesUploadBroadcast:
                return Eurex.Eti.v131.TesUploadBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TmTradingSessionStatusBroadcast:
                return Eurex.Eti.v131.TmTradingSessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.ThrottleUpdateNotification:
                return Eurex.Eti.v131.ThrottleUpdateNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TradeBroadcast:
                return Eurex.Eti.v131.TradeBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.TradingSessionStatusBroadcast:
                return Eurex.Eti.v131.TradingSessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UnsubscribeRequest:
                return Eurex.Eti.v131.UnsubscribeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UnsubscribeResponse:
                return Eurex.Eti.v131.UnsubscribeResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UpdateRemainingRiskAllowanceBaseRequest:
                return Eurex.Eti.v131.UpdateRemainingRiskAllowanceBaseRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UpdateRemainingRiskAllowanceBaseResponse:
                return Eurex.Eti.v131.UpdateRemainingRiskAllowanceBaseResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UploadTesTradeRequest:
                return Eurex.Eti.v131.UploadTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UserLoginRequest:
                return Eurex.Eti.v131.UserLoginRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UserLoginRequestEncrypted:
                return Eurex.Eti.v131.UserLoginRequestEncrypted.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UserLoginResponse:
                return Eurex.Eti.v131.UserLoginResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UserLogoutRequest:
                return Eurex.Eti.v131.UserLogoutRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v131.TemplateId.UserLogoutResponse:
                return Eurex.Eti.v131.UserLogoutResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            default:
                return FixErrorCode.Decode;
        }
    }
};
