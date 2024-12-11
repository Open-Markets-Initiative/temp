using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Activation Date: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class ActivationDate
    {
        /// <summary>
        ///  Fix Tag for Activation Date
        /// </summary>
        public const ushort FixTag = 28905;

        /// <summary>
        ///  Length of Activation Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Activation Date
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Activation Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ActivationDate.Length)
            {
                throw new System.Exception("Invalid Length for Activation Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Activation Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ActivationDate.Length;
        }

        /// <summary>
        ///  Encode Activation Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Activation Date to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ActivationDate.Length)
            {
                throw new System.Exception("Invalid Length for Activation Date");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Activation Date to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ActivationDate.Length;
        }

        /// <summary>
        ///  Set Activation Date to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Activation Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ActivationDate.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Activation Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Activation Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ActivationDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Activation Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}