using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Detail Status: Enum
    /// </summary>

    public static class PartyDetailStatus
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
        ///  Fix Tag for Party Detail Status
        /// </summary>
        public const ushort FixTag = 1672;

        /// <summary>
        ///  Length of Party Detail Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Party Detail Status
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Party Detail Status to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyDetailStatus.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Status");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Detail Status to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyDetailStatus.Length;
        }

        /// <summary>
        ///  Set Party Detail Status to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Party Detail Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyDetailStatus.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Detail Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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