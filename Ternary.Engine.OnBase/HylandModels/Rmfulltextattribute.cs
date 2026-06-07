using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmfulltextattribute
{
    public long Fulltextattributeid { get; set; }

    public long? Catalogid { get; set; }

    public long? Classid { get; set; }

    public string? Dataaddress { get; set; }

    public string? Rmfieldname { get; set; }

    public long? Sequenceid { get; set; }

    public long? Flags { get; set; }
}
