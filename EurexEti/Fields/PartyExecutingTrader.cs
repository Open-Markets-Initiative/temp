using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Executing Trader: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class PartyExecutingTrader
    {
        /// <summary>
        ///  Fix Tag for Party Executing Trader
        /// </summary>
        public const ushort FixTag = 22012;

        /// <summary>
        ///  Length of Party Executing Trader in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Encode Party Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Executing Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyExecutingTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyExecutingTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + PartyExecutingTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Party Executing Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Executing Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Executing Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyExecutingTrader.Length;
        }

        /// <summary>
        ///  Set Party Executing Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyExecutingTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyExecutingTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + PartyExecutingTrader.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Executing Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyExecutingTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Executing Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyExecutingTrader.Length).Trim();
        }
    }
}