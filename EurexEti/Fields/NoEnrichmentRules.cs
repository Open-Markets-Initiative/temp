using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Enrichment Rules: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoEnrichmentRules
    {
        /// <summary>
        ///  Fix Tag for No Enrichment Rules
        /// </summary>
        public const ushort FixTag = 28738;

        /// <summary>
        ///  Length of No Enrichment Rules in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Enrichment Rules
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoEnrichmentRules.Length)
            {
                throw new System.Exception("Invalid Length for No Enrichment Rules");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Enrichment Rules
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoEnrichmentRules.Length;
        }

        /// <summary>
        ///  Encode No Enrichment Rules
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Enrichment Rules
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoEnrichmentRules.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Enrichment Rules
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoEnrichmentRules.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Enrichment Rules
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}