using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Currencyformat
{
    public long Currencyformatnum { get; set; }

    public string? Decsymbol { get; set; }

    public string? Grpsymbol { get; set; }

    public string? Currsymbol { get; set; }

    public long? Currmask { get; set; }

    public long? Grpdigits { get; set; }

    public long? Decplaces { get; set; }

    public string? Currencyname { get; set; }

    public string? Isocurrencyname { get; set; }

    public long? Inuse { get; set; }
}
