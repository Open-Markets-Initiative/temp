using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Exec Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class QuoteEventExecId
    {
        /// <summary>
        ///  Fix Tag for Quote Event Exec Id
        /// </summary>
        public const ushort FixTag = 28711;

        /// <summary>
        ///  Length of Quote Event Exec Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Quote Event Exec Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + QuoteEventExecId.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Exec Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + QuoteEventExecId.Length;
        }

        /// <summary>
        ///  Encode Quote Event Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Quote Event Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + QuoteEventExecId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Event Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventExecId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}