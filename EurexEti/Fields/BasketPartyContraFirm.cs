using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Party Contra Firm: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class BasketPartyContraFirm
    {
        /// <summary>
        ///  Fix Tag for Basket Party Contra Firm
        /// </summary>
        public const ushort FixTag = 25182;

        /// <summary>
        ///  Length of Basket Party Contra Firm in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Encode Basket Party Contra Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + BasketPartyContraFirm.Length)
            {
                throw new System.Exception("Invalid Length for Basket Party Contra Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Party Contra Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, BasketPartyContraFirm.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = BasketPartyContraFirm.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + BasketPartyContraFirm.Length;
        }

        /// <summary>
        ///  Check available length and set Basket Party Contra Firm to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + BasketPartyContraFirm.Length)
            {
                throw new System.Exception("Invalid Length for Basket Party Contra Firm");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Basket Party Contra Firm to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + BasketPartyContraFirm.Length;
        }

        /// <summary>
        ///  Set Basket Party Contra Firm to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < BasketPartyContraFirm.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Basket Party Contra Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + BasketPartyContraFirm.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Basket Party Contra Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + BasketPartyContraFirm.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Basket Party Contra Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketPartyContraFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Party Contra Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, BasketPartyContraFirm.Length).Trim();
        }
    }
}