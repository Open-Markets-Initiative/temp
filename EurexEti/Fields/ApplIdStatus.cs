using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl Id Status: Enum
    /// </summary>

    public sealed class ApplIdStatus
    {
        /// <summary>
        ///  Error converting response or broadcast
        /// </summary>
        public const uint Outboundconversionerror = 105;

        /// <summary>
        ///  
        /// </summary>
        public const uint ApplIdStatusMaximumValue = 4294967294;

        /// <summary>
        ///  
        /// </summary>
        public const uint ApplIdStatusMinimumValue = 0;

        /// <summary>
        ///  Length of Appl Id Status in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Appl Id Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ApplIdStatus.Length)
            {
                throw new System.Exception("Invalid Length for Appl Id Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Id Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            *(uint*) (pointer + offset) = value;

            current = offset + ApplIdStatus.Length;
        }

        /// <summary>
        ///  TryDecode Appl Id Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ApplIdStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Id Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplIdStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Id Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}