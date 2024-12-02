using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl Seq Status: Enum
    /// </summary>

    public sealed class ApplSeqStatus
    {
        /// <summary>
        ///  Unavailable
        /// </summary>
        public const byte Unavailable = 0;

        /// <summary>
        ///  Available
        /// </summary>
        public const byte Available = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ApplSeqStatusMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ApplSeqStatusMinimumValue = 0;

        /// <summary>
        ///  Length of Appl Seq Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Appl Seq Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ApplSeqStatus.Length)
            {
                throw new System.Exception("Invalid Length for Appl Seq Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Seq Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ApplSeqStatus.Length;
        }

        /// <summary>
        ///  TryDecode Appl Seq Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ApplSeqStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Seq Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplSeqStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Seq Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}