using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmattributemapping
{
    public long Attributemappingid { get; set; }

    public string? Dataaddress { get; set; }

    public long? Instancemappingid { get; set; }

    public long? Keyfield { get; set; }

    public string? Multiplevaluesxpathroot { get; set; }

    public long? Parentid { get; set; }

    public string? Xpath { get; set; }
}
