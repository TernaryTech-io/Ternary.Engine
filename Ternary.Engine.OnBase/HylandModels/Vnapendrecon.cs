using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vnapendrecon
{
    public long Vnapendreconnum { get; set; }

    public long? Vnastudynum { get; set; }

    public long? Vnarevnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Vnarecontmplnum { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Vnapatreconstatus { get; set; }

    public long? Vnastudyreconstatus { get; set; }

    public long? Flags { get; set; }

    public string? Studyinstanceuid { get; set; }

    public string? Studyhash { get; set; }
}
