using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Subscription Scope: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class SubscriptionScope
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
        ///  Null value for Subscription Scope
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

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
        ///  Check available length and set Subscription Scope to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SubscriptionScope.Length)
            {
                throw new System.Exception("Invalid Length for Subscription Scope");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Subscription Scope to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SubscriptionScope.Length;
        }

        /// <summary>
        ///  Set Subscription Scope to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Subscription Scope
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SubscriptionScope.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Subscription Scope
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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