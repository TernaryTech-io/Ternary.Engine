using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmexternaldatasetinfo
{
    public long Datasetid { get; set; }

    public long? Bcache { get; set; }

    public string? Extcolumnname { get; set; }

    public string? Exttablename { get; set; }

    public string? Linkedserverdbname { get; set; }

    public string? Linkedservername { get; set; }

    public string? Rmextodbcpassword { get; set; }

    public string? Rmextodbcsourcename { get; set; }

    public string? Rmextodbcusername { get; set; }

    public long? Filterid { get; set; }

    public long? Encryptiontype { get; set; }

    public string? Initvectordata { get; set; }
}
