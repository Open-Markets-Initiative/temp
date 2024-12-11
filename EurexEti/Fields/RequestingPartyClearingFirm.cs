using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Requesting Party Clearing Firm: Optional Fixed Length String Field
    /// </summary>

    public static class RequestingPartyClearingFirm
    {
        /// <summary>
        ///  Fix Tag for Requesting Party Clearing Firm
        /// </summary>
        public const ushort FixTag = 22804;

        /// <summary>
        ///  Length of Requesting Party Clearing Firm in bytes
        /// </summary>
        public const int Length = 9;

        /// <summary>
        ///  Encode Requesting Party Clearing Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RequestingPartyClearingFirm.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Clearing Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Requesting Party Clearing Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RequestingPartyClearingFirm.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RequestingPartyClearingFirm.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RequestingPartyClearingFirm.Length;
        }

        /// <summary>
        ///  Check available length and set Requesting Party Clearing Firm to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RequestingPartyClearingFirm.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Clearing Firm");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Requesting Party Clearing Firm to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RequestingPartyClearingFirm.Length;
        }

        /// <summary>
        ///  Set Requesting Party Clearing Firm to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RequestingPartyClearingFirm.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Requesting Party Clearing Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RequestingPartyClearingFirm.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Requesting Party Clearing Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Requesting Party Clearing Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestingPartyClearingFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Requesting Party Clearing Firm
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RequestingPartyClearingFirm.Length).Trim('\0');
        }
    }
}