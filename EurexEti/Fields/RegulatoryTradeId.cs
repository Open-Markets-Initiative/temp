using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Regulatory Trade Id: Optional Fixed Length String Field
    /// </summary>

    public sealed class RegulatoryTradeId
    {
        /// <summary>
        ///  Fix Tag for Regulatory Trade Id
        /// </summary>
        public const ushort FixTag = 1903;

        /// <summary>
        ///  Length of Regulatory Trade Id in bytes
        /// </summary>
        public const int Length = 52;

        /// <summary>
        ///  Encode Regulatory Trade Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RegulatoryTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Regulatory Trade Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Regulatory Trade Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RegulatoryTradeId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RegulatoryTradeId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RegulatoryTradeId.Length;
        }

        /// <summary>
        ///  Check available length and set Regulatory Trade Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RegulatoryTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Regulatory Trade Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Regulatory Trade Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RegulatoryTradeId.Length;
        }

        /// <summary>
        ///  Set Regulatory Trade Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RegulatoryTradeId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Regulatory Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RegulatoryTradeId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Regulatory Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Regulatory Trade Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RegulatoryTradeId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Regulatory Trade Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RegulatoryTradeId.Length).Trim('\0');
        }
    }
}