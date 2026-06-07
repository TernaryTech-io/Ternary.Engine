using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmviewitem
{
    public long Viewitemid { get; set; }

    public string? Displayname { get; set; }

    public long? Displaynamepos { get; set; }

    public string? Helptext { get; set; }

    public string? Itemname { get; set; }

    public long? Rmviewitemtype { get; set; }

    public long? Sequenceid { get; set; }

    public long? Viewid { get; set; }

    public long? Flags { get; set; }
}
