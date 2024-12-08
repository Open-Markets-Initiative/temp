using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Detail Id Executing Unit: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class PartyDetailIdExecutingUnit
    {
        /// <summary>
        ///  Fix Tag for Party Detail Id Executing Unit
        /// </summary>
        public const ushort FixTag = 20259;

        /// <summary>
        ///  Length of Party Detail Id Executing Unit in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Party Detail Id Executing Unit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + PartyDetailIdExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Id Executing Unit");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Detail Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PartyDetailIdExecutingUnit.Length;
        }

        /// <summary>
        ///  Encode Party Detail Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Party Detail Id Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + PartyDetailIdExecutingUnit.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Detail Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyDetailIdExecutingUnit.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Detail Id Executing Unit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}