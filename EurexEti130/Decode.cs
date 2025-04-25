namespace SRFixBase;

public static partial class Eti130
{
    /// <summary>
    ///  Decode Eti Binary to Fix Binary
    /// </summary>
    public unsafe static FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- eti message header ---

        var bodyLen = (int)Eurex.Eti.v130.BodyLen.Decode(pointer, current, out current);

        if (bodyLen + offset > length)
        {
            return FixErrorCode.PartialMessage;
        }

        var templateId = Eurex.Eti.v130.TemplateId.Decode(pointer, current, out current);

        switch (templateId)
        {
            case Eurex.Eti.v130.TemplateId.AddComplexInstrumentRequest:
                return Eurex.Eti.v130.AddComplexInstrumentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.AddComplexInstrumentResponse:
                return Eurex.Eti.v130.AddComplexInstrumentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.AddFlexibleInstrumentRequest:
                return Eurex.Eti.v130.AddFlexibleInstrumentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.AddFlexibleInstrumentResponse:
                return Eurex.Eti.v130.AddFlexibleInstrumentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.AddScaledSimpleInstrumentRequest:
                return Eurex.Eti.v130.AddScaledSimpleInstrumentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.AddScaledSimpleInstrumentResponse:
                return Eurex.Eti.v130.AddScaledSimpleInstrumentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.AmendBasketTradeRequest:
                return Eurex.Eti.v130.AmendBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ApproveBasketTradeRequest:
                return Eurex.Eti.v130.ApproveBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ApproveReverseTesTradeRequest:
                return Eurex.Eti.v130.ApproveReverseTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ApproveTesTradeRequest:
                return Eurex.Eti.v130.ApproveTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketApproveBroadcast:
                return Eurex.Eti.v130.BasketApproveBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketBroadcast:
                return Eurex.Eti.v130.BasketBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketDeleteBroadcast:
                return Eurex.Eti.v130.BasketDeleteBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketExecutionBroadcast:
                return Eurex.Eti.v130.BasketExecutionBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketResponse:
                return Eurex.Eti.v130.BasketResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketRollBroadcast:
                return Eurex.Eti.v130.BasketRollBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BasketRollRequest:
                return Eurex.Eti.v130.BasketRollRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.BroadcastErrorNotification:
                return Eurex.Eti.v130.BroadcastErrorNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ClipDeletionNotification:
                return Eurex.Eti.v130.ClipDeletionNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ClipExecutionNotification:
                return Eurex.Eti.v130.ClipExecutionNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ClipResponse:
                return Eurex.Eti.v130.ClipResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.CrossRequest:
                return Eurex.Eti.v130.CrossRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.CrossRequestResponse:
                return Eurex.Eti.v130.CrossRequestResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllOrderBroadcast:
                return Eurex.Eti.v130.DeleteAllOrderBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllOrderNrResponse:
                return Eurex.Eti.v130.DeleteAllOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllOrderQuoteEventBroadcast:
                return Eurex.Eti.v130.DeleteAllOrderQuoteEventBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllOrderRequest:
                return Eurex.Eti.v130.DeleteAllOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllOrderResponse:
                return Eurex.Eti.v130.DeleteAllOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllQuoteBroadcast:
                return Eurex.Eti.v130.DeleteAllQuoteBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllQuoteRequest:
                return Eurex.Eti.v130.DeleteAllQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteAllQuoteResponse:
                return Eurex.Eti.v130.DeleteAllQuoteResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteBasketTradeRequest:
                return Eurex.Eti.v130.DeleteBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteClipRequest:
                return Eurex.Eti.v130.DeleteClipRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteOrderBroadcast:
                return Eurex.Eti.v130.DeleteOrderBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteOrderComplexRequest:
                return Eurex.Eti.v130.DeleteOrderComplexRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteOrderNrResponse:
                return Eurex.Eti.v130.DeleteOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteOrderRequest:
                return Eurex.Eti.v130.DeleteOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteOrderResponse:
                return Eurex.Eti.v130.DeleteOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteOrderSingleRequest:
                return Eurex.Eti.v130.DeleteOrderSingleRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.DeleteTesTradeRequest:
                return Eurex.Eti.v130.DeleteTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.EnterBasketTradeRequest:
                return Eurex.Eti.v130.EnterBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.EnterClipRequest:
                return Eurex.Eti.v130.EnterClipRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.EnterTesTradeRequest:
                return Eurex.Eti.v130.EnterTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ForcedLogoutNotification:
                return Eurex.Eti.v130.ForcedLogoutNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ForcedUserLogoutNotification:
                return Eurex.Eti.v130.ForcedUserLogoutNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.Heartbeat:
                return Eurex.Eti.v130.Heartbeat.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.HeartbeatNotification:
                return Eurex.Eti.v130.HeartbeatNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireEnrichmentRuleIdListRequest:
                return Eurex.Eti.v130.InquireEnrichmentRuleIdListRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireEnrichmentRuleIdListResponse:
                return Eurex.Eti.v130.InquireEnrichmentRuleIdListResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireMmParameterRequest:
                return Eurex.Eti.v130.InquireMmParameterRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireMmParameterResponse:
                return Eurex.Eti.v130.InquireMmParameterResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireMarginBasedRiskLimitRequest:
                return Eurex.Eti.v130.InquireMarginBasedRiskLimitRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireMarginBasedRiskLimitResponse:
                return Eurex.Eti.v130.InquireMarginBasedRiskLimitResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquirePreTradeRiskLimitsRequest:
                return Eurex.Eti.v130.InquirePreTradeRiskLimitsRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireSessionListRequest:
                return Eurex.Eti.v130.InquireSessionListRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireSessionListResponse:
                return Eurex.Eti.v130.InquireSessionListResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireUserRequest:
                return Eurex.Eti.v130.InquireUserRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.InquireUserResponse:
                return Eurex.Eti.v130.InquireUserResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.LegalNotificationBroadcast:
                return Eurex.Eti.v130.LegalNotificationBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.LogonRequest:
                return Eurex.Eti.v130.LogonRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.LogonRequestEncrypted:
                return Eurex.Eti.v130.LogonRequestEncrypted.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.LogonResponse:
                return Eurex.Eti.v130.LogonResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.LogoutRequest:
                return Eurex.Eti.v130.LogoutRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.LogoutResponse:
                return Eurex.Eti.v130.LogoutResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.MmParameterDefinitionRequest:
                return Eurex.Eti.v130.MmParameterDefinitionRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.MmParameterDefinitionResponse:
                return Eurex.Eti.v130.MmParameterDefinitionResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.MassOrder:
                return Eurex.Eti.v130.MassOrder.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.MassOrderAck:
                return Eurex.Eti.v130.MassOrderAck.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.MassQuoteRequest:
                return Eurex.Eti.v130.MassQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.MassQuoteResponse:
                return Eurex.Eti.v130.MassQuoteResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyBasketTradeRequest:
                return Eurex.Eti.v130.ModifyBasketTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderComplexRequest:
                return Eurex.Eti.v130.ModifyOrderComplexRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderComplexShortRequest:
                return Eurex.Eti.v130.ModifyOrderComplexShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderNrResponse:
                return Eurex.Eti.v130.ModifyOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderRequest:
                return Eurex.Eti.v130.ModifyOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderResponse:
                return Eurex.Eti.v130.ModifyOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderShortRequest:
                return Eurex.Eti.v130.ModifyOrderShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderSingleRequest:
                return Eurex.Eti.v130.ModifyOrderSingleRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyOrderSingleShortRequest:
                return Eurex.Eti.v130.ModifyOrderSingleShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ModifyTesTradeRequest:
                return Eurex.Eti.v130.ModifyTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderComplexRequest:
                return Eurex.Eti.v130.NewOrderComplexRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderComplexShortRequest:
                return Eurex.Eti.v130.NewOrderComplexShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderNrResponse:
                return Eurex.Eti.v130.NewOrderNrResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderRequest:
                return Eurex.Eti.v130.NewOrderRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderResponse:
                return Eurex.Eti.v130.NewOrderResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderShortRequest:
                return Eurex.Eti.v130.NewOrderShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderSingleRequest:
                return Eurex.Eti.v130.NewOrderSingleRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewOrderSingleShortRequest:
                return Eurex.Eti.v130.NewOrderSingleShortRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.NewsBroadcast:
                return Eurex.Eti.v130.NewsBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.OrderExecNotification:
                return Eurex.Eti.v130.OrderExecNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.OrderExecReportBroadcast:
                return Eurex.Eti.v130.OrderExecReportBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.OrderExecResponse:
                return Eurex.Eti.v130.OrderExecResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.PartyActionReport:
                return Eurex.Eti.v130.PartyActionReport.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.PartyEntitlementsUpdateReport:
                return Eurex.Eti.v130.PartyEntitlementsUpdateReport.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.PingRequest:
                return Eurex.Eti.v130.PingRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.PingResponse:
                return Eurex.Eti.v130.PingResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.PreTradeRiskLimitResponse:
                return Eurex.Eti.v130.PreTradeRiskLimitResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.PreTradeRiskLimitsDefinitionRequest:
                return Eurex.Eti.v130.PreTradeRiskLimitsDefinitionRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.QuoteActivationNotification:
                return Eurex.Eti.v130.QuoteActivationNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.QuoteActivationRequest:
                return Eurex.Eti.v130.QuoteActivationRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.QuoteActivationResponse:
                return Eurex.Eti.v130.QuoteActivationResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.QuoteExecutionReport:
                return Eurex.Eti.v130.QuoteExecutionReport.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RfqRequest:
                return Eurex.Eti.v130.RfqRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RfqResponse:
                return Eurex.Eti.v130.RfqResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.Reject:
                return Eurex.Eti.v130.Reject.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RetransmitMeMessageRequest:
                return Eurex.Eti.v130.RetransmitMeMessageRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RetransmitMeMessageResponse:
                return Eurex.Eti.v130.RetransmitMeMessageResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RetransmitRequest:
                return Eurex.Eti.v130.RetransmitRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RetransmitResponse:
                return Eurex.Eti.v130.RetransmitResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ReverseTesTradeRequest:
                return Eurex.Eti.v130.ReverseTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.RiskNotificationBroadcast:
                return Eurex.Eti.v130.RiskNotificationBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsCreateDealNotification:
                return Eurex.Eti.v130.SrqsCreateDealNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsDealNotification:
                return Eurex.Eti.v130.SrqsDealNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsDealResponse:
                return Eurex.Eti.v130.SrqsDealResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsEnterQuoteRequest:
                return Eurex.Eti.v130.SrqsEnterQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsHitQuoteRequest:
                return Eurex.Eti.v130.SrqsHitQuoteRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsInquireSmartRespondentRequest:
                return Eurex.Eti.v130.SrqsInquireSmartRespondentRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsInquireSmartRespondentResponse:
                return Eurex.Eti.v130.SrqsInquireSmartRespondentResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsNegotiationNotification:
                return Eurex.Eti.v130.SrqsNegotiationNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsNegotiationRequesterNotification:
                return Eurex.Eti.v130.SrqsNegotiationRequesterNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsNegotiationStatusNotification:
                return Eurex.Eti.v130.SrqsNegotiationStatusNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsOpenNegotiationNotification:
                return Eurex.Eti.v130.SrqsOpenNegotiationNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsOpenNegotiationRequest:
                return Eurex.Eti.v130.SrqsOpenNegotiationRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsOpenNegotiationRequesterNotification:
                return Eurex.Eti.v130.SrqsOpenNegotiationRequesterNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsQuoteNotification:
                return Eurex.Eti.v130.SrqsQuoteNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsQuoteResponse:
                return Eurex.Eti.v130.SrqsQuoteResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsQuoteSnapshotNotification:
                return Eurex.Eti.v130.SrqsQuoteSnapshotNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsQuoteSnapshotRequest:
                return Eurex.Eti.v130.SrqsQuoteSnapshotRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsQuotingStatusRequest:
                return Eurex.Eti.v130.SrqsQuotingStatusRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsResponse:
                return Eurex.Eti.v130.SrqsResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsStatusBroadcast:
                return Eurex.Eti.v130.SrqsStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsUpdateDealStatusRequest:
                return Eurex.Eti.v130.SrqsUpdateDealStatusRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SrqsUpdateNegotiationRequest:
                return Eurex.Eti.v130.SrqsUpdateNegotiationRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ServiceAvailabilityBroadcast:
                return Eurex.Eti.v130.ServiceAvailabilityBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ServiceAvailabilityMarketBroadcast:
                return Eurex.Eti.v130.ServiceAvailabilityMarketBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.StatusBroadcast:
                return Eurex.Eti.v130.StatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SubscribeRequest:
                return Eurex.Eti.v130.SubscribeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.SubscribeResponse:
                return Eurex.Eti.v130.SubscribeResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesApproveBroadcast:
                return Eurex.Eti.v130.TesApproveBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesBroadcast:
                return Eurex.Eti.v130.TesBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesDeleteBroadcast:
                return Eurex.Eti.v130.TesDeleteBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesExecutionBroadcast:
                return Eurex.Eti.v130.TesExecutionBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesResponse:
                return Eurex.Eti.v130.TesResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesReversalBroadcast:
                return Eurex.Eti.v130.TesReversalBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesTradeBroadcast:
                return Eurex.Eti.v130.TesTradeBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesTradingSessionStatusBroadcast:
                return Eurex.Eti.v130.TesTradingSessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TesUploadBroadcast:
                return Eurex.Eti.v130.TesUploadBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TmTradingSessionStatusBroadcast:
                return Eurex.Eti.v130.TmTradingSessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.ThrottleUpdateNotification:
                return Eurex.Eti.v130.ThrottleUpdateNotification.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TradeBroadcast:
                return Eurex.Eti.v130.TradeBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.TradingSessionStatusBroadcast:
                return Eurex.Eti.v130.TradingSessionStatusBroadcast.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UnsubscribeRequest:
                return Eurex.Eti.v130.UnsubscribeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UnsubscribeResponse:
                return Eurex.Eti.v130.UnsubscribeResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UpdateRemainingRiskAllowanceBaseRequest:
                return Eurex.Eti.v130.UpdateRemainingRiskAllowanceBaseRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UpdateRemainingRiskAllowanceBaseResponse:
                return Eurex.Eti.v130.UpdateRemainingRiskAllowanceBaseResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UploadTesTradeRequest:
                return Eurex.Eti.v130.UploadTesTradeRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UserLoginRequest:
                return Eurex.Eti.v130.UserLoginRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UserLoginRequestEncrypted:
                return Eurex.Eti.v130.UserLoginRequestEncrypted.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UserLoginResponse:
                return Eurex.Eti.v130.UserLoginResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UserLogoutRequest:
                return Eurex.Eti.v130.UserLogoutRequest.Decode(ref message, pointer, offset, bodyLen, ref current);

            case Eurex.Eti.v130.TemplateId.UserLogoutResponse:
                return Eurex.Eti.v130.UserLogoutResponse.Decode(ref message, pointer, offset, bodyLen, ref current);

            default:
                return FixErrorCode.Decode;
        }
    }
};
