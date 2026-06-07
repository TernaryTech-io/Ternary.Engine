using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmobject
{
    public long Objectid { get; set; }

    public long? Activestatus { get; set; }

    public long? Classid { get; set; }

    public string? Rmcreatedby { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Rmobjectname { get; set; }

    public long? Parentobjectid { get; set; }

    public long? Statusid { get; set; }

    public long? Writestatus { get; set; }

    public long? Usernum { get; set; }
}
