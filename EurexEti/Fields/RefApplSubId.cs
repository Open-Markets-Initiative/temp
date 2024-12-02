using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Ref Appl Sub Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class RefApplSubId
    {
        /// <summary>
        ///  Length of Ref Appl Sub Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Ref Appl Sub Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + RefApplSubId.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Sub Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RefApplSubId.Length;
        }

        /// <summary>
        ///  Encode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Ref Appl Sub Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + RefApplSubId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RefApplSubId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}