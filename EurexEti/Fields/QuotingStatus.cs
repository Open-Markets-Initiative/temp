using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quoting Status: Enum
    /// </summary>

    public sealed class QuotingStatus
    {
        /// <summary>
        ///  Open/Active
        /// </summary>
        public const byte OpenActive = 1;

        /// <summary>
        ///  Open/Working
        /// </summary>
        public const byte OpenIdle = 2;

        /// <summary>
        ///  Closed/Inactive
        /// </summary>
        public const byte ClosedInactive = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuotingStatusMaximumValue = 5;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuotingStatusMinimumValue = 0;

        /// <summary>
        ///  Length of Quoting Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quoting Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuotingStatus.Length)
            {
                throw new System.Exception("Invalid Length for Quoting Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quoting Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuotingStatus.Length;
        }

        /// <summary>
        ///  TryDecode Quoting Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuotingStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quoting Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuotingStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quoting Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}