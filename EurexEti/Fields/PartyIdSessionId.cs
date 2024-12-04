using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Session Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class PartyIdSessionId
    {
        /// <summary>
        ///  Fix Tag for Party Id Session Id
        /// </summary>
        public const ushort FixTag = 20055;

        /// <summary>
        ///  Length of Party Id Session Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Party Id Session Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + PartyIdSessionId.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Session Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PartyIdSessionId.Length;
        }

        /// <summary>
        ///  Encode Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Party Id Session Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + PartyIdSessionId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdSessionId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}