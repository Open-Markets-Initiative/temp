using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Requesting Party Entering Firm: Optional Fixed Length String Field
    /// </summary>

    public sealed class RequestingPartyEnteringFirm
    {
        /// <summary>
        ///  Fix Tag for Requesting Party Entering Firm
        /// </summary>
        public const ushort FixTag = 22807;

        /// <summary>
        ///  Length of Requesting Party Entering Firm in bytes
        /// </summary>
        public const int Length = 9;

        /// <summary>
        ///  Encode Requesting Party Entering Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RequestingPartyEnteringFirm.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Entering Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Requesting Party Entering Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RequestingPartyEnteringFirm.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RequestingPartyEnteringFirm.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RequestingPartyEnteringFirm.Length;
        }

        /// <summary>
        ///  Check available length and set Requesting Party Entering Firm to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RequestingPartyEnteringFirm.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Entering Firm");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Requesting Party Entering Firm to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RequestingPartyEnteringFirm.Length;
        }

        /// <summary>
        ///  Set Requesting Party Entering Firm to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RequestingPartyEnteringFirm.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Requesting Party Entering Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RequestingPartyEnteringFirm.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Requesting Party Entering Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Requesting Party Entering Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestingPartyEnteringFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Requesting Party Entering Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RequestingPartyEnteringFirm.Length).Trim('\0');
        }
    }
}