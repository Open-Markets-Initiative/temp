using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Negotiation Start Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class NegotiationStartTime
    {
        /// <summary>
        ///  Fix Tag for Negotiation Start Time
        /// </summary>
        public const ushort FixTag = 28764;

        /// <summary>
        ///  Length of Negotiation Start Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Negotiation Start Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + NegotiationStartTime.Length)
            {
                throw new System.Exception("Invalid Length for Negotiation Start Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Negotiation Start Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NegotiationStartTime.Length;
        }

        /// <summary>
        ///  Encode Negotiation Start Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Negotiation Start Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + NegotiationStartTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Negotiation Start Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NegotiationStartTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Negotiation Start Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}