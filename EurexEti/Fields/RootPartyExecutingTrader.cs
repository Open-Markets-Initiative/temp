using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Root Party Executing Trader: Optional Fixed Length String Field
    /// </summary>

    public static class RootPartyExecutingTrader
    {
        /// <summary>
        ///  Fix Tag for Root Party Executing Trader
        /// </summary>
        public const ushort FixTag = 22412;

        /// <summary>
        ///  Length of Root Party Executing Trader in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Encode Root Party Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RootPartyExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Executing Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RootPartyExecutingTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RootPartyExecutingTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RootPartyExecutingTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Root Party Executing Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RootPartyExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Executing Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Root Party Executing Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RootPartyExecutingTrader.Length;
        }

        /// <summary>
        ///  Set Root Party Executing Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RootPartyExecutingTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Root Party Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RootPartyExecutingTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Root Party Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + RootPartyExecutingTrader.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Root Party Executing Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyExecutingTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Executing Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RootPartyExecutingTrader.Length).Trim('\0');
        }
    }
}