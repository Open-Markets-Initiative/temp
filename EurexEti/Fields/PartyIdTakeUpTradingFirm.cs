using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Id Take Up Trading Firm: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyIdTakeUpTradingFirm
    {
        /// <summary>
        ///  Fix Tag for Party Id Take Up Trading Firm
        /// </summary>
        public const ushort FixTag = 20096;

        /// <summary>
        ///  Length of Party Id Take Up Trading Firm in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Encode Party Id Take Up Trading Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyIdTakeUpTradingFirm.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Take Up Trading Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Take Up Trading Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyIdTakeUpTradingFirm.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyIdTakeUpTradingFirm.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyIdTakeUpTradingFirm.Length;
        }

        /// <summary>
        ///  Check available length and set Party Id Take Up Trading Firm to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdTakeUpTradingFirm.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Take Up Trading Firm");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Take Up Trading Firm to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdTakeUpTradingFirm.Length;
        }

        /// <summary>
        ///  Set Party Id Take Up Trading Firm to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyIdTakeUpTradingFirm.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Id Take Up Trading Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyIdTakeUpTradingFirm.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Take Up Trading Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Id Take Up Trading Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdTakeUpTradingFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Take Up Trading Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyIdTakeUpTradingFirm.Length).Trim('\0');
        }
    }
}