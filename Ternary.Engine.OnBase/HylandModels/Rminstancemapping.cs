using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rminstancemapping
{
    public long Instancemappingid { get; set; }

    public string? Classname { get; set; }

    public string? Dataaddress { get; set; }

    public long? Parentid { get; set; }

    public long? Transfertemplateid { get; set; }

    public string? Xpath { get; set; }
}
