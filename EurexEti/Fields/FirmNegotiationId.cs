using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Firm Negotiation Id: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class FirmNegotiationId
    {
        /// <summary>
        ///  Fix Tag for Firm Negotiation Id
        /// </summary>
        public const ushort FixTag = 28762;

        /// <summary>
        ///  Length of Firm Negotiation Id in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Encode Firm Negotiation Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + FirmNegotiationId.Length)
            {
                throw new System.Exception("Invalid Length for Firm Negotiation Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Firm Negotiation Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, FirmNegotiationId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = FirmNegotiationId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + FirmNegotiationId.Length;
        }

        /// <summary>
        ///  Check available length and set Firm Negotiation Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + FirmNegotiationId.Length)
            {
                throw new System.Exception("Invalid Length for Firm Negotiation Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Firm Negotiation Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + FirmNegotiationId.Length;
        }

        /// <summary>
        ///  Set Firm Negotiation Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < FirmNegotiationId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Firm Negotiation Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + FirmNegotiationId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Firm Negotiation Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + FirmNegotiationId.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Firm Negotiation Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FirmNegotiationId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Firm Negotiation Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, FirmNegotiationId.Length).Trim();
        }
    }
}