using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimskeytypenew
{
    public long Lockboxnum { get; set; }

    public long Itemtypenum { get; set; }

    public long Keytypenum { get; set; }

    public long? Fieldseqnum { get; set; }

    public long? Fieldindex { get; set; }

    public string? Imsfieldname { get; set; }

    public long? Minlength { get; set; }

    public long? Maxlength { get; set; }

    public string? Imsfieldtype { get; set; }

    public string? Fieldmask { get; set; }

    public long? Issearchkey { get; set; }

    public long? Searchorder { get; set; }

    public long? Isresultskey { get; set; }

    public long? Resultsorder { get; set; }

    public long? Datatype { get; set; }
}
