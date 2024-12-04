using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Eurex Volume Ranking: Enum
    /// </summary>

    public sealed class EurexVolumeRanking
    {
        /// <summary>
        ///  Low
        /// </summary>
        public const byte Low = 1;

        /// <summary>
        ///  Medium
        /// </summary>
        public const byte Medium = 2;

        /// <summary>
        ///  High
        /// </summary>
        public const byte High = 3;

        /// <summary>
        ///  Fix Tag for Eurex Volume Ranking
        /// </summary>
        public const ushort FixTag = 25176;

        /// <summary>
        ///  Length of Eurex Volume Ranking in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Eurex Volume Ranking
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + EurexVolumeRanking.Length)
            {
                throw new System.Exception("Invalid Length for Eurex Volume Ranking");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Eurex Volume Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + EurexVolumeRanking.Length;
        }

        /// <summary>
        ///  TryDecode Eurex Volume Ranking
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + EurexVolumeRanking.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Eurex Volume Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EurexVolumeRanking.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Eurex Volume Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}