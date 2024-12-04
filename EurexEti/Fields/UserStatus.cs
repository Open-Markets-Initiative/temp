using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  User Status: Enum
    /// </summary>

    public sealed class UserStatus
    {
        /// <summary>
        ///  Forced user logout by exchange
        /// </summary>
        public const byte Userforcedlogout = 7;

        /// <summary>
        ///  Admission to trading suspended
        /// </summary>
        public const byte Userstopped = 10;

        /// <summary>
        ///  Suspension revoked
        /// </summary>
        public const byte Userreleased = 11;

        /// <summary>
        ///  Fix Tag for User Status
        /// </summary>
        public const ushort FixTag = 926;

        /// <summary>
        ///  Length of User Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode User Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + UserStatus.Length)
            {
                throw new System.Exception("Invalid Length for User Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode User Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + UserStatus.Length;
        }

        /// <summary>
        ///  TryDecode User Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + UserStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode User Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UserStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode User Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}