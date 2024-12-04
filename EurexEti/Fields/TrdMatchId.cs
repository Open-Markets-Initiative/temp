using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trd Match Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class TrdMatchId
    {
        /// <summary>
        ///  Fix Tag for Trd Match Id
        /// </summary>
        public const ushort FixTag = 880;

        /// <summary>
        ///  Length of Trd Match Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Trd Match Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + TrdMatchId.Length)
            {
                throw new System.Exception("Invalid Length for Trd Match Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TrdMatchId.Length;
        }

        /// <summary>
        ///  Encode Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Trd Match Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + TrdMatchId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TrdMatchId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}