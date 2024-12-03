using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Put Or Call: Enum
    /// </summary>

    public sealed class PutOrCall
    {
        /// <summary>
        ///  Put
        /// </summary>
        public const byte Put = 0;

        /// <summary>
        ///  Call
        /// </summary>
        public const byte Call = 1;

        /// <summary>
        ///  Fix Tag for Put Or Call
        /// </summary>
        public const ushort FixTag = 201;

        /// <summary>
        ///  Length of Put Or Call in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Put Or Call
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PutOrCall.Length)
            {
                throw new System.Exception("Invalid Length for Put Or Call");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PutOrCall.Length;
        }

        /// <summary>
        ///  TryDecode Put Or Call
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PutOrCall.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PutOrCall.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}