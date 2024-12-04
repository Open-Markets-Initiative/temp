using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Affected Order Request Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class AffectedOrderRequestId
    {
        /// <summary>
        ///  Fix Tag for Affected Order Request Id
        /// </summary>
        public const ushort FixTag = 28783;

        /// <summary>
        ///  Length of Affected Order Request Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Affected Order Request Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + AffectedOrderRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Affected Order Request Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + AffectedOrderRequestId.Length;
        }

        /// <summary>
        ///  Encode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Affected Order Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + AffectedOrderRequestId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + AffectedOrderRequestId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}