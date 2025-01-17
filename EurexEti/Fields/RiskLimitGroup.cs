using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Group: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class RiskLimitGroup
    {
        /// <summary>
        ///  Fix Tag for Risk Limit Group
        /// </summary>
        public const ushort FixTag = 28775;

        /// <summary>
        ///  Length of Risk Limit Group in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Encode Risk Limit Group
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RiskLimitGroup.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Group");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Group
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RiskLimitGroup.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RiskLimitGroup.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + RiskLimitGroup.Length;
        }

        /// <summary>
        ///  Check available length and set Risk Limit Group to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RiskLimitGroup.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Group");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Risk Limit Group to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RiskLimitGroup.Length;
        }

        /// <summary>
        ///  Set Risk Limit Group to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RiskLimitGroup.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Risk Limit Group
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RiskLimitGroup.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Risk Limit Group
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + RiskLimitGroup.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Risk Limit Group
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitGroup.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Group
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RiskLimitGroup.Length).Trim();
        }
    }
}