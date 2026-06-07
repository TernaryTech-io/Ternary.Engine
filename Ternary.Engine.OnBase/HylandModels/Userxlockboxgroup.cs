using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userxlockboxgroup
{
    public long Lockboxgroupnum { get; set; }

    public long? Usernum { get; set; }

    public string Externaluserid { get; set; } = null!;
}
