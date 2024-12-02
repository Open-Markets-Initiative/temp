using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Security Sub Type: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class SecuritySubType
    {
        /// <summary>
        ///  Length of Security Sub Type in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Security Sub Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + SecuritySubType.Length)
            {
                throw new System.Exception("Invalid Length for Security Sub Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SecuritySubType.Length;
        }

        /// <summary>
        ///  Encode Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Security Sub Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + SecuritySubType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SecuritySubType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Security Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}