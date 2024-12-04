using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Entry Reject Reason: Enum
    /// </summary>

    public sealed class QuoteEntryRejectReason
    {
        /// <summary>
        ///  Unknown security
        /// </summary>
        public const uint UnknownSecurity = 1;

        /// <summary>
        ///  Duplicate quote
        /// </summary>
        public const uint DuplicateQuote = 6;

        /// <summary>
        ///  Invalid price
        /// </summary>
        public const uint InvalidPrice = 8;

        /// <summary>
        ///  Reference price not available
        /// </summary>
        public const uint NoReferencePriceAvailable = 16;

        /// <summary>
        ///  Single sided quotes not allowed
        /// </summary>
        public const uint NoSingleSidedQuotes = 100;

        /// <summary>
        ///  Invalid usage of quoting model
        /// </summary>
        public const uint InvalidQuotingModel = 103;

        /// <summary>
        ///  Invalid size
        /// </summary>
        public const uint InvalidSize = 106;

        /// <summary>
        ///  Invalid underlying price
        /// </summary>
        public const uint InvalidUnderlyingPrice = 107;

        /// <summary>
        ///  Bid price not reasonable
        /// </summary>
        public const uint BidPriceNotReasonable = 108;

        /// <summary>
        ///  Ask price not reasonable
        /// </summary>
        public const uint AskPriceNotReasonable = 109;

        /// <summary>
        ///  Bid price exceeds extended price range
        /// </summary>
        public const uint BidPriceExceedsRange = 110;

        /// <summary>
        ///  Ask price exceeds extended price range
        /// </summary>
        public const uint AskPriceExceedsRange = 111;

        /// <summary>
        ///  Instrument state freeze
        /// </summary>
        public const uint InstrumentStateFreeze = 115;

        /// <summary>
        ///  Deletion already pending
        /// </summary>
        public const uint DeletionAlreadyPending = 116;

        /// <summary>
        ///  Entitlement not assigned for underlying
        /// </summary>
        public const uint EntitlementNotAssignedForUnderlying = 119;

        /// <summary>
        ///  Instrument is currently not tradeable on book
        /// </summary>
        public const uint CurrentlyNotTradeableOnBook = 124;

        /// <summary>
        ///  Quantity exceeds trader specific limit
        /// </summary>
        public const uint QuantityLimitExceeded = 125;

        /// <summary>
        ///  Value exceeds trader specific limit
        /// </summary>
        public const uint ValueLimitExceeded = 126;

        /// <summary>
        ///  Invalid quote spread
        /// </summary>
        public const uint InvalidQuoteSpread = 127;

        /// <summary>
        ///  Book-or-Cancel quote type
        /// </summary>
        public const uint BookorCancel = 128;

        /// <summary>
        ///  Instrument state does not allow processing
        /// </summary>
        public const uint CantProcInCurrInstrState = 131;

        /// <summary>
        ///  Invalid quote type
        /// </summary>
        public const uint InvalidQuoteType = 134;

        /// <summary>
        ///  Trading indication running for trader
        /// </summary>
        public const uint Tradingindicationrunningfortrader = 143;

        /// <summary>
        ///  On-Book trading disabled for instrument type
        /// </summary>
        public const uint OnBookTradingdisabledforInstrumentType = 144;

        /// <summary>
        ///  Liquidity provider protection bid side cancelled
        /// </summary>
        public const uint Liquidityproviderprotectionbidsidecancelled = 147;

        /// <summary>
        ///  Liquidity provider protection ask side cancelled
        /// </summary>
        public const uint Liquidityproviderprotectionasksidecancelled = 148;

        /// <summary>
        ///  Quote entry outside quoting period not allowed
        /// </summary>
        public const uint OutsideQuotingPeriod = 155;

        /// <summary>
        ///  Match price resulting from entry of the matching quote is not a valid price step
        /// </summary>
        public const uint MatchPriceNotOnPriceStep = 156;

        /// <summary>
        ///  Quantity exceeds transaction size limit
        /// </summary>
        public const uint QuantityLimitExceedsTsl = 161;

        /// <summary>
        ///  Too many orders and quotes in order book
        /// </summary>
        public const uint TooManyOrdersandQuotesinOrderBook = 163;

        /// <summary>
        ///  Contract cannot be traded due to insufficient eligibility
        /// </summary>
        public const uint Contractcannotbetradedduetoinsufficienteligibility = 166;

        /// <summary>
        ///  the VF underlying price timed out, rejection of quote
        /// </summary>
        public const uint UnderlyingPriceTimeout = 167;

        /// <summary>
        ///  the BU is suspended due to an ARP level 3 soft breach
        /// </summary>
        public const uint BuSuspendArpLevel3SoftBreach = 168;

        /// <summary>
        ///  incoming quote pair rejected due to no clearing product assignment
        /// </summary>
        public const uint NoClearingProductAssignment = 169;

        /// <summary>
        ///  Fix Tag for Quote Entry Reject Reason
        /// </summary>
        public const ushort FixTag = 368;

        /// <summary>
        ///  Length of Quote Entry Reject Reason in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Quote Entry Reject Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + QuoteEntryRejectReason.Length)
            {
                throw new System.Exception("Invalid Length for Quote Entry Reject Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Entry Reject Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            *(uint*) (pointer + offset) = value;

            current = offset + QuoteEntryRejectReason.Length;
        }

        /// <summary>
        ///  TryDecode Quote Entry Reject Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + QuoteEntryRejectReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Entry Reject Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEntryRejectReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Entry Reject Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}