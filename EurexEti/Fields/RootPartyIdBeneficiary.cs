using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Root Party Id Beneficiary: Optional Fixed Length String Field
    /// </summary>

    public static class RootPartyIdBeneficiary
    {
        /// <summary>
        ///  Fix Tag for Root Party Id Beneficiary
        /// </summary>
        public const ushort FixTag = 20432;

        /// <summary>
        ///  Length of Root Party Id Beneficiary in bytes
        /// </summary>
        public const int Length = 9;

        /// <summary>
        ///  Encode Root Party Id Beneficiary
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RootPartyIdBeneficiary.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Id Beneficiary");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Id Beneficiary
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RootPartyIdBeneficiary.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RootPartyIdBeneficiary.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RootPartyIdBeneficiary.Length;
        }

        /// <summary>
        ///  Check available length and set Root Party Id Beneficiary to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RootPartyIdBeneficiary.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Id Beneficiary");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Root Party Id Beneficiary to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RootPartyIdBeneficiary.Length;
        }

        /// <summary>
        ///  Set Root Party Id Beneficiary to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RootPartyIdBeneficiary.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Root Party Id Beneficiary
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RootPartyIdBeneficiary.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Root Party Id Beneficiary
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
        ///  Decode Root Party Id Beneficiary
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyIdBeneficiary.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Id Beneficiary
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RootPartyIdBeneficiary.Length).Trim('\0');
        }
    }
}