using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade To Quote Ratio Position: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class TradeToQuoteRatioPosition
    {
        /// <summary>
        ///  Length of Trade To Quote Ratio Position in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Trade To Quote Ratio Position
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + TradeToQuoteRatioPosition.Length)
            {
                throw new System.Exception("Invalid Length for Trade To Quote Ratio Position");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TradeToQuoteRatioPosition.Length;
        }

        /// <summary>
        ///  Encode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Trade To Quote Ratio Position
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + TradeToQuoteRatioPosition.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeToQuoteRatioPosition.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}