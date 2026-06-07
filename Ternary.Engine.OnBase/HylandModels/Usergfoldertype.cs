using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Usergfoldertype
{
    public long Usergroupnum { get; set; }

    public long Foldertypenum { get; set; }

    public long? Privoverrides { get; set; }
}
