using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Contract Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class ContractDate
    {
        /// <summary>
        ///  Fix Tag for Contract Date
        /// </summary>
        public const ushort FixTag = 30866;

        /// <summary>
        ///  Length of Contract Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Contract Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ContractDate.Length)
            {
                throw new System.Exception("Invalid Length for Contract Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Contract Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ContractDate.Length;
        }

        /// <summary>
        ///  Encode Contract Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Contract Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ContractDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Contract Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ContractDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Contract Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}