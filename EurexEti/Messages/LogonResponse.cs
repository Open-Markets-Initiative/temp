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

            if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
            {
                RequestTime.Encode(pointer, current, requestTime, out current);
            }
            else
            {
                RequestTime.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            if (message.TryGetLong(ThrottleTimeInterval.FixTag, out var throttleTimeInterval))
            {
                ThrottleTimeInterval.Encode(pointer, current, throttleTimeInterval, out current);
            }
            else
            {
                ThrottleTimeInterval.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ThrottleNoMsgs.FixTag, out var throttleNoMsgs))
            {
                ThrottleNoMsgs.Encode(pointer, current, (uint)throttleNoMsgs, out current);
            }
            else
            {
                ThrottleNoMsgs.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ThrottleDisconnectLimit.FixTag, out var throttleDisconnectLimit))
            {
                ThrottleDisconnectLimit.Encode(pointer, current, (uint)throttleDisconnectLimit, out current);
            }
            else
            {
                ThrottleDisconnectLimit.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(HeartBtInt.FixTag, out var heartBtInt))
            {
                HeartBtInt.Encode(pointer, current, (uint)heartBtInt, out current);
            }
            else
            {
                HeartBtInt.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SessionInstanceId.FixTag, out var sessionInstanceId))
            {
                SessionInstanceId.Encode(pointer, current, (uint)sessionInstanceId, out current);
            }
            else
            {
                SessionInstanceId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(LatestPublicKeySeqNo.FixTag, out var latestPublicKeySeqNo))
            {
                LatestPublicKeySeqNo.Encode(pointer, current, (uint)latestPublicKeySeqNo, out current);
            }
            else
            {
                LatestPublicKeySeqNo.SetNull(pointer, current, out current);
            }

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

            if (message.TryGetInt(MarketId.FixTag, out var marketId))
            {
                MarketId.Encode(pointer, current, (ushort)marketId, out current);
            }
            else
            {
                MarketId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradSesMode.FixTag, out var tradSesMode))
            {
                TradSesMode.Encode(pointer, current, (byte)tradSesMode, out current);
            }
            else
            {
                TradSesMode.SetNull(pointer, current, out current);
            }

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

            var alignment = 8 - ((current - offset) % 8);
            if (alignment != 8)
            {
                AlignmentPadding.Encode(pointer, current, alignment, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Logon Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = LogonResponse.Identifier;

            // --- decode logon response message ---

            current += Pad2.Length;

            if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
            {
                message.AppendULong(RequestTime.FixTag, requestTime);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            current += Pad4.Length;

            if (ThrottleTimeInterval.TryDecode(pointer, current, out var throttleTimeInterval, out current))
            {
                message.AppendLong(ThrottleTimeInterval.FixTag, throttleTimeInterval);
            }

            if (ThrottleNoMsgs.TryDecode(pointer, current, out var throttleNoMsgs, out current))
            {
                message.AppendInt(ThrottleNoMsgs.FixTag, (int)throttleNoMsgs);
            }

            if (ThrottleDisconnectLimit.TryDecode(pointer, current, out var throttleDisconnectLimit, out current))
            {
                message.AppendInt(ThrottleDisconnectLimit.FixTag, (int)throttleDisconnectLimit);
            }

            if (HeartBtInt.TryDecode(pointer, current, out var heartBtInt, out current))
            {
                message.AppendInt(HeartBtInt.FixTag, (int)heartBtInt);
            }

            if (SessionInstanceId.TryDecode(pointer, current, out var sessionInstanceId, out current))
            {
                message.AppendInt(SessionInstanceId.FixTag, (int)sessionInstanceId);
            }

            if (LatestPublicKeySeqNo.TryDecode(pointer, current, out var latestPublicKeySeqNo, out current))
            {
                message.AppendInt(LatestPublicKeySeqNo.FixTag, (int)latestPublicKeySeqNo);
            }

            var publicKeyLen = PublicKeyLen.Decode(pointer, current, out current);

            if (MarketId.TryDecode(pointer, current, out var marketId, out current))
            {
                message.AppendInt(MarketId.FixTag, (short)marketId);
            }

            if (TradSesMode.TryDecode(pointer, current, out var tradSesMode, out current))
            {
                message.AppendInt(TradSesMode.FixTag, tradSesMode);
            }

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

            if (length != (current - offset))
            {
                current = offset + length;
            }

            return FixErrorCode.None;
        }
    }
}