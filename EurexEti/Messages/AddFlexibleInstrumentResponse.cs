using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Add Flexible Instrument Response Message Methods
/// </summary>

public static partial class AddFlexibleInstrumentResponse
{
    /// <summary>
    ///  Eti Identifier for Add Flexible Instrument Response
    /// </summary>
    public const string Identifier = "10310";

    /// <summary>
    ///  Encode Add Flexible Instrument Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.AddFlexibleInstrumentResponse, out current);

        // --- encode add flexible instrument response message ---

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

        if (message.TryGetULong(SecurityResponseId.FixTag, out var securityResponseId))
        {
            SecurityResponseId.Encode(pointer, current, securityResponseId, out current);
        }
        else
        {
            SecurityResponseId.SetNull(pointer, current, out current);
        }

        if (message.TryGetLong(SecurityId.FixTag, out var securityId))
        {
            SecurityId.Encode(pointer, current, securityId, out current);
        }
        else
        {
            SecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(StrikePrice.FixTag, out var strikePrice))
        {
            StrikePrice.Encode(pointer, current, strikePrice, out current);
        }
        else
        {
            StrikePrice.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MaturityDate.FixTag, out var maturityDate))
        {
            MaturityDate.Encode(pointer, current, (uint)maturityDate, out current);
        }
        else
        {
            MaturityDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ContractDate.FixTag, out var contractDate))
        {
            ContractDate.Encode(pointer, current, (uint)contractDate, out current);
        }
        else
        {
            ContractDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        var settlMethod = message.GetToken(SettlMethod.FixTag);
        SettlMethod.Encode(pointer, current, settlMethod, out current);

        if (message.TryGetInt(OptAttribute.FixTag, out var optAttribute))
        {
            OptAttribute.Encode(pointer, current, (byte)optAttribute, out current);
        }
        else
        {
            OptAttribute.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PutOrCall.FixTag, out var putOrCall))
        {
            PutOrCall.Encode(pointer, current, (byte)putOrCall, out current);
        }
        else
        {
            PutOrCall.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExerciseStyle.FixTag, out var exerciseStyle))
        {
            ExerciseStyle.Encode(pointer, current, (byte)exerciseStyle, out current);
        }
        else
        {
            ExerciseStyle.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Add Flexible Instrument Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = AddFlexibleInstrumentResponse.Identifier;

        // --- decode add flexible instrument response message ---

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

        if (SecurityResponseId.TryDecode(pointer, current, out var securityResponseId, out current))
        {
            message.AppendULong(SecurityResponseId.FixTag, securityResponseId);
        }

        if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
        {
            message.AppendLong(SecurityId.FixTag, securityId);
        }

        if (StrikePrice.TryDecode(pointer, current, out var strikePrice, out current))
        {
            message.AppendDouble(StrikePrice.FixTag, strikePrice);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (MaturityDate.TryDecode(pointer, current, out var maturityDate, out current))
        {
            message.AppendInt(MaturityDate.FixTag, (int)maturityDate);
        }

        if (ContractDate.TryDecode(pointer, current, out var contractDate, out current))
        {
            message.AppendInt(ContractDate.FixTag, (int)contractDate);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        var settlMethod = SettlMethod.Decode(pointer, current, out current);
        message.AppendToken(SettlMethod.FixTag, settlMethod);

        if (OptAttribute.TryDecode(pointer, current, out var optAttribute, out current))
        {
            message.AppendInt(OptAttribute.FixTag, optAttribute);
        }

        if (PutOrCall.TryDecode(pointer, current, out var putOrCall, out current))
        {
            message.AppendInt(PutOrCall.FixTag, putOrCall);
        }

        if (ExerciseStyle.TryDecode(pointer, current, out var exerciseStyle, out current))
        {
            message.AppendInt(ExerciseStyle.FixTag, exerciseStyle);
        }

        current += Pad7.Length;

        return FixErrorCode.None;
    }
}
