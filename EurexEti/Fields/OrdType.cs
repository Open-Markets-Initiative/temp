using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Ord Type: Enum
    /// </summary>

    public sealed class OrdType
    {
        /// <summary>
        ///  Market
        /// </summary>
        public const byte Market = 1;

        /// <summary>
        ///  Limit
        /// </summary>
        public const byte Limit = 2;

        /// <summary>
        ///  Stop
        /// </summary>
        public const byte Stop = 3;

        /// <summary>
        ///  Stop Limit
        /// </summary>
        public const byte StopLimit = 4;

        /// <summary>
        ///  Fix Tag for Ord Type
        /// </summary>
        public const ushort FixTag = 40;

        /// <summary>
        ///  Length of Ord Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Ord Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OrdType.Length)
            {
                throw new System.Exception("Invalid Length for Ord Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ord Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OrdType.Length;
        }

        /// <summary>
        ///  TryDecode Ord Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrdType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Ord Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrdType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ord Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}