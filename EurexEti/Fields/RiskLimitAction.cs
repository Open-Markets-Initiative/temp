using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Action: Enum
    /// </summary>

    public static class RiskLimitAction
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
        ///  Null value for Risk Limit Action
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Risk Limit Action to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RiskLimitAction.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Action");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Risk Limit Action to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RiskLimitAction.Length;
        }

        /// <summary>
        ///  Set Risk Limit Action to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Risk Limit Action
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskLimitAction.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Risk Limit Action
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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