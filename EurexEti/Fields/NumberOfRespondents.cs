using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Number Of Respondents: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class NumberOfRespondents
    {
        /// <summary>
        ///  Fix Tag for Number Of Respondents
        /// </summary>
        public const ushort FixTag = 25150;

        /// <summary>
        ///  Length of Number Of Respondents in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Number Of Respondents
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + NumberOfRespondents.Length)
            {
                throw new System.Exception("Invalid Length for Number Of Respondents");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Number Of Respondents
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NumberOfRespondents.Length;
        }

        /// <summary>
        ///  Encode Number Of Respondents
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Number Of Respondents
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + NumberOfRespondents.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Number Of Respondents
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NumberOfRespondents.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Number Of Respondents
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}