using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Put Or Call: Enum
    /// </summary>

    public static class PutOrCall
    {
        /// <summary>
        ///  Put
        /// </summary>
        public const byte Put = 0;

        /// <summary>
        ///  Call
        /// </summary>
        public const byte Call = 1;

        /// <summary>
        ///  Fix Tag for Put Or Call
        /// </summary>
        public const ushort FixTag = 201;

        /// <summary>
        ///  Length of Put Or Call in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Put Or Call
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Put Or Call
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PutOrCall.Length)
            {
                throw new System.Exception("Invalid Length for Put Or Call");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PutOrCall.Length;
        }

        /// <summary>
        ///  Check available length and set Put Or Call to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PutOrCall.Length)
            {
                throw new System.Exception("Invalid Length for Put Or Call");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Put Or Call to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PutOrCall.Length;
        }

        /// <summary>
        ///  Set Put Or Call to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Put Or Call
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PutOrCall.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Put Or Call
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PutOrCall.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Put Or Call
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}