using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quantity Scaling Factor: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class QuantityScalingFactor
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
        ///  TryDecode Quantity Scaling Factor
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + QuantityScalingFactor.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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