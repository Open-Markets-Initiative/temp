using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Risk Control Rtm Service Status: Enum
    /// </summary>

    public sealed class RiskControlRtmServiceStatus
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
        ///  
        /// </summary>
        public const byte RiskControlRtmServiceStatusMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte RiskControlRtmServiceStatusMinimumValue = 0;

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
        ///  TryDecode Risk Control Rtm Service Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskControlRtmServiceStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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