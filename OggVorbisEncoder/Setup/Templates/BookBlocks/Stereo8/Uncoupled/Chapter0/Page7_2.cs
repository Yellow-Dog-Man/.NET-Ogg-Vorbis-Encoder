namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Uncoupled.Chapter0;

public class Page7_2 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 6, 5, 7, 7, 9, 9, 9, 9,10,12,12,10,11,11,10,
        11,11,11,10,11, 6, 8, 8, 9, 9,10,10, 9,10,11,11,
        10,11,11,11,11,10,11,11,11,11, 6, 7, 8, 9, 9, 9,
        10,11,10,11,12,11,10,11,11,11,11,11,11,12,10, 8,
         9, 9,10, 9,10,10, 9,10,10,10,10,10, 9,10,10,10,
        10, 9,10,10, 9, 9, 9, 9,10,10, 9, 9,10,10,11,10,
         9,12,10,11,10, 9,10,10,10, 8, 9, 9,10, 9,10, 9,
         9,10,10, 9,10, 9,11,10,10,10,10,10, 9,10, 8, 8,
         9, 9,10, 9,11, 9, 8, 9, 9,10,11,10,10,10,11,12,
         9, 9,11, 8, 9, 8,11,10,11,10,10, 9,11,10,10,10,
        10,10,10,10,11,11,11,11, 8, 9, 9, 9,10,10,10,11,
        11,12,11,12,11,10,10,10,12,11,11,11,10, 8,10, 9,
        11,10,10,11,12,10,11,12,11,11,12,11,12,12,10,11,
        11,10, 9, 9,10,11,12,10,10,10,11,10,11,11,10,12,
        12,10,11,10,11,12,10, 9,10,10,11,10,11,11,11,11,
        11,12,11,11,11, 9,11,10,11,10,11,10, 9, 9,10,11,
        11,11,10,10,11,12,12,11,12,11,11,11,12,12,12,12,
        11, 9,11,11,12,10,11,11,11,11,11,11,12,11,11,12,
        11,11,11,10,11,11, 9,11,10,11,11,11,10,10,10,11,
        11,11,12,10,11,10,11,11,11,11,12, 9,11,10,11,11,
        10,10,11,11, 9,11,11,12,10,10,10,10,10,11,11,10,
         9,10,11,11,12,11,10,10,12,11,11,12,11,12,11,11,
        10,10,11,11,10,12,11,10,11,10,11,10,10,10,11,11,
        10,10,11,11,11,11,10,10,10,12,11,11,11,11,10, 9,
        10,11,11,11,12,11,11,11,12,10,11,11,11, 9,10,11,
        11,11,11,11,11,10,10,11,11,12,11,10,11,12,11,10,
        10,11, 9,10,11,11,11,11,11,10,11,11,10,12,11,11,
        11,12,11,11,11,10,10,11,11,
};

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -529268736;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 5;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        10,
        9,
        11,
        8,
        12,
        7,
        13,
        6,
        14,
        5,
        15,
        4,
        16,
        3,
        17,
        2,
        18,
        1,
        19,
        0,
        20,
};
}
