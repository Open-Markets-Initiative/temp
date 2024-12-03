using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mass Order Request Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class MassOrderRequestId
    {
        /// <summary>
        ///  Fix Tag for Mass Order Request Id
        /// </summary>
        public const ushort FixTag = 2423;

        /// <summary>
        ///  Length of Mass Order Request Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Mass Order Request Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + MassOrderRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Mass Order Request Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MassOrderRequestId.Length;
        }

        /// <summary>
        ///  Encode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Mass Order Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + MassOrderRequestId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassOrderRequestId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}