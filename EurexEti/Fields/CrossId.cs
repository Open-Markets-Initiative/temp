using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class CrossId
    {
        /// <summary>
        ///  Fix Tag for Cross Id
        /// </summary>
        public const ushort FixTag = 548;

        /// <summary>
        ///  Length of Cross Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Cross Id
        /// </summary>
        public const int NoValue = 0x80000000;

        /// <summary>
        ///  Encode Cross Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + CrossId.Length)
            {
                throw new System.Exception("Invalid Length for Cross Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + CrossId.Length;
        }

        /// <summary>
        ///  Encode Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Cross Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + CrossId.Length)
            {
                throw new System.Exception("Invalid Length for Cross Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Cross Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + CrossId.Length;
        }

        /// <summary>
        ///  Set Cross Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(int*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Cross Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + CrossId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Cross Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CrossId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}