using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Appl Id: Enum
    /// </summary>

    public static class ApplId
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
        ///  Fix Tag for Appl Id
        /// </summary>
        public const ushort FixTag = 1180;

        /// <summary>
        ///  Length of Appl Id in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Appl Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ApplId.Length)
            {
                throw new System.Exception("Invalid Length for Appl Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ApplId.Length;
        }

        /// <summary>
        ///  Check available length and set Appl Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ApplId.Length)
            {
                throw new System.Exception("Invalid Length for Appl Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Appl Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ApplId.Length;
        }

        /// <summary>
        ///  Set Appl Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Appl Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ApplId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Appl Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}