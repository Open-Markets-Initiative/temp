using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quantity Scaling Factor: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public static class QuantityScalingFactor
    {
        /// <summary>
        ///  Fix Tag for Quantity Scaling Factor
        /// </summary>
        public const ushort FixTag = 28907;

        /// <summary>
        ///  Length of Quantity Scaling Factor in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Quantity Scaling Factor
        /// </summary>
        public const ushort NoValue = 0xFFFF;

        /// <summary>
        ///  Encode Quantity Scaling Factor
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + QuantityScalingFactor.Length)
            {
                throw new System.Exception("Invalid Length for Quantity Scaling Factor");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + QuantityScalingFactor.Length;
        }

        /// <summary>
        ///  Encode Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Quantity Scaling Factor to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuantityScalingFactor.Length)
            {
                throw new System.Exception("Invalid Length for Quantity Scaling Factor");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quantity Scaling Factor to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuantityScalingFactor.Length;
        }

        /// <summary>
        ///  Set Quantity Scaling Factor to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ushort*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quantity Scaling Factor
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + QuantityScalingFactor.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quantity Scaling Factor
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuantityScalingFactor.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quantity Scaling Factor
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}