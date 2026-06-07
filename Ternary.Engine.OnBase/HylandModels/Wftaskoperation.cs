using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wftaskoperation
{
    public long Taskopnum { get; set; }

    public string? Taskopguid { get; set; }

    public long? Sessionid { get; set; }

    public long? Usernum { get; set; }

    public long? Status { get; set; }

    public DateTime? Createddatetime { get; set; }

    public DateTime? Lastmodifieddatetime { get; set; }

    public string? Taskdata { get; set; }

    public long? Requestcancel { get; set; }

    public string? Servername { get; set; }

    public string? Domain { get; set; }

    public long? Flags { get; set; }
}
