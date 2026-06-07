using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmusergattribute
{
    public long Usergattributeid { get; set; }

    public long? Attributeid { get; set; }

    public long? Classid { get; set; }

    public long? Usergroupnum { get; set; }

    public long? Usergrouprights { get; set; }
}
