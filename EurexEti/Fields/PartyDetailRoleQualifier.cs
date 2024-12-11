using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Detail Role Qualifier: Enum
    /// </summary>

    public static class PartyDetailRoleQualifier
    {
        /// <summary>
        ///  Trader
        /// </summary>
        public const byte Trader = 10;

        /// <summary>
        ///  Head Trader
        /// </summary>
        public const byte HeadTrader = 11;

        /// <summary>
        ///  Supervisor
        /// </summary>
        public const byte Supervisor = 12;

        /// <summary>
        ///  Fix Tag for Party Detail Role Qualifier
        /// </summary>
        public const ushort FixTag = 1674;

        /// <summary>
        ///  Length of Party Detail Role Qualifier in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Party Detail Role Qualifier
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Party Detail Role Qualifier
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyDetailRoleQualifier.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Role Qualifier");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Detail Role Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyDetailRoleQualifier.Length;
        }

        /// <summary>
        ///  Check available length and set Party Detail Role Qualifier to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyDetailRoleQualifier.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Role Qualifier");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Detail Role Qualifier to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyDetailRoleQualifier.Length;
        }

        /// <summary>
        ///  Set Party Detail Role Qualifier to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Party Detail Role Qualifier
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyDetailRoleQualifier.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Detail Role Qualifier
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Party Detail Role Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyDetailRoleQualifier.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Detail Role Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}