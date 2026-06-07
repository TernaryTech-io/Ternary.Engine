using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Chtcorrection
{
    public long Chtcorrectionnum { get; set; }

    public long? Chtnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Itemtypenum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Usercreated { get; set; }

    public DateTime? Datecompleted { get; set; }

    public long? Userassigned { get; set; }

    public long? Status { get; set; }

    public long? Requesttype { get; set; }

    public long? Flags { get; set; }

    public long? Primaryphysnum { get; set; }

    public long? Secondaryphysnum { get; set; }

    public long? Newitemtypenum { get; set; }
}
