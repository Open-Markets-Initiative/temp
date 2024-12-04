using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Beneficiary: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyIdBeneficiary
    {
        /// <summary>
        ///  Fix Tag for Party Id Beneficiary
        /// </summary>
        public const ushort FixTag = 20032;

        /// <summary>
        ///  Length of Party Id Beneficiary in bytes
        /// </summary>
        public const int Length = 9;

        /// <summary>
        ///  Encode Party Id Beneficiary
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyIdBeneficiary.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Beneficiary");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Beneficiary
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyIdBeneficiary.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyIdBeneficiary.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyIdBeneficiary.Length;
        }

        /// <summary>
        ///  Check available length and set Party Id Beneficiary to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdBeneficiary.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Beneficiary");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Beneficiary to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdBeneficiary.Length;
        }

        /// <summary>
        ///  Set Party Id Beneficiary to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyIdBeneficiary.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Id Beneficiary
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyIdBeneficiary.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Beneficiary
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Id Beneficiary
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdBeneficiary.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Beneficiary
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyIdBeneficiary.Length).Trim('\0');
        }
    }
}