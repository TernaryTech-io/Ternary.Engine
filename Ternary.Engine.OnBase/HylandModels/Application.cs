using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Application
{
    public long Appnum { get; set; }

    public string? Appname { get; set; }

    public string? Apppath { get; set; }

    public string? Uncpath { get; set; }

    public string? Uncbackpath { get; set; }

    public long? Flags { get; set; }

    public string? Appversion { get; set; }

    public string? Apphash { get; set; }
}
