using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfpluginparam
{
    public long? Tpcfpluginnum { get; set; }

    public string? Tpcfparamname { get; set; }

    public string? Tpcfparamvalue { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }
}
