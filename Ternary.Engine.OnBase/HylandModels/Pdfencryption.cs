using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pdfencryption
{
    public string? Pdfownerpassword { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
