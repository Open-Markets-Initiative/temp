using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Match Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MatchDate
    {
        /// <summary>
        ///  Fix Tag for Match Date
        /// </summary>
        public const ushort FixTag = 28582;

        /// <summary>
        ///  Length of Match Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Match Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MatchDate.Length)
            {
                throw new System.Exception("Invalid Length for Match Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Match Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MatchDate.Length;
        }

        /// <summary>
        ///  Encode Match Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Match Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MatchDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Match Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MatchDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Match Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}