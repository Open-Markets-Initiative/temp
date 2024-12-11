using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Tes Enrichment Rule Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class TesEnrichmentRuleId
    {
        /// <summary>
        ///  Fix Tag for Tes Enrichment Rule Id
        /// </summary>
        public const ushort FixTag = 25180;

        /// <summary>
        ///  Length of Tes Enrichment Rule Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Tes Enrichment Rule Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

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
        ///  Check available length and set Tes Enrichment Rule Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TesEnrichmentRuleId.Length)
            {
                throw new System.Exception("Invalid Length for Tes Enrichment Rule Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Tes Enrichment Rule Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TesEnrichmentRuleId.Length;
        }

        /// <summary>
        ///  Set Tes Enrichment Rule Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Tes Enrichment Rule Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + TesEnrichmentRuleId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Tes Enrichment Rule Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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