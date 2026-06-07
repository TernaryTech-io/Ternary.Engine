using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Smartdoc
{
    public long Receiverid { get; set; }

    public long Itemtypenum { get; set; }

    public string? Extdoctype { get; set; }

    public string? Docdescription { get; set; }
}
