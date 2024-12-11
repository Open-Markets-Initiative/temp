using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Profile Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class BasketProfileId
    {
        /// <summary>
        ///  Fix Tag for Basket Profile Id
        /// </summary>
        public const ushort FixTag = 28899;

        /// <summary>
        ///  Length of Basket Profile Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Basket Profile Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Basket Profile Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + BasketProfileId.Length)
            {
                throw new System.Exception("Invalid Length for Basket Profile Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + BasketProfileId.Length;
        }

        /// <summary>
        ///  Encode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Basket Profile Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + BasketProfileId.Length)
            {
                throw new System.Exception("Invalid Length for Basket Profile Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Basket Profile Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + BasketProfileId.Length;
        }

        /// <summary>
        ///  Set Basket Profile Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Basket Profile Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + BasketProfileId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Basket Profile Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketProfileId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}