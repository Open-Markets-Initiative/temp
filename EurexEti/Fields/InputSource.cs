using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Input Source: Enum
    /// </summary>

    public sealed class InputSource
    {
        /// <summary>
        ///  Client Broker
        /// </summary>
        public const byte ClientBroker = 1;

        /// <summary>
        ///  Proprietary Broker
        /// </summary>
        public const byte ProprietaryBroker = 2;

        /// <summary>
        ///  Fix Tag for Input Source
        /// </summary>
        public const ushort FixTag = 979;

        /// <summary>
        ///  Length of Input Source in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Input Source
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + InputSource.Length)
            {
                throw new System.Exception("Invalid Length for Input Source");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Input Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + InputSource.Length;
        }

        /// <summary>
        ///  TryDecode Input Source
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + InputSource.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Input Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + InputSource.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Input Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}