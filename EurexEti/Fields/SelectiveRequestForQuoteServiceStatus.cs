using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Selective Request For Quote Service Status: Enum
    /// </summary>

    public sealed class SelectiveRequestForQuoteServiceStatus
    {
        /// <summary>
        ///  Unavailable
        /// </summary>
        public const byte Unavailable = 0;

        /// <summary>
        ///  Available
        /// </summary>
        public const byte Available = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte SelectiveRequestForQuoteServiceStatusMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte SelectiveRequestForQuoteServiceStatusMinimumValue = 0;

        /// <summary>
        ///  Length of Selective Request For Quote Service Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Selective Request For Quote Service Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SelectiveRequestForQuoteServiceStatus.Length)
            {
                throw new System.Exception("Invalid Length for Selective Request For Quote Service Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Selective Request For Quote Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SelectiveRequestForQuoteServiceStatus.Length;
        }

        /// <summary>
        ///  TryDecode Selective Request For Quote Service Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SelectiveRequestForQuoteServiceStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Selective Request For Quote Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SelectiveRequestForQuoteServiceStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Selective Request For Quote Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}