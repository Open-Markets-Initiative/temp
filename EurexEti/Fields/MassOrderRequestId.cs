using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Order Request Id: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class MassOrderRequestId
    {
        /// <summary>
        ///  Fix Tag for Mass Order Request Id
        /// </summary>
        public const ushort FixTag = 2423;

        /// <summary>
        ///  Length of Mass Order Request Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Mass Order Request Id
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Mass Order Request Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + MassOrderRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Mass Order Request Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MassOrderRequestId.Length;
        }

        /// <summary>
        ///  Encode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Mass Order Request Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MassOrderRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Mass Order Request Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Mass Order Request Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MassOrderRequestId.Length;
        }

        /// <summary>
        ///  Set Mass Order Request Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Mass Order Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + MassOrderRequestId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Mass Order Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassOrderRequestId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}