using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Completedchtdfcy
{
    public long Dfcynum { get; set; }

    public long? Dfcytype { get; set; }

    public string? Dfcymessage { get; set; }

    public long? Chtnum { get; set; }

    public long? Analystnum { get; set; }

    public DateTime? Dateadded { get; set; }

    public long? Physassignednum { get; set; }

    public long? Physcompletednum { get; set; }

    public DateTime? Completeddate { get; set; }

    public long? Reanalystnum { get; set; }

    public DateTime? Datereanalyzed { get; set; }

    public long? Delinqlevel { get; set; }

    public long? Resassignednum { get; set; }

    public long? Rescompletednum { get; set; }

    public DateTime? Resdecisiondate { get; set; }

    public long? Flags { get; set; }

    public long? Reviewstatus { get; set; }

    public long? Reviewusernum { get; set; }

    public DateTime? Reviewdate { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Stat { get; set; }

    public long? Jobid { get; set; }

    public string? Dictationjobid { get; set; }

    public long? Resubmitdfcynum { get; set; }
}
