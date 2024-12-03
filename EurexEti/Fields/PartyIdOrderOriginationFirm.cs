using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Id Order Origination Firm: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyIdOrderOriginationFirm
    {
        /// <summary>
        ///  Fix Tag for Party Id Order Origination Firm
        /// </summary>
        public const ushort FixTag = 20013;

        /// <summary>
        ///  Length of Party Id Order Origination Firm in bytes
        /// </summary>
        public const int Length = 7;

        /// <summary>
        ///  Encode Party Id Order Origination Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyIdOrderOriginationFirm.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Order Origination Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Order Origination Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyIdOrderOriginationFirm.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyIdOrderOriginationFirm.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyIdOrderOriginationFirm.Length;
        }

        /// <summary>
        ///  Check available length and set Party Id Order Origination Firm to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdOrderOriginationFirm.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Order Origination Firm");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Order Origination Firm to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdOrderOriginationFirm.Length;
        }

        /// <summary>
        ///  Set Party Id Order Origination Firm to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyIdOrderOriginationFirm.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Id Order Origination Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyIdOrderOriginationFirm.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Order Origination Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Id Order Origination Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdOrderOriginationFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Order Origination Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyIdOrderOriginationFirm.Length).Trim('\0');
        }
    }
}