using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uffiulog
{
    public long Uffiulognum { get; set; }

    public long? Updatetype { get; set; }

    public long? Ufformnum { get; set; }

    public long? Formrevnum { get; set; }

    public long? Targetformrevnum { get; set; }

    public long? Updatestatus { get; set; }

    public long? Formstoupdate { get; set; }

    public long? Formsupdated { get; set; }

    public long? Formsfailed { get; set; }

    public long? Itemnum { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }

    public long? Parentuffiulognum { get; set; }
}
