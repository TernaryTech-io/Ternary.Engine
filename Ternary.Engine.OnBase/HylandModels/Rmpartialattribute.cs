using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmpartialattribute
{
    public long Partialattributeid { get; set; }

    public long? Partialid { get; set; }

    public string? Dataaddress { get; set; }

    public string? Displayname { get; set; }

    public long? Flags { get; set; }
}
