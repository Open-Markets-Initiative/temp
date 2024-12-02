using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Order Origination Trader: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyOrderOriginationTrader
    {
        /// <summary>
        ///  Length of Party Order Origination Trader in bytes
        /// </summary>
        public const int Length = 132;

        /// <summary>
        ///  Encode Party Order Origination Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyOrderOriginationTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Order Origination Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Order Origination Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyOrderOriginationTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyOrderOriginationTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyOrderOriginationTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Party Order Origination Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyOrderOriginationTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Order Origination Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Order Origination Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyOrderOriginationTrader.Length;
        }

        /// <summary>
        ///  Set Party Order Origination Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyOrderOriginationTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Order Origination Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyOrderOriginationTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Order Origination Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Order Origination Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyOrderOriginationTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Order Origination Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyOrderOriginationTrader.Length).Trim('\0');
        }
    }
}