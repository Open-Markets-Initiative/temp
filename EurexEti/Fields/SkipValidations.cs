using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Skip Validations: Enum
    /// </summary>

    public sealed class SkipValidations
    {
        /// <summary>
        ///  False
        /// </summary>
        public const byte False = 0;

        /// <summary>
        ///  True
        /// </summary>
        public const byte True = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte SkipValidationsMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte SkipValidationsMinimumValue = 0;

        /// <summary>
        ///  Length of Skip Validations in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Skip Validations
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SkipValidations.Length)
            {
                throw new System.Exception("Invalid Length for Skip Validations");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Skip Validations
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SkipValidations.Length;
        }

        /// <summary>
        ///  TryDecode Skip Validations
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SkipValidations.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Skip Validations
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SkipValidations.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Skip Validations
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}