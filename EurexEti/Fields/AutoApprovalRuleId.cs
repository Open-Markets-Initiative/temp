using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Auto Approval Rule Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class AutoApprovalRuleId
    {
        /// <summary>
        ///  Fix Tag for Auto Approval Rule Id
        /// </summary>
        public const ushort FixTag = 25181;

        /// <summary>
        ///  Length of Auto Approval Rule Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Auto Approval Rule Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + AutoApprovalRuleId.Length)
            {
                throw new System.Exception("Invalid Length for Auto Approval Rule Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Auto Approval Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + AutoApprovalRuleId.Length;
        }

        /// <summary>
        ///  Encode Auto Approval Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Auto Approval Rule Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + AutoApprovalRuleId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Auto Approval Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + AutoApprovalRuleId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Auto Approval Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}