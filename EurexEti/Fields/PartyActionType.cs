using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Action Type: Enum
    /// </summary>

    public sealed class PartyActionType
    {
        /// <summary>
        ///  Halt trading
        /// </summary>
        public const byte HaltTrading = 1;

        /// <summary>
        ///  Reinstate
        /// </summary>
        public const byte Reinstate = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte PartyActionTypeMaximumValue = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte PartyActionTypeMinimumValue = 1;

        /// <summary>
        ///  Length of Party Action Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Party Action Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyActionType.Length)
            {
                throw new System.Exception("Invalid Length for Party Action Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyActionType.Length;
        }

        /// <summary>
        ///  TryDecode Party Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyActionType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyActionType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}