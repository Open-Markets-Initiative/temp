using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Input Source: Enum
    /// </summary>

    public sealed class LegInputSource
    {
        /// <summary>
        ///  Client Broker
        /// </summary>
        public const byte ClientBroker = 1;

        /// <summary>
        ///  Proprietary Broker
        /// </summary>
        public const byte ProprietaryBroker = 2;

        /// <summary>
        ///  Buy side
        /// </summary>
        public const byte BuySide = 3;

        /// <summary>
        ///  Sell side
        /// </summary>
        public const byte SellSide = 4;

        /// <summary>
        ///  Fix Tag for Leg Input Source
        /// </summary>
        public const ushort FixTag = 25153;

        /// <summary>
        ///  Length of Leg Input Source in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Leg Input Source
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + LegInputSource.Length)
            {
                throw new System.Exception("Invalid Length for Leg Input Source");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Input Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + LegInputSource.Length;
        }

        /// <summary>
        ///  TryDecode Leg Input Source
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LegInputSource.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Input Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegInputSource.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Input Source
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}