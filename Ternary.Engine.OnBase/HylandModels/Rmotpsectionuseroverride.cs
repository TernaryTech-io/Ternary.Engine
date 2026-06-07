using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmotpsectionuseroverride
{
    public long Overrideid { get; set; }

    public long? Enabled { get; set; }

    public long? Sectionid { get; set; }

    public string? Sectionname { get; set; }

    public long? Sequenceid { get; set; }

    public long? Usernum { get; set; }
}
