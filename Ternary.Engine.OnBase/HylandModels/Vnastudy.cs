using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnastudy
{
    public long Vnastudynum { get; set; }

    public string? Studyinstanceuid { get; set; }

    public long? Itemnum { get; set; }

    public long? Viewtemplatenum { get; set; }

    public long? Externalaenum { get; set; }

    public DateTime? Studydate { get; set; }

    public string? Accessionnumber { get; set; }

    public string? Studyid { get; set; }

    public string? Studyhash { get; set; }

    public long? Flags { get; set; }

    public string? Studydescription { get; set; }

    public long Vnarevnum { get; set; }

    public long? Vnarevstatus { get; set; }

    public long? Vnarevreason { get; set; }

    public DateTime? Createdate { get; set; }
}
