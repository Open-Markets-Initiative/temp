using System.Runtime.CompilerServices;

namespace Eurex.Eti.v130;

/// <summary>
///  List Update Action: Enum
/// </summary>

public static class ListUpdateAction
{
    /// <summary>
    ///  Add (Invocation)
    /// </summary>
    public const char Add = 'A';

    /// <summary>
    ///  Delete (Release)
    /// </summary>
    public const char Delete = 'D';

    /// <summary>
    ///  Fix Tag for List Update Action
    /// </summary>
    public const ushort FixTag = 1324;

    /// <summary>
    ///  Length of List Update Action in bytes
    /// </summary>
    public const int Length = 1;

    /// <summary>
    ///  Encode List Update Action
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
    {
        if (length > offset + ListUpdateAction.Length)
        {
            throw new System.Exception("Invalid Length for List Update Action");
        }

        Encode(pointer, offset, value, out current);
    }

    /// <summary>
    ///  Encode List Update Action
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
    {
        var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

        Encode(pointer, offset, character, out current);
    }

    /// <summary>
    ///  Encode List Update Action
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
    {
        *(char*) (pointer + offset) = value;

        current = offset + ListUpdateAction.Length;
    }

    /// <summary>
    ///  TryDecode List Update Action
    /// </summary>
    public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
    {
        if (length > offset + ListUpdateAction.Length)
        {
            value = Decode(pointer, offset, out current);

            return true;
        }

        value = default;

        current = offset;

        return false;
    }

    /// <summary>
    ///  Decode List Update Action
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset, out int current)
    {
        current = offset + ListUpdateAction.Length;

        return Decode(pointer, offset);
    }

    /// <summary>
    ///  Decode List Update Action
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe static char Decode(byte* pointer, int offset)
    {
        return *(char*) (pointer + offset);
    }
}
