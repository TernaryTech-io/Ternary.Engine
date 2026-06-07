using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Diskgroup
{
    public long Diskgroupnum { get; set; }

    public string? Diskgroupname { get; set; }

    public long? Currentdirectory { get; set; }

    public long? Diskgrouptype { get; set; }

    public long? Diskthreshold { get; set; }

    public long? Filesindirectory { get; set; }

    public long? Filesperdirectory { get; set; }

    public long? Lifespan { get; set; }

    public long? Numberofbackups { get; set; }

    public long? Ucautopromotespace { get; set; }

    public long? Autopromotespace { get; set; }

    public long? Lastlogicalplatter { get; set; }

    public string? Cachepath { get; set; }

    public long? Lpnumsyscache { get; set; }

    public long? Cachelpnum { get; set; }

    public long? Lpcachethreshold { get; set; }

    public long? Formatnum { get; set; }

    public long? Committedlp { get; set; }

    public long? Numberofexports { get; set; }

    public long? Prepathed { get; set; }

    public long? Exportmgrnum { get; set; }

    public long? Adminusernum { get; set; }

    public long? Retentionyears { get; set; }

    public long? Flags { get; set; }

    public string? Description { get; set; }
}
