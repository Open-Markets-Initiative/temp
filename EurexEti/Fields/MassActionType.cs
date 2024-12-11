using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Action Type: Enum
    /// </summary>

    public static class MassActionType
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
        ///  Check available length and set Mass Action Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MassActionType.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Mass Action Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MassActionType.Length;
        }

        /// <summary>
        ///  Set Mass Action Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Mass Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MassActionType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Mass Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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