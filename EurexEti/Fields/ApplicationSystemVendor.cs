using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Application System Vendor: Optional Fixed Length String Field
    /// </summary>

    public sealed class ApplicationSystemVendor
    {
        /// <summary>
        ///  Fix Tag for Application System Vendor
        /// </summary>
        public const ushort FixTag = 1605;

        /// <summary>
        ///  Length of Application System Vendor in bytes
        /// </summary>
        public const int Length = 30;

        /// <summary>
        ///  Encode Application System Vendor
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + ApplicationSystemVendor.Length)
            {
                throw new System.Exception("Invalid Length for Application System Vendor");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Application System Vendor
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, ApplicationSystemVendor.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = ApplicationSystemVendor.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + ApplicationSystemVendor.Length;
        }

        /// <summary>
        ///  Check available length and set Application System Vendor to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ApplicationSystemVendor.Length)
            {
                throw new System.Exception("Invalid Length for Application System Vendor");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Application System Vendor to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ApplicationSystemVendor.Length;
        }

        /// <summary>
        ///  Set Application System Vendor to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < ApplicationSystemVendor.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Application System Vendor
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + ApplicationSystemVendor.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Application System Vendor
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Application System Vendor
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplicationSystemVendor.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Application System Vendor
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, ApplicationSystemVendor.Length).Trim('\0');
        }
    }
}