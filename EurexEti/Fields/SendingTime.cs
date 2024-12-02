using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Sending Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class SendingTime
    {
        /// <summary>
        ///  Length of Sending Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Sending Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + SendingTime.Length)
            {
                throw new System.Exception("Invalid Length for Sending Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Sending Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SendingTime.Length;
        }

        /// <summary>
        ///  Encode Sending Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Sending Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + SendingTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Sending Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SendingTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Sending Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}