using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Root Party Contra Trader: Optional Fixed Length String Field
    /// </summary>

    public static class RootPartyContraTrader
    {
        /// <summary>
        ///  Fix Tag for Root Party Contra Trader
        /// </summary>
        public const ushort FixTag = 22437;

        /// <summary>
        ///  Length of Root Party Contra Trader in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Encode Root Party Contra Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RootPartyContraTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Contra Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Contra Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RootPartyContraTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RootPartyContraTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RootPartyContraTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Root Party Contra Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RootPartyContraTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Contra Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Root Party Contra Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RootPartyContraTrader.Length;
        }

        /// <summary>
        ///  Set Root Party Contra Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RootPartyContraTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Root Party Contra Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RootPartyContraTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Root Party Contra Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + RootPartyContraTrader.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Root Party Contra Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyContraTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Contra Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RootPartyContraTrader.Length).Trim('\0');
        }
    }
}