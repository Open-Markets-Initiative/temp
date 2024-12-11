using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Ref Appl Sub Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class RefApplSubId
    {
        /// <summary>
        ///  Fix Tag for Ref Appl Sub Id
        /// </summary>
        public const ushort FixTag = 28728;

        /// <summary>
        ///  Length of Ref Appl Sub Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Ref Appl Sub Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Ref Appl Sub Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + RefApplSubId.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Sub Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RefApplSubId.Length;
        }

        /// <summary>
        ///  Encode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Ref Appl Sub Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RefApplSubId.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Sub Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Ref Appl Sub Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RefApplSubId.Length;
        }

        /// <summary>
        ///  Set Ref Appl Sub Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Ref Appl Sub Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + RefApplSubId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Ref Appl Sub Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RefApplSubId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ref Appl Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}