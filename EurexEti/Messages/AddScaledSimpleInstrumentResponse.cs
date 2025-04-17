using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Add Scaled Simple Instrument Response Message Methods
/// </summary>

public static partial class AddScaledSimpleInstrumentResponse
{
    /// <summary>
    ///  Eti Identifier for Add Scaled Simple Instrument Response
    /// </summary>
    public const string Identifier = "10328";

    /// <summary>
    ///  Encode Add Scaled Simple Instrument Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.AddScaledSimpleInstrumentResponse, out current);

        // --- encode add scaled simple instrument response message ---

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeIn.FixTag, out var trdRegTsTimeIn))
        {
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);
        }
        else
        {
            TrdRegTsTimeIn.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
        {
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
        }
        else
        {
            TrdRegTsTimeOut.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ResponseIn.FixTag, out var responseIn))
        {
            ResponseIn.Encode(pointer, current, responseIn, out current);
        }
        else
        {
            ResponseIn.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (message.TryGetLong(RelatedSecurityId.FixTag, out var relatedSecurityId))
        {
            RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);
        }
        else
        {
            RelatedSecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetLong(SecurityId.FixTag, out var securityId))
        {
            SecurityId.Encode(pointer, current, securityId, out current);
        }
        else
        {
            SecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(LastUpdateTime.FixTag, out var lastUpdateTime))
        {
            LastUpdateTime.Encode(pointer, current, lastUpdateTime, out current);
        }
        else
        {
            LastUpdateTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(SecurityResponseId.FixTag, out var securityResponseId))
        {
            SecurityResponseId.Encode(pointer, current, securityResponseId, out current);
        }
        else
        {
            SecurityResponseId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(QuantityScalingFactor.FixTag, out var quantityScalingFactor))
        {
            QuantityScalingFactor.Encode(pointer, current, (ushort)quantityScalingFactor, out current);
        }
        else
        {
            QuantityScalingFactor.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MultilegModel.FixTag, out var multilegModel))
        {
            MultilegModel.Encode(pointer, current, (byte)multilegModel, out current);
        }
        else
        {
            MultilegModel.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ImpliedMarketIndicator.FixTag, out var impliedMarketIndicator))
        {
            ImpliedMarketIndicator.Encode(pointer, current, (byte)impliedMarketIndicator, out current);
        }
        else
        {
            ImpliedMarketIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Add Scaled Simple Instrument Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = AddScaledSimpleInstrumentResponse.Identifier;

        // --- decode add scaled simple instrument response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (TrdRegTsTimeIn.TryDecode(pointer, current, out var trdRegTsTimeIn, out current))
        {
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);
        }

        if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
        {
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
        }

        if (ResponseIn.TryDecode(pointer, current, out var responseIn, out current))
        {
            message.AppendULong(ResponseIn.FixTag, responseIn);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad3.Length;

        if (RelatedSecurityId.TryDecode(pointer, current, out var relatedSecurityId, out current))
        {
            message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);
        }

        if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
        {
            message.AppendLong(SecurityId.FixTag, securityId);
        }

        if (LastUpdateTime.TryDecode(pointer, current, out var lastUpdateTime, out current))
        {
            message.AppendULong(LastUpdateTime.FixTag, lastUpdateTime);
        }

        if (SecurityResponseId.TryDecode(pointer, current, out var securityResponseId, out current))
        {
            message.AppendULong(SecurityResponseId.FixTag, securityResponseId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (QuantityScalingFactor.TryDecode(pointer, current, out var quantityScalingFactor, out current))
        {
            message.AppendInt(QuantityScalingFactor.FixTag, (short)quantityScalingFactor);
        }

        if (MultilegModel.TryDecode(pointer, current, out var multilegModel, out current))
        {
            message.AppendInt(MultilegModel.FixTag, multilegModel);
        }

        if (ImpliedMarketIndicator.TryDecode(pointer, current, out var impliedMarketIndicator, out current))
        {
            message.AppendInt(ImpliedMarketIndicator.FixTag, impliedMarketIndicator);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        current += Pad7.Length;

        return FixErrorCode.None;
    }
}
