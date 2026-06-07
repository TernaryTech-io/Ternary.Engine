using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmresource101
{
    public long Resourceid { get; set; }

    public string? Rmresourcecontenttype { get; set; }

    public string? Resourcefilename { get; set; }

    public string? Resourcename { get; set; }

    public string? Resourcedata { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastmodified { get; set; }
}
