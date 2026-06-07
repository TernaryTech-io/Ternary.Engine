using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rrjob
{
    public long Jobnum { get; set; }

    public DateTime? Datecompleted { get; set; }

    public DateTime? Daterequested { get; set; }

    public long? Fromcolumn { get; set; }

    public DateTime? Fromdate { get; set; }

    public string? Jobdescription { get; set; }

    public long? Jobqueuenum { get; set; }

    public long? Jobparams { get; set; }

    public long? Jobtype { get; set; }

    public long? Keycount { get; set; }

    public long? Printformatnum { get; set; }

    public long? Procstat { get; set; }

    public long? Statementnum { get; set; }

    public long? Tocolumn { get; set; }

    public DateTime? Todate { get; set; }

    public long? Usernum { get; set; }

    public long? Numbercopies { get; set; }

    public long? Registernum { get; set; }

    public long? Waitforjob { get; set; }

    public long? Filetypenum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Recipientnum { get; set; }

    public long? Distprocessnum { get; set; }

    public long? Stmtdelivinfonum { get; set; }

    public long? Jobqueuenum2 { get; set; }

    public string? Sitecode { get; set; }

    public string? Cdpassword { get; set; }

    public string? Jobdescription2 { get; set; }
}
