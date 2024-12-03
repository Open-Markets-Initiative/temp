using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Entering Trader: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyEnteringTrader
    {
        /// <summary>
        ///  Fix Tag for Party Entering Trader
        /// </summary>
        public const ushort FixTag = 22036;

        /// <summary>
        ///  Length of Party Entering Trader in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Encode Party Entering Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyEnteringTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Entering Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Entering Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyEnteringTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyEnteringTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyEnteringTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Party Entering Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyEnteringTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Entering Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Entering Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyEnteringTrader.Length;
        }

        /// <summary>
        ///  Set Party Entering Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyEnteringTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Entering Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyEnteringTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Entering Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Entering Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyEnteringTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Entering Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyEnteringTrader.Length).Trim('\0');
        }
    }
}