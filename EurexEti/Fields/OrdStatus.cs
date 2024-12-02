using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Ord Status: Enum
    /// </summary>

    public sealed class OrdStatus
    {
        /// <summary>
        ///  New
        /// </summary>
        public const char New = '0';

        /// <summary>
        ///  Partially filled
        /// </summary>
        public const char Partiallyfilled = '1';

        /// <summary>
        ///  Filled
        /// </summary>
        public const char Filled = '2';

        /// <summary>
        ///  Cancelled
        /// </summary>
        public const char Canceled = '4';

        /// <summary>
        ///  Pending Cancel (i.e. result of Order Cancel Request)
        /// </summary>
        public const char PendingCancel = '6';

        /// <summary>
        ///  Suspended
        /// </summary>
        public const char Suspended = '9';

        /// <summary>
        ///  Length of Ord Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Ord Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + OrdStatus.Length)
            {
                throw new System.Exception("Invalid Length for Ord Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ord Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Ord Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + OrdStatus.Length;
        }

        /// <summary>
        ///  TryDecode Ord Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + OrdStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Ord Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrdStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ord Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}