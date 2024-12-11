using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Inventory Check Type: Enum
    /// </summary>

    public static class InventoryCheckType
    {
        /// <summary>
        ///  Do not check
        /// </summary>
        public const byte Donotcheck = 0;

        /// <summary>
        ///  Check
        /// </summary>
        public const byte Check = 1;

        /// <summary>
        ///  Fix Tag for Inventory Check Type
        /// </summary>
        public const ushort FixTag = 25240;

        /// <summary>
        ///  Length of Inventory Check Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Inventory Check Type
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Inventory Check Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + InventoryCheckType.Length)
            {
                throw new System.Exception("Invalid Length for Inventory Check Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Inventory Check Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + InventoryCheckType.Length;
        }

        /// <summary>
        ///  Check available length and set Inventory Check Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + InventoryCheckType.Length)
            {
                throw new System.Exception("Invalid Length for Inventory Check Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Inventory Check Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + InventoryCheckType.Length;
        }

        /// <summary>
        ///  Set Inventory Check Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Inventory Check Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + InventoryCheckType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Inventory Check Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Inventory Check Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + InventoryCheckType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Inventory Check Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}