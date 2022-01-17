namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter0;

public class Page4_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         3, 5, 5, 8, 8, 6, 6, 6, 9, 9, 6, 6, 6, 9, 9, 9,
        10, 9,11,11, 9, 9, 9,11,11, 6, 7, 7,10,10, 7, 7,
         8,10,10, 7, 7, 8,10,10,10,10,10,11,12, 9,10,10,
        11,12, 6, 7, 7,10,10, 7, 8, 7,10,10, 7, 8, 7,10,
        10,10,11,10,12,11,10,10,10,13,10, 9,10,10,12,12,
        10,11,10,14,12, 9,11,11,13,13,11,12,13,13,13,11,
        12,12,15,13, 9,10,10,12,13, 9,11,10,12,13,10,10,
        11,12,13,11,12,12,12,13,11,12,12,13,13, 5, 7, 7,
        10,10, 7, 8, 8,10,10, 7, 8, 8,10,10,10,11,10,12,
        13,10,10,11,12,12, 6, 8, 8,11,10, 7, 8, 9,10,12,
         8, 9, 9,11,11,11,10,11,11,12,10,11,11,13,12, 7,
         8, 8,10,11, 8, 9, 8,11,10, 8, 9, 9,11,11,10,12,
        10,13,11,10,11,11,13,13,10,11,10,14,13,10,10,11,
        13,13,10,12,11,14,13,12,11,13,12,13,13,12,13,14,
        14,10,11,11,13,13,10,11,10,12,13,10,12,12,12,14,
        12,12,12,14,12,12,13,12,17,15, 5, 7, 7,10,10, 7,
         8, 8,10,10, 7, 8, 8,11,10,10,10,11,12,12,10,11,
        11,12,13, 6, 8, 8,11,10, 8, 9, 9,11,11, 7, 8, 9,
        10,11,11,11,11,12,12,10,10,11,12,13, 6, 8, 8,10,
        11, 8, 9, 9,11,11, 7, 9, 7,11,10,10,12,12,13,13,
        11,11,10,13,11, 9,11,10,14,13,11,11,11,15,13,10,
        10,11,13,13,12,13,13,14,14,12,11,12,12,13,10,11,
        11,12,13,10,11,12,13,13,10,11,10,13,12,12,12,13,
        14, 0,12,13,11,13,11, 8,10,10,13,13,10,11,11,14,
        13,10,11,11,13,12,13,14,14,14,15,12,12,12,15,14,
         9,11,10,13,12,10,10,11,13,14,11,11,11,15,12,13,
        12,14,15,16,13,13,13,14,13, 9,11,11,12,12,10,12,
        11,13,13,10,11,11,13,14,13,13,13,15,15,13,13,14,
        17,15,11,12,12,14,14,10,11,12,13,15,12,13,13, 0,
        15,13,11,14,12,16,14,16,14, 0,15,11,12,12,14,16,
        11,13,12,16,15,12,13,13,14,15,12,14,12,15,13,15,
        14,14,16,16, 8,10,10,13,13,10,11,10,13,14,10,11,
        11,13,13,13,13,12,14,14,14,13,13,16,17, 9,10,10,
        12,14,10,12,11,14,13,10,11,12,13,14,12,12,12,15,
        15,13,13,13,14,14, 9,10,10,13,13,10,11,12,12,14,
        10,11,10,13,13,13,13,13,14,16,13,13,13,14,14,11,
        12,13,15,13,12,14,13,14,16,12,12,13,13,14,13,14,
        14,17,15,13,12,17,13,16,11,12,13,14,15,12,13,14,
        14,17,11,12,11,14,14,13,16,14,16, 0,14,15,11,15,
        11,
};

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -533725184;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 3;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        2,
        1,
        3,
        0,
        4,
};
}
