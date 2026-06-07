using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Roimetadatum
{
    public long Fieldnum { get; set; }

    public string? Roifieldname { get; set; }

    public string? Displayname { get; set; }

    public long? Chartfieldnum { get; set; }

    public long? Flags { get; set; }
}
