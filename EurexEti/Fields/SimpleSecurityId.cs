using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Simple Security Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class SimpleSecurityId
    {
        /// <summary>
        ///  Fix Tag for Simple Security Id
        /// </summary>
        public const ushort FixTag = 30048;

        /// <summary>
        ///  Length of Simple Security Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Simple Security Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + SimpleSecurityId.Length)
            {
                throw new System.Exception("Invalid Length for Simple Security Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Simple Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SimpleSecurityId.Length;
        }

        /// <summary>
        ///  Encode Simple Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Simple Security Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SimpleSecurityId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Simple Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SimpleSecurityId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Simple Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}