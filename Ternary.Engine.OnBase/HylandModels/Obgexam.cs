using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obgexam
{
    public long Examnum { get; set; }

    public long? Chtnum { get; set; }

    public DateTime? Examdate { get; set; }

    public long? Examtypenum { get; set; }

    public string? Patientaccountnumber { get; set; }

    public long? Patientage { get; set; }

    public DateTime? Lmpdate { get; set; }

    public long? Lmpuncertain { get; set; }

    public long? Abortions { get; set; }

    public long? Fullterm { get; set; }

    public long? Preterm { get; set; }

    public long? Livingchildren { get; set; }

    public long? Ectopics { get; set; }

    public long? Gravidity { get; set; }

    public string? Interestingstudy { get; set; }

    public long? Finalized { get; set; }

    public DateTime? Finaldatetime { get; set; }

    public DateTime? Unfinaldatetime { get; set; }

    public long? Examstate { get; set; }

    public DateTime? Patientarrivaltime { get; set; }

    public DateTime? Examstarttime { get; set; }

    public DateTime? Readyforreviewtime { get; set; }

    public DateTime? Reviewstarttime { get; set; }

    public DateTime? Clinicaldatetime { get; set; }

    public DateTime? Editdatetime { get; set; }

    public long? Flags { get; set; }

    public long? Examvisitnumber { get; set; }

    public long? Obgynparity { get; set; }
}
