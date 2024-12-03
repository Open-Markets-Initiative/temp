using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Ownership Indicator: Enum
    /// </summary>

    public sealed class OwnershipIndicator
    {
        /// <summary>
        ///  Do not change ownership
        /// </summary>
        public const byte NoChangeofOwnership = 0;

        /// <summary>
        ///  Change ownership to executing party (User ID)
        /// </summary>
        public const byte ChangetoExecutingTrader = 1;

        /// <summary>
        ///  Fix Tag for Ownership Indicator
        /// </summary>
        public const ushort FixTag = 28743;

        /// <summary>
        ///  Length of Ownership Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Ownership Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OwnershipIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Ownership Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ownership Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OwnershipIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Ownership Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OwnershipIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Ownership Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OwnershipIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ownership Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}