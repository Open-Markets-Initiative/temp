namespace SRFixBase
{
    public static partial class Eti130
    {
        /// <summary>
        ///  Decode Eti Binary to Fix Binary
        /// </summary>
        public unsafe static FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- eti message header ---

            var bodyLen = Eurex.EtiDerivatives.v121.BodyLen.Decode(pointer, current, out current);

            if (bodyLen + offset > length)
            {
                current = offset;

                return FixErrorCode.PartialMessage;
            }

            var templateId = Eurex.EtiDerivatives.v121.TemplateId.Decode(pointer, current, out current);

            switch (templateId)
            {
                case Eurex.EtiDerivatives.v121.TemplateId.AddComplexInstrumentRequest:
                    return Eurex.EtiDerivatives.v121.AddComplexInstrumentRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.AddComplexInstrumentResponse:
                    return Eurex.EtiDerivatives.v121.AddComplexInstrumentResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.AddFlexibleInstrumentRequest:
                    return Eurex.EtiDerivatives.v121.AddFlexibleInstrumentRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.AddFlexibleInstrumentResponse:
                    return Eurex.EtiDerivatives.v121.AddFlexibleInstrumentResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.AddScaledSimpleInstrumentRequest:
                    return Eurex.EtiDerivatives.v121.AddScaledSimpleInstrumentRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.AddScaledSimpleInstrumentResponse:
                    return Eurex.EtiDerivatives.v121.AddScaledSimpleInstrumentResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.AmendBasketTradeRequest:
                    return Eurex.EtiDerivatives.v121.AmendBasketTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ApproveBasketTradeRequest:
                    return Eurex.EtiDerivatives.v121.ApproveBasketTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ApproveReverseTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.ApproveReverseTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ApproveTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.ApproveTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.BasketApproveBroadcast:
                    return Eurex.EtiDerivatives.v121.BasketApproveBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.BasketBroadcast:
                    return Eurex.EtiDerivatives.v121.BasketBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.BasketDeleteBroadcast:
                    return Eurex.EtiDerivatives.v121.BasketDeleteBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.BasketExecutionBroadcast:
                    return Eurex.EtiDerivatives.v121.BasketExecutionBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.BasketResponse:
                    return Eurex.EtiDerivatives.v121.BasketResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.BroadcastErrorNotification:
                    return Eurex.EtiDerivatives.v121.BroadcastErrorNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ClipDeletionNotification:
                    return Eurex.EtiDerivatives.v121.ClipDeletionNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ClipExecutionNotification:
                    return Eurex.EtiDerivatives.v121.ClipExecutionNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ClipResponse:
                    return Eurex.EtiDerivatives.v121.ClipResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.CrossRequest:
                    return Eurex.EtiDerivatives.v121.CrossRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.CrossRequestResponse:
                    return Eurex.EtiDerivatives.v121.CrossRequestResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllOrderBroadcast:
                    return Eurex.EtiDerivatives.v121.DeleteAllOrderBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllOrderNrResponse:
                    return Eurex.EtiDerivatives.v121.DeleteAllOrderNrResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllOrderQuoteEventBroadcast:
                    return Eurex.EtiDerivatives.v121.DeleteAllOrderQuoteEventBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllOrderRequest:
                    return Eurex.EtiDerivatives.v121.DeleteAllOrderRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllOrderResponse:
                    return Eurex.EtiDerivatives.v121.DeleteAllOrderResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllQuoteBroadcast:
                    return Eurex.EtiDerivatives.v121.DeleteAllQuoteBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllQuoteRequest:
                    return Eurex.EtiDerivatives.v121.DeleteAllQuoteRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteAllQuoteResponse:
                    return Eurex.EtiDerivatives.v121.DeleteAllQuoteResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteBasketTradeRequest:
                    return Eurex.EtiDerivatives.v121.DeleteBasketTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteClipRequest:
                    return Eurex.EtiDerivatives.v121.DeleteClipRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteOrderBroadcast:
                    return Eurex.EtiDerivatives.v121.DeleteOrderBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteOrderComplexRequest:
                    return Eurex.EtiDerivatives.v121.DeleteOrderComplexRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteOrderNrResponse:
                    return Eurex.EtiDerivatives.v121.DeleteOrderNrResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteOrderRequest:
                    return Eurex.EtiDerivatives.v121.DeleteOrderRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteOrderResponse:
                    return Eurex.EtiDerivatives.v121.DeleteOrderResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteOrderSingleRequest:
                    return Eurex.EtiDerivatives.v121.DeleteOrderSingleRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.DeleteTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.DeleteTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.EnterBasketTradeRequest:
                    return Eurex.EtiDerivatives.v121.EnterBasketTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.EnterClipRequest:
                    return Eurex.EtiDerivatives.v121.EnterClipRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.EnterTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.EnterTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ForcedLogoutNotification:
                    return Eurex.EtiDerivatives.v121.ForcedLogoutNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ForcedUserLogoutNotification:
                    return Eurex.EtiDerivatives.v121.ForcedUserLogoutNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.Heartbeat:
                    return Eurex.EtiDerivatives.v121.Heartbeat.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.HeartbeatNotification:
                    return Eurex.EtiDerivatives.v121.HeartbeatNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireEnrichmentRuleIdListRequest:
                    return Eurex.EtiDerivatives.v121.InquireEnrichmentRuleIdListRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireEnrichmentRuleIdListResponse:
                    return Eurex.EtiDerivatives.v121.InquireEnrichmentRuleIdListResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireMmParameterRequest:
                    return Eurex.EtiDerivatives.v121.InquireMmParameterRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireMmParameterResponse:
                    return Eurex.EtiDerivatives.v121.InquireMmParameterResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireMarginBasedRiskLimitRequest:
                    return Eurex.EtiDerivatives.v121.InquireMarginBasedRiskLimitRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireMarginBasedRiskLimitResponse:
                    return Eurex.EtiDerivatives.v121.InquireMarginBasedRiskLimitResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquirePreTradeRiskLimitsRequest:
                    return Eurex.EtiDerivatives.v121.InquirePreTradeRiskLimitsRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireSessionListRequest:
                    return Eurex.EtiDerivatives.v121.InquireSessionListRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireSessionListResponse:
                    return Eurex.EtiDerivatives.v121.InquireSessionListResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireUserRequest:
                    return Eurex.EtiDerivatives.v121.InquireUserRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.InquireUserResponse:
                    return Eurex.EtiDerivatives.v121.InquireUserResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.LegalNotificationBroadcast:
                    return Eurex.EtiDerivatives.v121.LegalNotificationBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.LogonRequest:
                    return Eurex.EtiDerivatives.v121.LogonRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.LogonRequestEncrypted:
                    return Eurex.EtiDerivatives.v121.LogonRequestEncrypted.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.LogonResponse:
                    return Eurex.EtiDerivatives.v121.LogonResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.LogoutRequest:
                    return Eurex.EtiDerivatives.v121.LogoutRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.LogoutResponse:
                    return Eurex.EtiDerivatives.v121.LogoutResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.MmParameterDefinitionRequest:
                    return Eurex.EtiDerivatives.v121.MmParameterDefinitionRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.MmParameterDefinitionResponse:
                    return Eurex.EtiDerivatives.v121.MmParameterDefinitionResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.MassOrder:
                    return Eurex.EtiDerivatives.v121.MassOrder.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.MassOrderAck:
                    return Eurex.EtiDerivatives.v121.MassOrderAck.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.MassQuoteRequest:
                    return Eurex.EtiDerivatives.v121.MassQuoteRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.MassQuoteResponse:
                    return Eurex.EtiDerivatives.v121.MassQuoteResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyBasketTradeRequest:
                    return Eurex.EtiDerivatives.v121.ModifyBasketTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderComplexRequest:
                    return Eurex.EtiDerivatives.v121.ModifyOrderComplexRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderComplexShortRequest:
                    return Eurex.EtiDerivatives.v121.ModifyOrderComplexShortRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderNrResponse:
                    return Eurex.EtiDerivatives.v121.ModifyOrderNrResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderRequest:
                    return Eurex.EtiDerivatives.v121.ModifyOrderRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderResponse:
                    return Eurex.EtiDerivatives.v121.ModifyOrderResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderShortRequest:
                    return Eurex.EtiDerivatives.v121.ModifyOrderShortRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderSingleRequest:
                    return Eurex.EtiDerivatives.v121.ModifyOrderSingleRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyOrderSingleShortRequest:
                    return Eurex.EtiDerivatives.v121.ModifyOrderSingleShortRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ModifyTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.ModifyTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderComplexRequest:
                    return Eurex.EtiDerivatives.v121.NewOrderComplexRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderComplexShortRequest:
                    return Eurex.EtiDerivatives.v121.NewOrderComplexShortRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderNrResponse:
                    return Eurex.EtiDerivatives.v121.NewOrderNrResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderRequest:
                    return Eurex.EtiDerivatives.v121.NewOrderRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderResponse:
                    return Eurex.EtiDerivatives.v121.NewOrderResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderShortRequest:
                    return Eurex.EtiDerivatives.v121.NewOrderShortRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderSingleRequest:
                    return Eurex.EtiDerivatives.v121.NewOrderSingleRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewOrderSingleShortRequest:
                    return Eurex.EtiDerivatives.v121.NewOrderSingleShortRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.NewsBroadcast:
                    return Eurex.EtiDerivatives.v121.NewsBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.OrderExecNotification:
                    return Eurex.EtiDerivatives.v121.OrderExecNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.OrderExecReportBroadcast:
                    return Eurex.EtiDerivatives.v121.OrderExecReportBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.OrderExecResponse:
                    return Eurex.EtiDerivatives.v121.OrderExecResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.PartyActionReport:
                    return Eurex.EtiDerivatives.v121.PartyActionReport.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.PartyEntitlementsUpdateReport:
                    return Eurex.EtiDerivatives.v121.PartyEntitlementsUpdateReport.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.PingRequest:
                    return Eurex.EtiDerivatives.v121.PingRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.PingResponse:
                    return Eurex.EtiDerivatives.v121.PingResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.PreTradeRiskLimitResponse:
                    return Eurex.EtiDerivatives.v121.PreTradeRiskLimitResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.PreTradeRiskLimitsDefinitionRequest:
                    return Eurex.EtiDerivatives.v121.PreTradeRiskLimitsDefinitionRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.QuoteActivationNotification:
                    return Eurex.EtiDerivatives.v121.QuoteActivationNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.QuoteActivationRequest:
                    return Eurex.EtiDerivatives.v121.QuoteActivationRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.QuoteActivationResponse:
                    return Eurex.EtiDerivatives.v121.QuoteActivationResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.QuoteExecutionReport:
                    return Eurex.EtiDerivatives.v121.QuoteExecutionReport.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RfqRequest:
                    return Eurex.EtiDerivatives.v121.RfqRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RfqResponse:
                    return Eurex.EtiDerivatives.v121.RfqResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.Reject:
                    return Eurex.EtiDerivatives.v121.Reject.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RetransmitMeMessageRequest:
                    return Eurex.EtiDerivatives.v121.RetransmitMeMessageRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RetransmitMeMessageResponse:
                    return Eurex.EtiDerivatives.v121.RetransmitMeMessageResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RetransmitRequest:
                    return Eurex.EtiDerivatives.v121.RetransmitRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RetransmitResponse:
                    return Eurex.EtiDerivatives.v121.RetransmitResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ReverseTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.ReverseTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.RiskNotificationBroadcast:
                    return Eurex.EtiDerivatives.v121.RiskNotificationBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsCreateDealNotification:
                    return Eurex.EtiDerivatives.v121.SrqsCreateDealNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsDealNotification:
                    return Eurex.EtiDerivatives.v121.SrqsDealNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsDealResponse:
                    return Eurex.EtiDerivatives.v121.SrqsDealResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsEnterQuoteRequest:
                    return Eurex.EtiDerivatives.v121.SrqsEnterQuoteRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsHitQuoteRequest:
                    return Eurex.EtiDerivatives.v121.SrqsHitQuoteRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsInquireSmartRespondentRequest:
                    return Eurex.EtiDerivatives.v121.SrqsInquireSmartRespondentRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsInquireSmartRespondentResponse:
                    return Eurex.EtiDerivatives.v121.SrqsInquireSmartRespondentResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsNegotiationNotification:
                    return Eurex.EtiDerivatives.v121.SrqsNegotiationNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsNegotiationRequesterNotification:
                    return Eurex.EtiDerivatives.v121.SrqsNegotiationRequesterNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsNegotiationStatusNotification:
                    return Eurex.EtiDerivatives.v121.SrqsNegotiationStatusNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsOpenNegotiationNotification:
                    return Eurex.EtiDerivatives.v121.SrqsOpenNegotiationNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsOpenNegotiationRequest:
                    return Eurex.EtiDerivatives.v121.SrqsOpenNegotiationRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsOpenNegotiationRequesterNotification:
                    return Eurex.EtiDerivatives.v121.SrqsOpenNegotiationRequesterNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsQuoteNotification:
                    return Eurex.EtiDerivatives.v121.SrqsQuoteNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsQuoteResponse:
                    return Eurex.EtiDerivatives.v121.SrqsQuoteResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsQuoteSnapshotNotification:
                    return Eurex.EtiDerivatives.v121.SrqsQuoteSnapshotNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsQuoteSnapshotRequest:
                    return Eurex.EtiDerivatives.v121.SrqsQuoteSnapshotRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsQuotingStatusRequest:
                    return Eurex.EtiDerivatives.v121.SrqsQuotingStatusRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsResponse:
                    return Eurex.EtiDerivatives.v121.SrqsResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsStatusBroadcast:
                    return Eurex.EtiDerivatives.v121.SrqsStatusBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsUpdateDealStatusRequest:
                    return Eurex.EtiDerivatives.v121.SrqsUpdateDealStatusRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SrqsUpdateNegotiationRequest:
                    return Eurex.EtiDerivatives.v121.SrqsUpdateNegotiationRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ServiceAvailabilityBroadcast:
                    return Eurex.EtiDerivatives.v121.ServiceAvailabilityBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ServiceAvailabilityMarketBroadcast:
                    return Eurex.EtiDerivatives.v121.ServiceAvailabilityMarketBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.StatusBroadcast:
                    return Eurex.EtiDerivatives.v121.StatusBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SubscribeRequest:
                    return Eurex.EtiDerivatives.v121.SubscribeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.SubscribeResponse:
                    return Eurex.EtiDerivatives.v121.SubscribeResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesApproveBroadcast:
                    return Eurex.EtiDerivatives.v121.TesApproveBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesBroadcast:
                    return Eurex.EtiDerivatives.v121.TesBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesDeleteBroadcast:
                    return Eurex.EtiDerivatives.v121.TesDeleteBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesExecutionBroadcast:
                    return Eurex.EtiDerivatives.v121.TesExecutionBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesResponse:
                    return Eurex.EtiDerivatives.v121.TesResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesReversalBroadcast:
                    return Eurex.EtiDerivatives.v121.TesReversalBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesTradeBroadcast:
                    return Eurex.EtiDerivatives.v121.TesTradeBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesTradingSessionStatusBroadcast:
                    return Eurex.EtiDerivatives.v121.TesTradingSessionStatusBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TesUploadBroadcast:
                    return Eurex.EtiDerivatives.v121.TesUploadBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TmTradingSessionStatusBroadcast:
                    return Eurex.EtiDerivatives.v121.TmTradingSessionStatusBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.ThrottleUpdateNotification:
                    return Eurex.EtiDerivatives.v121.ThrottleUpdateNotification.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TradeBroadcast:
                    return Eurex.EtiDerivatives.v121.TradeBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.TradingSessionStatusBroadcast:
                    return Eurex.EtiDerivatives.v121.TradingSessionStatusBroadcast.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UnsubscribeRequest:
                    return Eurex.EtiDerivatives.v121.UnsubscribeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UnsubscribeResponse:
                    return Eurex.EtiDerivatives.v121.UnsubscribeResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UpdateRemainingRiskAllowanceBaseRequest:
                    return Eurex.EtiDerivatives.v121.UpdateRemainingRiskAllowanceBaseRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UpdateRemainingRiskAllowanceBaseResponse:
                    return Eurex.EtiDerivatives.v121.UpdateRemainingRiskAllowanceBaseResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UploadTesTradeRequest:
                    return Eurex.EtiDerivatives.v121.UploadTesTradeRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UserLoginRequest:
                    return Eurex.EtiDerivatives.v121.UserLoginRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UserLoginRequestEncrypted:
                    return Eurex.EtiDerivatives.v121.UserLoginRequestEncrypted.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UserLoginResponse:
                    return Eurex.EtiDerivatives.v121.UserLoginResponse.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UserLogoutRequest:
                    return Eurex.EtiDerivatives.v121.UserLogoutRequest.Decode(ref message, pointer, current, out current);

                case Eurex.EtiDerivatives.v121.TemplateId.UserLogoutResponse:
                    return Eurex.EtiDerivatives.v121.UserLogoutResponse.Decode(ref message, pointer, current, out current);

                default:
                    return FixErrorCode.Decode;
            }
        }
    };
}