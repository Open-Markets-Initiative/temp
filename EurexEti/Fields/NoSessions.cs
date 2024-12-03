using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Sessions: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoSessions
    {
        /// <summary>
        ///  Fix Tag for No Sessions
        /// </summary>
        public const ushort FixTag = 28734;

        /// <summary>
        ///  Length of No Sessions in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Sessions
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoSessions.Length)
            {
                throw new System.Exception("Invalid Length for No Sessions");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Sessions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoSessions.Length;
        }

        /// <summary>
        ///  Encode No Sessions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Sessions
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoSessions.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Sessions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoSessions.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Sessions
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}