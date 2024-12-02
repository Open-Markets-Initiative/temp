using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Negotiation Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class NegotiationId
    {
        /// <summary>
        ///  Length of Negotiation Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Negotiation Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + NegotiationId.Length)
            {
                throw new System.Exception("Invalid Length for Negotiation Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Negotiation Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NegotiationId.Length;
        }

        /// <summary>
        ///  Encode Negotiation Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Negotiation Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + NegotiationId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Negotiation Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NegotiationId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Negotiation Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}