using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Smartdocfield
{
    public long Receiverid { get; set; }

    public long Keyid { get; set; }

    public long Itemtypenum { get; set; }

    public long? Systemkeynum { get; set; }

    public string? Fieldvalue { get; set; }
}
