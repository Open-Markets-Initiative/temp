using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Request Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class CrossRequestId
    {
        /// <summary>
        ///  Fix Tag for Cross Request Id
        /// </summary>
        public const ushort FixTag = 2672;

        /// <summary>
        ///  Length of Cross Request Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Cross Request Id
        /// </summary>
        public const int NoValue = 0x80000000;

        /// <summary>
        ///  Encode Cross Request Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + CrossRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Cross Request Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + CrossRequestId.Length;
        }

        /// <summary>
        ///  Encode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Cross Request Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + CrossRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Cross Request Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Cross Request Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + CrossRequestId.Length;
        }

        /// <summary>
        ///  Set Cross Request Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(int*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Cross Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + CrossRequestId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Cross Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CrossRequestId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cross Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}