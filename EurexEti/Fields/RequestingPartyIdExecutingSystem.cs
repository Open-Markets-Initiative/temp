using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Requesting Party Id Executing System: Enum
    /// </summary>

    public sealed class RequestingPartyIdExecutingSystem
    {
        /// <summary>
        ///  Eurex Clearing
        /// </summary>
        public const uint EurexClearing = 1;

        /// <summary>
        ///  T7 trading system
        /// </summary>
        public const uint T7 = 2;

        /// <summary>
        ///  Fix Tag for Requesting Party Id Executing System
        /// </summary>
        public const ushort FixTag = 20816;

        /// <summary>
        ///  Length of Requesting Party Id Executing System in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Requesting Party Id Executing System
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + RequestingPartyIdExecutingSystem.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Id Executing System");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Requesting Party Id Executing System
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            *(uint*) (pointer + offset) = value;

            current = offset + RequestingPartyIdExecutingSystem.Length;
        }

        /// <summary>
        ///  TryDecode Requesting Party Id Executing System
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + RequestingPartyIdExecutingSystem.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Requesting Party Id Executing System
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestingPartyIdExecutingSystem.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Requesting Party Id Executing System
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}