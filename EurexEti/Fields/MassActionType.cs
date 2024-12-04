using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Action Type: Enum
    /// </summary>

    public sealed class MassActionType
    {
        /// <summary>
        ///  Suspend quotes
        /// </summary>
        public const byte Suspendquotes = 1;

        /// <summary>
        ///  Release quotes from suspension
        /// </summary>
        public const byte Releasequotes = 2;

        /// <summary>
        ///  Suspend and delete Quotes
        /// </summary>
        public const byte Suspenddeletequotes = 3;

        /// <summary>
        ///  Fix Tag for Mass Action Type
        /// </summary>
        public const ushort FixTag = 1373;

        /// <summary>
        ///  Length of Mass Action Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Mass Action Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MassActionType.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MassActionType.Length;
        }

        /// <summary>
        ///  TryDecode Mass Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MassActionType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mass Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassActionType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}