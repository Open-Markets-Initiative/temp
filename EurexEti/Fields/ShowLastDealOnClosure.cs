using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Show Last Deal On Closure: Enum
    /// </summary>

    public static class ShowLastDealOnClosure
    {
        /// <summary>
        ///  No
        /// </summary>
        public const byte No = 0;

        /// <summary>
        ///  Yes
        /// </summary>
        public const byte Yes = 1;

        /// <summary>
        ///  Fix Tag for Show Last Deal On Closure
        /// </summary>
        public const ushort FixTag = 25194;

        /// <summary>
        ///  Length of Show Last Deal On Closure in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Show Last Deal On Closure
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Show Last Deal On Closure
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ShowLastDealOnClosure.Length)
            {
                throw new System.Exception("Invalid Length for Show Last Deal On Closure");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Show Last Deal On Closure
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ShowLastDealOnClosure.Length;
        }

        /// <summary>
        ///  Check available length and set Show Last Deal On Closure to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ShowLastDealOnClosure.Length)
            {
                throw new System.Exception("Invalid Length for Show Last Deal On Closure");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Show Last Deal On Closure to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ShowLastDealOnClosure.Length;
        }

        /// <summary>
        ///  Set Show Last Deal On Closure to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Show Last Deal On Closure
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ShowLastDealOnClosure.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Show Last Deal On Closure
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Show Last Deal On Closure
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ShowLastDealOnClosure.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Show Last Deal On Closure
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}