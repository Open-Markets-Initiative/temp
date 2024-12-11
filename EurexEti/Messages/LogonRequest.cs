using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Logon Request Message Methods
    /// </summary>

    public static partial class LogonRequest
    {
        /// <summary>
        ///  Eti Identifier for Logon Request
        /// </summary>
        public const string Identifier = "10000";

        /// <summary>
        ///  Encode Logon Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.LogonRequest, out current);

            // --- encode logon request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            if (message.TryGetInt(HeartBtInt.FixTag, out var heartBtInt))
            {
                HeartBtInt.Encode(pointer, current, (uint)heartBtInt, out current);
            }
            else
            {
                HeartBtInt.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdSessionId.FixTag, out var partyIdSessionId))
            {
                PartyIdSessionId.Encode(pointer, current, (uint)partyIdSessionId, out current);
            }
            else
            {
                PartyIdSessionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(DefaultCstmApplVerId.FixTag, out var defaultCstmApplVerId))
            {
                DefaultCstmApplVerId.Encode(pointer, current, defaultCstmApplVerId, out current);
            }
            else
            {
                DefaultCstmApplVerId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(Password.FixTag, out var password))
            {
                Password.Encode(pointer, current, password, out current);
            }
            else
            {
                Password.SetNull(pointer, current, out current);
            }

            var applUsageOrders = message.GetToken(ApplUsageOrders.FixTag);
            ApplUsageOrders.Encode(pointer, current, applUsageOrders, out current);

            var applUsageQuotes = message.GetToken(ApplUsageQuotes.FixTag);
            ApplUsageQuotes.Encode(pointer, current, applUsageQuotes, out current);

            var orderRoutingIndicator = message.GetToken(OrderRoutingIndicator.FixTag);
            OrderRoutingIndicator.Encode(pointer, current, orderRoutingIndicator, out current);

            if (message.TryGetString(FixEngineName.FixTag, out var fixEngineName))
            {
                FixEngineName.Encode(pointer, current, fixEngineName, out current);
            }
            else
            {
                FixEngineName.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FixEngineVersion.FixTag, out var fixEngineVersion))
            {
                FixEngineVersion.Encode(pointer, current, fixEngineVersion, out current);
            }
            else
            {
                FixEngineVersion.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FixEngineVendor.FixTag, out var fixEngineVendor))
            {
                FixEngineVendor.Encode(pointer, current, fixEngineVendor, out current);
            }
            else
            {
                FixEngineVendor.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ApplicationSystemName.FixTag, out var applicationSystemName))
            {
                ApplicationSystemName.Encode(pointer, current, applicationSystemName, out current);
            }
            else
            {
                ApplicationSystemName.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ApplicationSystemVersion.FixTag, out var applicationSystemVersion))
            {
                ApplicationSystemVersion.Encode(pointer, current, applicationSystemVersion, out current);
            }
            else
            {
                ApplicationSystemVersion.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ApplicationSystemVendor.FixTag, out var applicationSystemVendor))
            {
                ApplicationSystemVendor.Encode(pointer, current, applicationSystemVendor, out current);
            }
            else
            {
                ApplicationSystemVendor.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Logon Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = LogonRequest.Identifier;

            // --- decode logon request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (HeartBtInt.TryDecode(pointer, current, out var heartBtInt, out current))
            {
                message.AppendInt(HeartBtInt.FixTag, (int)heartBtInt);
            }

            if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
            {
                message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
            }

            if (DefaultCstmApplVerId.TryDecode(pointer, current, out var defaultCstmApplVerId, out current))
            {
                message.AppendString(DefaultCstmApplVerId.FixTag, defaultCstmApplVerId);
            }

            if (Password.TryDecode(pointer, current, out var password, out current))
            {
                message.AppendString(Password.FixTag, password);
            }

            var applUsageOrders = ApplUsageOrders.Decode(pointer, current, out current);
            message.AppendToken(ApplUsageOrders.FixTag, applUsageOrders);

            var applUsageQuotes = ApplUsageQuotes.Decode(pointer, current, out current);
            message.AppendToken(ApplUsageQuotes.FixTag, applUsageQuotes);

            var orderRoutingIndicator = OrderRoutingIndicator.Decode(pointer, current, out current);
            message.AppendToken(OrderRoutingIndicator.FixTag, orderRoutingIndicator);

            if (FixEngineName.TryDecode(pointer, current, out var fixEngineName, out current))
            {
                message.AppendString(FixEngineName.FixTag, fixEngineName);
            }

            if (FixEngineVersion.TryDecode(pointer, current, out var fixEngineVersion, out current))
            {
                message.AppendString(FixEngineVersion.FixTag, fixEngineVersion);
            }

            if (FixEngineVendor.TryDecode(pointer, current, out var fixEngineVendor, out current))
            {
                message.AppendString(FixEngineVendor.FixTag, fixEngineVendor);
            }

            if (ApplicationSystemName.TryDecode(pointer, current, out var applicationSystemName, out current))
            {
                message.AppendString(ApplicationSystemName.FixTag, applicationSystemName);
            }

            if (ApplicationSystemVersion.TryDecode(pointer, current, out var applicationSystemVersion, out current))
            {
                message.AppendString(ApplicationSystemVersion.FixTag, applicationSystemVersion);
            }

            if (ApplicationSystemVendor.TryDecode(pointer, current, out var applicationSystemVendor, out current))
            {
                message.AppendString(ApplicationSystemVendor.FixTag, applicationSystemVendor);
            }

            current += Pad3.Length;

            return FixErrorCode.None;
        }
    }
}