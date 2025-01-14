﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line1024X27_4Sub1 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 4, 5, 4, 5, 4, 5, 4, 5, 3, 5, 3, 5, 3, 5, 4,
        5, 4
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
