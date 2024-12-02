using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Detail Status: Enum
    /// </summary>

    public sealed class PartyDetailStatus
    {
        /// <summary>
        ///  Active
        /// </summary>
        public const byte Active = 0;

        /// <summary>
        ///  Suspend
        /// </summary>
        public const byte Suspend = 1;

        /// <summary>
        ///  Rejected
        /// </summary>
        public const byte Rejected = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte PartyDetailStatusMaximumValue = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte PartyDetailStatusMinimumValue = 0;

        /// <summary>
        ///  Length of Party Detail Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Party Detail Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyDetailStatus.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Detail Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyDetailStatus.Length;
        }

        /// <summary>
        ///  TryDecode Party Detail Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyDetailStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Detail Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyDetailStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Detail Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}