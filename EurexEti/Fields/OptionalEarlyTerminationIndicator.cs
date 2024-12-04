using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Optional Early Termination Indicator: Enum
    /// </summary>

    public sealed class OptionalEarlyTerminationIndicator
    {
        /// <summary>
        ///  No
        /// </summary>
        public const byte No = 0;

        /// <summary>
        ///  Yes
        /// </summary>
        public const byte Yes = 1;

        /// <summary>
        ///  Fix Tag for Optional Early Termination Indicator
        /// </summary>
        public const ushort FixTag = 25247;

        /// <summary>
        ///  Length of Optional Early Termination Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Optional Early Termination Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OptionalEarlyTerminationIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Optional Early Termination Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Optional Early Termination Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OptionalEarlyTerminationIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Optional Early Termination Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OptionalEarlyTerminationIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Optional Early Termination Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OptionalEarlyTerminationIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Optional Early Termination Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}