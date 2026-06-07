using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ocrformat
{
    public long Ocrformatnum { get; set; }

    public string? Ocrformatname { get; set; }

    public long? Preprocessflag { get; set; }

    public long? Recognitionengine { get; set; }

    public long? Languagetype { get; set; }

    public long? Languagefilter { get; set; }

    public long? Spellingflags { get; set; }

    public long? Outcodepage { get; set; }

    public long? Outfileformat { get; set; }

    public long? Filetypenum { get; set; }

    public long? Formatretention { get; set; }
}
