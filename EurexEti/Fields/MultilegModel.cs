using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Multileg Model: Enum
    /// </summary>

    public static class MultilegModel
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
        ///  Fix Tag for Multileg Model
        /// </summary>
        public const ushort FixTag = 1377;

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
        ///  Check available length and set Multileg Model to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MultilegModel.Length)
            {
                throw new System.Exception("Invalid Length for Multileg Model");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Multileg Model to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MultilegModel.Length;
        }

        /// <summary>
        ///  Set Multileg Model to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Multileg Model
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MultilegModel.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Multileg Model
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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