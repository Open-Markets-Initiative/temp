using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Root Party Entering Trader: Optional Fixed Length String Field
    /// </summary>

    public sealed class RootPartyEnteringTrader
    {
        /// <summary>
        ///  Length of Root Party Entering Trader in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Encode Root Party Entering Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RootPartyEnteringTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Entering Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Entering Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RootPartyEnteringTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RootPartyEnteringTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RootPartyEnteringTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Root Party Entering Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RootPartyEnteringTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Entering Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Root Party Entering Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RootPartyEnteringTrader.Length;
        }

        /// <summary>
        ///  Set Root Party Entering Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RootPartyEnteringTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Root Party Entering Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RootPartyEnteringTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Root Party Entering Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Root Party Entering Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyEnteringTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Entering Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RootPartyEnteringTrader.Length).Trim('\0');
        }
    }
}