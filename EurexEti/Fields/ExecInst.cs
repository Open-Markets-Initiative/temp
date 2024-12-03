using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Exec Inst: Enum
    /// </summary>

    public sealed class ExecInst
    {
        /// <summary>
        ///  Persistent Order (FIX value 'H')
        /// </summary>
        public const byte H = 1;

        /// <summary>
        ///  Non-persistent Order (FIX value 'Q')
        /// </summary>
        public const byte Q = 2;

        /// <summary>
        ///  Persistent and non-persistent orders affected (FIX value 'H Q')
        /// </summary>
        public const byte Hq = 3;

        /// <summary>
        ///  Persistent and Book or Cancel order (FIX value 'H 6')
        /// </summary>
        public const byte H6 = 5;

        /// <summary>
        ///  Non-persistent and Book or Cancel order (FIX value 'Q 6')
        /// </summary>
        public const byte Q6 = 6;

        /// <summary>
        ///  Fix Tag for Exec Inst
        /// </summary>
        public const ushort FixTag = 18;

        /// <summary>
        ///  Length of Exec Inst in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Exec Inst
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ExecInst.Length)
            {
                throw new System.Exception("Invalid Length for Exec Inst");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Exec Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ExecInst.Length;
        }

        /// <summary>
        ///  TryDecode Exec Inst
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ExecInst.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Exec Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExecInst.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Exec Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}