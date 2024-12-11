using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Underlying Stip Value: Optional Fixed Length String Field
    /// </summary>

    public static class UnderlyingStipValue
    {
        /// <summary>
        ///  Fix Tag for Underlying Stip Value
        /// </summary>
        public const ushort FixTag = 889;

        /// <summary>
        ///  Length of Underlying Stip Value in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Underlying Stip Value
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + UnderlyingStipValue.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Stip Value");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Stip Value
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, UnderlyingStipValue.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = UnderlyingStipValue.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + UnderlyingStipValue.Length;
        }

        /// <summary>
        ///  Check available length and set Underlying Stip Value to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + UnderlyingStipValue.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Stip Value");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Underlying Stip Value to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + UnderlyingStipValue.Length;
        }

        /// <summary>
        ///  Set Underlying Stip Value to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < UnderlyingStipValue.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Underlying Stip Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + UnderlyingStipValue.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Underlying Stip Value
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
        ///  Decode Underlying Stip Value
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingStipValue.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Stip Value
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, UnderlyingStipValue.Length).Trim('\0');
        }
    }
}