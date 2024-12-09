using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Logon Response Message Methods
    /// </summary>

    public static partial class LogonResponse
    {
        /// <summary>
        ///  Eti Identifier for Logon Response
        /// </summary>
        public const string Identifier = "10001";

        /// <summary>
        ///  Encode Logon Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.LogonResponse, out current);

            // --- encode logon response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var throttleTimeInterval = message.GetLong(ThrottleTimeInterval.FixTag);
            ThrottleTimeInterval.Encode(pointer, current, throttleTimeInterval, out current);

            var throttleNoMsgs = (uint)message.GetInt(ThrottleNoMsgs.FixTag);
            ThrottleNoMsgs.Encode(pointer, current, throttleNoMsgs, out current);

            var throttleDisconnectLimit = (uint)message.GetInt(ThrottleDisconnectLimit.FixTag);
            ThrottleDisconnectLimit.Encode(pointer, current, throttleDisconnectLimit, out current);

            var heartBtInt = (uint)message.GetInt(HeartBtInt.FixTag);
            HeartBtInt.Encode(pointer, current, heartBtInt, out current);

            var sessionInstanceId = (uint)message.GetInt(SessionInstanceId.FixTag);
            SessionInstanceId.Encode(pointer, current, sessionInstanceId, out current);

            var latestPublicKeySeqNo = (uint)message.GetInt(LatestPublicKeySeqNo.FixTag);
            LatestPublicKeySeqNo.Encode(pointer, current, latestPublicKeySeqNo, out current);

            var isPublicKey = message.TryGetString(PublicKey.FixTag, out var publicKey);
            if (isPublicKey)
            {
                var publicKeyLen = (ushort)publicKey.Length;
                PublicKeyLen.Encode(pointer, current, publicKeyLen, out current);
            }
            else
            {
                PublicKeyLen.Zero(pointer, current, out current);
            }

            var marketId = (ushort)message.GetInt(MarketId.FixTag);
            MarketId.Encode(pointer, current, marketId, out current);

            var tradSesMode = (byte)message.GetInt(TradSesMode.FixTag);
            TradSesMode.Encode(pointer, current, tradSesMode, out current);

            if (message.TryGetString(DefaultCstmApplVerId.FixTag, out var defaultCstmApplVerId))
            {
                DefaultCstmApplVerId.Encode(pointer, current, defaultCstmApplVerId, out current);
            }
            else
            {
                DefaultCstmApplVerId.SetNull(pointer, current, out current);
            }

            if (message.TryGetToken(DefaultCstmApplVerSubId.FixTag, out var defaultCstmApplVerSubId))
            {
                DefaultCstmApplVerSubId.Encode(pointer, current, defaultCstmApplVerSubId, out current);
            }
            else
            {
                DefaultCstmApplVerSubId.SetNull(pointer, current, out current);
            }

            if (isPublicKey)
            {
                PublicKey.Encode(pointer, current, publicKey, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Logon Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = LogonResponse.Identifier;

            // --- decode logon response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            current += Pad4.Length;

            var throttleTimeInterval = ThrottleTimeInterval.Decode(pointer, current, out current);
            message.AppendLong(ThrottleTimeInterval.FixTag, throttleTimeInterval);

            var throttleNoMsgs = (int)ThrottleNoMsgs.Decode(pointer, current, out current);
            message.AppendInt(ThrottleNoMsgs.FixTag, throttleNoMsgs);

            var throttleDisconnectLimit = (int)ThrottleDisconnectLimit.Decode(pointer, current, out current);
            message.AppendInt(ThrottleDisconnectLimit.FixTag, throttleDisconnectLimit);

            var heartBtInt = (int)HeartBtInt.Decode(pointer, current, out current);
            message.AppendInt(HeartBtInt.FixTag, heartBtInt);

            var sessionInstanceId = (int)SessionInstanceId.Decode(pointer, current, out current);
            message.AppendInt(SessionInstanceId.FixTag, sessionInstanceId);

            var latestPublicKeySeqNo = (int)LatestPublicKeySeqNo.Decode(pointer, current, out current);
            message.AppendInt(LatestPublicKeySeqNo.FixTag, latestPublicKeySeqNo);

            var publicKeyLen = PublicKeyLen.Decode(pointer, current, out current);

            var marketId = (short)MarketId.Decode(pointer, current, out current);
            message.AppendInt(MarketId.FixTag, marketId);

            var tradSesMode = TradSesMode.Decode(pointer, current, out current);
            message.AppendInt(TradSesMode.FixTag, tradSesMode);

            if (DefaultCstmApplVerId.TryDecode(pointer, current, out var defaultCstmApplVerId, out current))
            {
                message.AppendString(DefaultCstmApplVerId.FixTag, defaultCstmApplVerId);
            }

            if (DefaultCstmApplVerSubId.TryDecode(pointer, current, out var defaultCstmApplVerSubId, out current))
            {
                message.AppendToken(DefaultCstmApplVerSubId.FixTag, defaultCstmApplVerSubId);
            }

            if (PublicKey.TryDecode(pointer, current, publicKeyLen, out var publicKey, out current))
            {
                message.AppendString(PublicKey.FixTag, publicKey);
            }

            return FixErrorCode.None;
        }
    }
}