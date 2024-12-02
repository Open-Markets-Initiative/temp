using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Swap Clearer: Enum
    /// </summary>

    public sealed class SwapClearer
    {
        /// <summary>
        ///  Eurex Clearing
        /// </summary>
        public const byte Ecag = 0;

        /// <summary>
        ///  Non-Eurex Clearing
        /// </summary>
        public const byte Nonecag = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte SwapClearerMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte SwapClearerMinimumValue = 0;

        /// <summary>
        ///  Length of Swap Clearer in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Swap Clearer
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SwapClearer.Length)
            {
                throw new System.Exception("Invalid Length for Swap Clearer");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Swap Clearer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SwapClearer.Length;
        }

        /// <summary>
        ///  TryDecode Swap Clearer
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SwapClearer.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Swap Clearer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SwapClearer.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Swap Clearer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}