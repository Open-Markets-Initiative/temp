using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Control Rtm Service Status: Enum
    /// </summary>

    public static class RiskControlRtmServiceStatus
    {
        /// <summary>
        ///  Unavailable
        /// </summary>
        public const byte Unavailable = 0;

        /// <summary>
        ///  Available
        /// </summary>
        public const byte Available = 1;

        /// <summary>
        ///  Fix Tag for Risk Control Rtm Service Status
        /// </summary>
        public const ushort FixTag = 25238;

        /// <summary>
        ///  Length of Risk Control Rtm Service Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Risk Control Rtm Service Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RiskControlRtmServiceStatus.Length)
            {
                throw new System.Exception("Invalid Length for Risk Control Rtm Service Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Control Rtm Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RiskControlRtmServiceStatus.Length;
        }

        /// <summary>
        ///  Check available length and set Risk Control Rtm Service Status to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RiskControlRtmServiceStatus.Length)
            {
                throw new System.Exception("Invalid Length for Risk Control Rtm Service Status");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Risk Control Rtm Service Status to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RiskControlRtmServiceStatus.Length;
        }

        /// <summary>
        ///  Set Risk Control Rtm Service Status to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Risk Control Rtm Service Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskControlRtmServiceStatus.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Risk Control Rtm Service Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Risk Control Rtm Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskControlRtmServiceStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Control Rtm Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}