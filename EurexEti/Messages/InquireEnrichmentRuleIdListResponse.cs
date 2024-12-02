using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Inquire Enrichment Rule Id List Response Message Methods
    /// </summary>

    public partial class InquireEnrichmentRuleIdListResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire Enrichment Rule Id List Response
        /// </summary>
        public const string Identifier = "Inquire Enrichment Rule Id List Response";

        /// <summary>
        ///  Encode Inquire Enrichment Rule Id List Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireEnrichmentRuleIdListResponse, out current);

            // --- encode inquire enrichment rule id list response message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var lastEntityProcessed = message.GetData(LastEntityProcessed.FixTag);
            LastEntityProcessed.Encode(pointer, current, lastEntityProcessed, out current);

            var noEnrichmentRules = (ushort)message.GetInt(NoEnrichmentRules.FixTag);
            NoEnrichmentRules.Encode(pointer, current, noEnrichmentRules, out current);

            Pad6.Encode(pointer, current, out current);

            var enrichmentRuleId = (ushort)group.GetInt(EnrichmentRuleId.FixTag);
            EnrichmentRuleId.Encode(pointer, current, enrichmentRuleId, out current);

            var partyIdOriginationMarket = (byte)group.GetInt(PartyIdOriginationMarket.FixTag);
            PartyIdOriginationMarket.Encode(pointer, current, partyIdOriginationMarket, out current);

            if (group.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            var positionEffect = group.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
            {
                PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
            }
            else
            {
                PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
            {
                PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
            }
            else
            {
                PartyIdBeneficiary.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText1.FixTag, out var freeText1))
            {
                FreeText1.Encode(pointer, current, freeText1, out current);
            }
            else
            {
                FreeText1.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText2.FixTag, out var freeText2))
            {
                FreeText2.Encode(pointer, current, freeText2, out current);
            }
            else
            {
                FreeText2.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText3.FixTag, out var freeText3))
            {
                FreeText3.Encode(pointer, current, freeText3, out current);
            }
            else
            {
                FreeText3.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Inquire Enrichment Rule Id List Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireEnrichmentRuleIdListResponse.Identifier;

            // --- decode inquire enrichment rule id list response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var lastEntityProcessed = LastEntityProcessed.Decode(pointer, current, out current);
            message.AppendData(LastEntityProcessed.FixTag, lastEntityProcessed);

            var noEnrichmentRules = (short)NoEnrichmentRules.Decode(pointer, current, out current);
            message.AppendInt(NoEnrichmentRules.FixTag, noEnrichmentRules);

            current += Pad6.Length;

            var enrichmentRuleId = (short)EnrichmentRuleId.Decode(pointer, current, out current);
            message.AppendInt(EnrichmentRuleId.FixTag, enrichmentRuleId);

            var partyIdOriginationMarket = PartyIdOriginationMarket.Decode(pointer, current, out current);
            message.AppendInt(PartyIdOriginationMarket.FixTag, partyIdOriginationMarket);

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
            }

            if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
            {
                message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
            }

            if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
            {
                message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
            }

            if (FreeText1.TryDecode(pointer, current, out var freeText1, out current))
            {
                message.AppendString(FreeText1.FixTag, freeText1);
            }

            if (FreeText2.TryDecode(pointer, current, out var freeText2, out current))
            {
                message.AppendString(FreeText2.FixTag, freeText2);
            }

            if (FreeText3.TryDecode(pointer, current, out var freeText3, out current))
            {
                message.AppendString(FreeText3.FixTag, freeText3);
            }

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}