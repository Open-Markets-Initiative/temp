using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Match Sub Type: Enum
    /// </summary>

    public sealed class MatchSubType
    {
        /// <summary>
        ///  Opening auction
        /// </summary>
        public const byte OpeningAuction = 1;

        /// <summary>
        ///  Closing auction
        /// </summary>
        public const byte ClosingAuction = 2;

        /// <summary>
        ///  Intraday auction
        /// </summary>
        public const byte IntradayAuction = 3;

        /// <summary>
        ///  Circuit Breaker auction
        /// </summary>
        public const byte CircuitBreakerAuction = 4;

        /// <summary>
        ///  CLIP matching outside BBO
        /// </summary>
        public const byte OutsideBbo = 6;

        /// <summary>
        ///  Fix Tag for Match Sub Type
        /// </summary>
        public const ushort FixTag = 28610;

        /// <summary>
        ///  Length of Match Sub Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Match Sub Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MatchSubType.Length)
            {
                throw new System.Exception("Invalid Length for Match Sub Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Match Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MatchSubType.Length;
        }

        /// <summary>
        ///  TryDecode Match Sub Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MatchSubType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Match Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MatchSubType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Match Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}