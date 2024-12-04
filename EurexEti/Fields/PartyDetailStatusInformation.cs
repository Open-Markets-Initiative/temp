using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Detail Status Information: Enum
    /// </summary>

    public sealed class PartyDetailStatusInformation
    {
        /// <summary>
        ///  High TRR (TradeToRequestRatio) threshold
        /// </summary>
        public const byte Trrthresholdtoobig = 1;

        /// <summary>
        ///  Anonymous negotiation blocked by responder
        /// </summary>
        public const byte Blockallanonymous = 2;

        /// <summary>
        ///  Fix Tag for Party Detail Status Information
        /// </summary>
        public const ushort FixTag = 25185;

        /// <summary>
        ///  Length of Party Detail Status Information in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Party Detail Status Information
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyDetailStatusInformation.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Status Information");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Detail Status Information
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyDetailStatusInformation.Length;
        }

        /// <summary>
        ///  TryDecode Party Detail Status Information
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyDetailStatusInformation.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Detail Status Information
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyDetailStatusInformation.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Detail Status Information
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}