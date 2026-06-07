using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unityappinfo
{
    public long Unityappnum { get; set; }

    public string? Unityappname { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Lastmodified { get; set; }

    public string? Unityappdesc { get; set; }

    public long? Unityappstatus { get; set; }

    public string? Identityname { get; set; }
}
