using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Id Executing Unit: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class PartyIdExecutingUnit
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
        ///  TryDecode Party Id Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + PartyIdExecutingUnit.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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