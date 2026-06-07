using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmusersetting
{
    public long? Rmobjecttype { get; set; }

    public long? Rmobjectkey { get; set; }

    public long? Usernum { get; set; }

    public long? Usergroupnum { get; set; }

    public string? Settingtype { get; set; }

    public string? Rmsettingvalue { get; set; }

    public long? Flags { get; set; }
}
