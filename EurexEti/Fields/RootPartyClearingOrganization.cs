using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Root Party Clearing Organization: Optional Fixed Length String Field
    /// </summary>

    public sealed class RootPartyClearingOrganization
    {
        /// <summary>
        ///  Fix Tag for Root Party Clearing Organization
        /// </summary>
        public const ushort FixTag = 22421;

        /// <summary>
        ///  Length of Root Party Clearing Organization in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Root Party Clearing Organization
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + RootPartyClearingOrganization.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Clearing Organization");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Clearing Organization
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RootPartyClearingOrganization.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = RootPartyClearingOrganization.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RootPartyClearingOrganization.Length;
        }

        /// <summary>
        ///  Check available length and set Root Party Clearing Organization to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RootPartyClearingOrganization.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Clearing Organization");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Root Party Clearing Organization to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RootPartyClearingOrganization.Length;
        }

        /// <summary>
        ///  Set Root Party Clearing Organization to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < RootPartyClearingOrganization.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Root Party Clearing Organization
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + RootPartyClearingOrganization.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Root Party Clearing Organization
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Root Party Clearing Organization
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyClearingOrganization.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Clearing Organization
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, RootPartyClearingOrganization.Length).Trim('\0');
        }
    }
}