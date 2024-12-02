using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Tes Enrichment Rule Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class TesEnrichmentRuleId
    {
        /// <summary>
        ///  Length of Tes Enrichment Rule Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Tes Enrichment Rule Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + TesEnrichmentRuleId.Length)
            {
                throw new System.Exception("Invalid Length for Tes Enrichment Rule Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Tes Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TesEnrichmentRuleId.Length;
        }

        /// <summary>
        ///  Encode Tes Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Tes Enrichment Rule Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + TesEnrichmentRuleId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Tes Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TesEnrichmentRuleId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Tes Enrichment Rule Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}