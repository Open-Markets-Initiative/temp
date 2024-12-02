using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Detail Role Qualifier: Enum
    /// </summary>

    public sealed class PartyDetailRoleQualifier
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
        ///  
        /// </summary>
        public const byte PartyDetailRoleQualifierMaximumValue = 12;

        /// <summary>
        ///  
        /// </summary>
        public const byte PartyDetailRoleQualifierMinimumValue = 10;

        /// <summary>
        ///  Length of Party Detail Role Qualifier in bytes
        /// </summary>
        public const int Length = 1;

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
        ///  TryDecode Party Detail Role Qualifier
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyDetailRoleQualifier.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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