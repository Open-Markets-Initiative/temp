using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Detail Status Information: Enum
    /// </summary>

    public static class PartyDetailStatusInformation
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
        ///  Null value for Party Detail Status Information
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Party Detail Status Information to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyDetailStatusInformation.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Status Information");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Detail Status Information to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyDetailStatusInformation.Length;
        }

        /// <summary>
        ///  Set Party Detail Status Information to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Party Detail Status Information
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyDetailStatusInformation.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Detail Status Information
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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