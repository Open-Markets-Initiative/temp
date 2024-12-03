using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Underlying Stip Type: Optional Fixed Length String Field
    /// </summary>

    public sealed class UnderlyingStipType
    {
        /// <summary>
        ///  Fix Tag for Underlying Stip Type
        /// </summary>
        public const ushort FixTag = 888;

        /// <summary>
        ///  Length of Underlying Stip Type in bytes
        /// </summary>
        public const int Length = 7;

        /// <summary>
        ///  Encode Underlying Stip Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + UnderlyingStipType.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Stip Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Stip Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, UnderlyingStipType.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = UnderlyingStipType.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + UnderlyingStipType.Length;
        }

        /// <summary>
        ///  Check available length and set Underlying Stip Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + UnderlyingStipType.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Stip Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Underlying Stip Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + UnderlyingStipType.Length;
        }

        /// <summary>
        ///  Set Underlying Stip Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < UnderlyingStipType.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Underlying Stip Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + UnderlyingStipType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Underlying Stip Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Underlying Stip Type
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingStipType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Stip Type
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, UnderlyingStipType.Length).Trim('\0');
        }
    }
}