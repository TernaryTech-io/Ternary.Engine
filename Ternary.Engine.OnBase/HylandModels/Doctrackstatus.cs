using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctrackstatus
{
    public long Foldernum { get; set; }

    public long Itemtypenum { get; set; }

    public long Itemnum { get; set; }

    public long? Institution { get; set; }

    public long? Parentfoldertypenum { get; set; }

    public long? Documentstatus { get; set; }

    public DateTime? Docduedate { get; set; }

    public DateTime? Docwarningdate { get; set; }

    public DateTime? Docexpiredate { get; set; }

    public long? Flags { get; set; }
}
