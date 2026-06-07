using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctrackdocstatus
{
    public long? Foldernum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Institution { get; set; }

    public long? Parentfoldertypenum { get; set; }

    public long? Documentstatus { get; set; }

    public DateTime? Docduedate { get; set; }

    public long? Docduedateoverride { get; set; }

    public DateTime? Docwarningdate { get; set; }

    public DateTime? Docexpiredate { get; set; }

    public long? Docexpiredateoverride { get; set; }

    public long? Optionaltracking { get; set; }

    public long? Flags { get; set; }

    public long? Dueperiod { get; set; }

    public long? Expirationperiod { get; set; }

    public long? Warningperiod { get; set; }

    public long? Expirationcycle { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Expirationtype { get; set; }
}
