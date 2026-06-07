using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unityprojectinfo
{
    public long Unityprojectnum { get; set; }

    public string? Unityprojectname { get; set; }

    public string? Unityprojectdesc { get; set; }

    public long? Projectlanguage { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Usernum { get; set; }

    public long? Currentversion { get; set; }

    public long? Unityprojecttype { get; set; }

    public string? Unityprojectguid { get; set; }
}
