using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Exec Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ExecId
    {
        /// <summary>
        ///  Length of Exec Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Exec Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ExecId.Length)
            {
                throw new System.Exception("Invalid Length for Exec Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ExecId.Length;
        }

        /// <summary>
        ///  Encode Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ExecId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExecId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}