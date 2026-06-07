using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rptdataprovider
{
    public long Rptprovidernum { get; set; }

    public string? Rptdataprovidername { get; set; }

    public string? Queryengineid { get; set; }

    public string? Helptext { get; set; }

    public long? Usernum { get; set; }

    public long? Obblobnum { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Cachettl { get; set; }

    public long? Maxresultlimit { get; set; }

    public long? Flags { get; set; }

    public long? Dataprovidermode { get; set; }
}
