using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Requesting Party Id Executing System: Enum
    /// </summary>

    public static class RequestingPartyIdExecutingSystem
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
        ///  Check available length and set Requesting Party Id Executing System to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RequestingPartyIdExecutingSystem.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Id Executing System");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Requesting Party Id Executing System to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RequestingPartyIdExecutingSystem.Length;
        }

        /// <summary>
        ///  Set Requesting Party Id Executing System to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Requesting Party Id Executing System
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + RequestingPartyIdExecutingSystem.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Requesting Party Id Executing System
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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