using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Parsedqueue
{
    public long Batchnum { get; set; }

    public string? Batchfilename { get; set; }

    public string? Parsefilename { get; set; }

    public long? Parsefilenum { get; set; }

    public DateTime? Datestarted { get; set; }

    public DateTime? Dateended { get; set; }

    public long? Archiveflags { get; set; }

    public long? Parsingmethod { get; set; }

    public DateTime? Itemdate { get; set; }

    public string? Filepath { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Logicalplatternum { get; set; }

    public long? Numberdocuments { get; set; }

    public long? Tmpdiskgroupnum { get; set; }

    public long? Tmplogicalplttrnum { get; set; }

    public long? Status { get; set; }

    public long? Usernum { get; set; }

    public long? Verifyitemnum { get; set; }

    public long? Lastusedplatter { get; set; }

    public DateTime? Printeddate { get; set; }

    public long? Processflag { get; set; }

    public long? Parserclass { get; set; }
}
