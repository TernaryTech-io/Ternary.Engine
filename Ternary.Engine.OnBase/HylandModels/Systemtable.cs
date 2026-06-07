using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Systemtable
{
    public long? Maxpendbackups { get; set; }

    public long? Maxqitems { get; set; }

    public string Diskidname { get; set; } = null!;

    public long? Itfileversionnum { get; set; }

    public long? Updatefileflag1 { get; set; }

    public long? Updatefileflag2 { get; set; }

    public long? Updatefileflag3 { get; set; }

    public long? Updatefileflag4 { get; set; }

    public long? Wfdefimagenum { get; set; }

    public long? Wfdeftextnum { get; set; }

    public string? Liteloadpath { get; set; }

    public string? Exeupdatepath { get; set; }

    public long? Exeupdate { get; set; }

    public long? Exeupdateflags { get; set; }

    public string? Ftwebsite { get; set; }

    public long? Dosinterface { get; set; }

    public string? Fatpartitionname { get; set; }

    public long? Maxbadlogins { get; set; }

    public string? Defaultdbspace { get; set; }

    public string? Tempdbspace { get; set; }

    public long? Flags { get; set; }

    public long? Definstitution { get; set; }

    public string? Passworddllpath { get; set; }

    public string? Errorlogfile { get; set; }

    public long? Centurypivotyear { get; set; }

    public string? Passwordhash { get; set; }

    public long? Slowqueryminimum { get; set; }
}
