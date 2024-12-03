using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Risk Limit Action: Enum
    /// </summary>

    public sealed class RiskLimitAction
    {
        /// <summary>
        ///  Queue Inbound
        /// </summary>
        public const byte QueueInbound = 0;

        /// <summary>
        ///  Reject
        /// </summary>
        public const byte Reject = 2;

        /// <summary>
        ///  Warning
        /// </summary>
        public const byte Warning = 4;

        /// <summary>
        ///  Fix Tag for Risk Limit Action
        /// </summary>
        public const ushort FixTag = 1767;

        /// <summary>
        ///  Length of Risk Limit Action in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Risk Limit Action
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RiskLimitAction.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Action");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Action
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RiskLimitAction.Length;
        }

        /// <summary>
        ///  TryDecode Risk Limit Action
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskLimitAction.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Risk Limit Action
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitAction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Action
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}