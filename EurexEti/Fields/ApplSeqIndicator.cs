using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl Seq Indicator: Enum
    /// </summary>

    public sealed class ApplSeqIndicator
    {
        /// <summary>
        ///  
        /// </summary>
        public const byte NoRecoveryRequired = 0;

        /// <summary>
        ///  
        /// </summary>
        public const byte RecoveryRequired = 1;

        /// <summary>
        ///  Fix Tag for Appl Seq Indicator
        /// </summary>
        public const ushort FixTag = 28703;

        /// <summary>
        ///  Length of Appl Seq Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Appl Seq Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ApplSeqIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Appl Seq Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Seq Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ApplSeqIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Appl Seq Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ApplSeqIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Seq Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplSeqIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Seq Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}