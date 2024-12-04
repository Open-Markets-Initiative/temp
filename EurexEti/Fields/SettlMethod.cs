using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Settl Method: Enum
    /// </summary>

    public sealed class SettlMethod
    {
        /// <summary>
        ///  Cash Settlement
        /// </summary>
        public const char CashSettlement = 'C';

        /// <summary>
        ///  Physical Settlement
        /// </summary>
        public const char PhysicalSettlement = 'P';

        /// <summary>
        ///  Fix Tag for Settl Method
        /// </summary>
        public const ushort FixTag = 1193;

        /// <summary>
        ///  Length of Settl Method in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Settl Method
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + SettlMethod.Length)
            {
                throw new System.Exception("Invalid Length for Settl Method");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Settl Method
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Settl Method
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + SettlMethod.Length;
        }

        /// <summary>
        ///  TryDecode Settl Method
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + SettlMethod.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Settl Method
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SettlMethod.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Settl Method
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}