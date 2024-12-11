using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Expire Date: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class ExpireDate
    {
        /// <summary>
        ///  Fix Tag for Expire Date
        /// </summary>
        public const ushort FixTag = 432;

        /// <summary>
        ///  Length of Expire Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Expire Date
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Expire Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ExpireDate.Length)
            {
                throw new System.Exception("Invalid Length for Expire Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Expire Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ExpireDate.Length;
        }

        /// <summary>
        ///  Encode Expire Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Expire Date to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ExpireDate.Length)
            {
                throw new System.Exception("Invalid Length for Expire Date");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Expire Date to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ExpireDate.Length;
        }

        /// <summary>
        ///  Set Expire Date to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Expire Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ExpireDate.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Expire Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Expire Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExpireDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Expire Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}