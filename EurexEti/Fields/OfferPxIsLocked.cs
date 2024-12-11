using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Offer Px Is Locked: Enum
    /// </summary>

    public static class OfferPxIsLocked
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
        ///  Fix Tag for Offer Px Is Locked
        /// </summary>
        public const ushort FixTag = 25207;

        /// <summary>
        ///  Length of Offer Px Is Locked in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Offer Px Is Locked
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Offer Px Is Locked
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OfferPxIsLocked.Length)
            {
                throw new System.Exception("Invalid Length for Offer Px Is Locked");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Offer Px Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OfferPxIsLocked.Length;
        }

        /// <summary>
        ///  Check available length and set Offer Px Is Locked to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + OfferPxIsLocked.Length)
            {
                throw new System.Exception("Invalid Length for Offer Px Is Locked");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Offer Px Is Locked to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + OfferPxIsLocked.Length;
        }

        /// <summary>
        ///  Set Offer Px Is Locked to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Offer Px Is Locked
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OfferPxIsLocked.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Offer Px Is Locked
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Offer Px Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OfferPxIsLocked.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Offer Px Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}