using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmsequence
{
    public long Sequenceid { get; set; }

    public long? Bsharable { get; set; }

    public string? Keyname { get; set; }

    public long? Keyvalue { get; set; }
}
