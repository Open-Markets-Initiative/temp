using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Multileg Model: Enum
    /// </summary>

    public sealed class MultilegModel
    {
        /// <summary>
        ///  Predefined Multileg Security
        /// </summary>
        public const byte PredefinedMultilegSecurity = 0;

        /// <summary>
        ///  User-defined Multleg Security
        /// </summary>
        public const byte UserdefinedMultleg = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte MultilegModelMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte MultilegModelMinimumValue = 0;

        /// <summary>
        ///  Length of Multileg Model in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Multileg Model
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MultilegModel.Length)
            {
                throw new System.Exception("Invalid Length for Multileg Model");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Multileg Model
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MultilegModel.Length;
        }

        /// <summary>
        ///  TryDecode Multileg Model
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MultilegModel.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Multileg Model
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MultilegModel.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Multileg Model
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}