using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Subscription Scope: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class SubscriptionScope
    {
        /// <summary>
        ///  Fix Tag for Subscription Scope
        /// </summary>
        public const ushort FixTag = 25001;

        /// <summary>
        ///  Length of Subscription Scope in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Subscription Scope
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + SubscriptionScope.Length)
            {
                throw new System.Exception("Invalid Length for Subscription Scope");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Subscription Scope
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SubscriptionScope.Length;
        }

        /// <summary>
        ///  Encode Subscription Scope
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Subscription Scope
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SubscriptionScope.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Subscription Scope
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SubscriptionScope.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Subscription Scope
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}