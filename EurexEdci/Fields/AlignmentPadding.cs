namespace Eurex.Edci.v130;

/// <summary>
///  Alignment Padding: Alignment Padding
/// </summary>

public static class AlignmentPadding
{

    /// <summary>
    ///  Encode Alignment Padding
    /// </summary>
    public unsafe static void Encode(byte* pointer, int offset, int length, out int current)
    {
        var position = pointer + offset;

        for (var i = 0; i < length; i++)
        {
            *(position++) = 0;
        }

        current = offset + length;
    }
}
