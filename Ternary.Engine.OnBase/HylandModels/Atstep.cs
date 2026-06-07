using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Atstep
{
    public long Atstepnum { get; set; }

    public long? Atprogramnum { get; set; }

    public long? Atstepgroupnum { get; set; }

    public long? Seqnum { get; set; }

    public long? Institution { get; set; }

    public long? Steptype { get; set; }

    public long? Autofolder { get; set; }

    public long? Dateoptions { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Processnum { get; set; }

    public long? Testonly { get; set; }

    public long? Languagenum { get; set; }

    public long? Allitemsflags { get; set; }

    public long? Fileoption { get; set; }

    public long? Erroroption { get; set; }

    public long? Promptoption { get; set; }

    public long? Response1 { get; set; }

    public long? Response2 { get; set; }

    public long? Response3 { get; set; }

    public long? Branch1 { get; set; }

    public long? Branch2 { get; set; }

    public long? Branch3 { get; set; }

    public long? Stepnotilist { get; set; }

    public long? Filenotilist { get; set; }

    public long? Errornotilist { get; set; }

    public long? Flags { get; set; }

    public long? Batchsourcetype { get; set; }

    public long? Batchsource { get; set; }

    public long? Statementnum { get; set; }

    public long? Pqueuenum { get; set; }

    public long? Statementflags { get; set; }

    public long? Distprocessnum { get; set; }

    public long? Distprintqueue { get; set; }

    public string? Userprompt { get; set; }

    public string? Alternatepath { get; set; }

    public string? Alternatefilename { get; set; }

    public string? Destpath { get; set; }

    public DateTime? Parsedate { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Starttime { get; set; }

    public long? Startnotilist { get; set; }

    public long? Printformatnum { get; set; }

    public long? Exportmgrnum { get; set; }
}
