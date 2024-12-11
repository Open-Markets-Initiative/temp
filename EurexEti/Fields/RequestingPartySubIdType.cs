using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Requesting Party Sub Id Type: Enum
    /// </summary>

    public static class RequestingPartySubIdType
    {
        /// <summary>
        ///  Requester
        /// </summary>
        public const ushort Requester = 5000;

        /// <summary>
        ///  Responder
        /// </summary>
        public const ushort Responder = 5001;

        /// <summary>
        ///  Both (Requester and Responder)
        /// </summary>
        public const ushort Both = 5002;

        /// <summary>
        ///  System
        /// </summary>
        public const ushort System = 5003;

        /// <summary>
        ///  Fix Tag for Requesting Party Sub Id Type
        /// </summary>
        public const ushort FixTag = 1663;

        /// <summary>
        ///  Length of Requesting Party Sub Id Type in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Requesting Party Sub Id Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + RequestingPartySubIdType.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Sub Id Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Requesting Party Sub Id Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            *(ushort*) (pointer + offset) = value;

            current = offset + RequestingPartySubIdType.Length;
        }

        /// <summary>
        ///  Check available length and set Requesting Party Sub Id Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RequestingPartySubIdType.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Sub Id Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Requesting Party Sub Id Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RequestingPartySubIdType.Length;
        }

        /// <summary>
        ///  Set Requesting Party Sub Id Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ushort*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Requesting Party Sub Id Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + RequestingPartySubIdType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Requesting Party Sub Id Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Requesting Party Sub Id Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestingPartySubIdType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Requesting Party Sub Id Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}