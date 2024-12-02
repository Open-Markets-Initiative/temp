using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Ref Appl Id: Enum
    /// </summary>

    public sealed class RefApplId
    {
        /// <summary>
        ///  Trade
        /// </summary>
        public const byte Trade = 1;

        /// <summary>
        ///  News
        /// </summary>
        public const byte News = 2;

        /// <summary>
        ///  Service Availability
        /// </summary>
        public const byte Serviceavailability = 3;

        /// <summary>
        ///  Session Data
        /// </summary>
        public const byte Sessiondata = 4;

        /// <summary>
        ///  Listener Data
        /// </summary>
        public const byte Listenerdata = 5;

        /// <summary>
        ///  Risk Control
        /// </summary>
        public const byte RiskControl = 6;

        /// <summary>
        ///  TES Maintenance
        /// </summary>
        public const byte TesMaintenance = 7;

        /// <summary>
        ///  TES Trade
        /// </summary>
        public const byte TesTrade = 8;

        /// <summary>
        ///  SRQS Maintenance
        /// </summary>
        public const byte SrqsMaintenance = 9;

        /// <summary>
        ///  Service Availability Market
        /// </summary>
        public const byte ServiceAvailabilityMarket = 10;

        /// <summary>
        ///  
        /// </summary>
        public const byte RefApplIDMaximumValue = 11;

        /// <summary>
        ///  
        /// </summary>
        public const byte RefApplIDMinimumValue = 0;

        /// <summary>
        ///  Length of Ref Appl Id in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Ref Appl Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RefApplId.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ref Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RefApplId.Length;
        }

        /// <summary>
        ///  TryDecode Ref Appl Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RefApplId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Ref Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RefApplId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ref Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}