using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Executing Unit: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class PartyIdExecutingUnit
    {
        /// <summary>
        ///  Fix Tag for Party Id Executing Unit
        /// </summary>
        public const ushort FixTag = 20059;

        /// <summary>
        ///  Length of Party Id Executing Unit in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Party Id Executing Unit
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Party Id Executing Unit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + PartyIdExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Executing Unit");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PartyIdExecutingUnit.Length;
        }

        /// <summary>
        ///  Encode Party Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Party Id Executing Unit to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Executing Unit");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Executing Unit to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdExecutingUnit.Length;
        }

        /// <summary>
        ///  Set Party Id Executing Unit to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Party Id Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + PartyIdExecutingUnit.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Party Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdExecutingUnit.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}