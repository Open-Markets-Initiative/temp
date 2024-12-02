using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cross Prioritization: Enum
    /// </summary>

    public sealed class CrossPrioritization
    {
        /// <summary>
        ///  Buy side is prioritized
        /// </summary>
        public const byte Buyside = 1;

        /// <summary>
        ///  Sell side is prioritized
        /// </summary>
        public const byte Sellside = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte CrossPrioritizationMaximumValue = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte CrossPrioritizationMinimumValue = 1;

        /// <summary>
        ///  Length of Cross Prioritization in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Cross Prioritization
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + CrossPrioritization.Length)
            {
                throw new System.Exception("Invalid Length for Cross Prioritization");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cross Prioritization
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + CrossPrioritization.Length;
        }

        /// <summary>
        ///  TryDecode Cross Prioritization
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + CrossPrioritization.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Cross Prioritization
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CrossPrioritization.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cross Prioritization
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}