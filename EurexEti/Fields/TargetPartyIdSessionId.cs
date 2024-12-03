using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Target Party Id Session Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class TargetPartyIdSessionId
    {
        /// <summary>
        ///  Fix Tag for Target Party Id Session Id
        /// </summary>
        public const ushort FixTag = 20655;

        /// <summary>
        ///  Length of Target Party Id Session Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Target Party Id Session Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + TargetPartyIdSessionId.Length)
            {
                throw new System.Exception("Invalid Length for Target Party Id Session Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Target Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TargetPartyIdSessionId.Length;
        }

        /// <summary>
        ///  Encode Target Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Target Party Id Session Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + TargetPartyIdSessionId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Target Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TargetPartyIdSessionId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Target Party Id Session Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}