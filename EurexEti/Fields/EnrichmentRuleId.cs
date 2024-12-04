using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Enrichment Rule Id: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class EnrichmentRuleId
    {
        /// <summary>
        ///  Fix Tag for Enrichment Rule Id
        /// </summary>
        public const ushort FixTag = 25033;

        /// <summary>
        ///  Length of Enrichment Rule Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Enrichment Rule Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + EnrichmentRuleId.Length)
            {
                throw new System.Exception("Invalid Length for Enrichment Rule Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + EnrichmentRuleId.Length;
        }

        /// <summary>
        ///  Encode Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Enrichment Rule Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + EnrichmentRuleId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EnrichmentRuleId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}