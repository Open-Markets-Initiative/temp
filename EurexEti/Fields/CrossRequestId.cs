using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cross Request Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class CrossRequestId
    {
        /// <summary>
        ///  Fix Tag for Cross Request Id
        /// </summary>
        public const ushort FixTag = 2672;

        /// <summary>
        ///  Length of Cross Request Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Cross Request Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + CrossRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Cross Request Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + CrossRequestId.Length;
        }

        /// <summary>
        ///  Encode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Cross Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + CrossRequestId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CrossRequestId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}