using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emrdocument
{
    public long Itemnum { get; set; }

    public string? Patientlast { get; set; }

    public string? Patientfirst { get; set; }

    public string? Patientmiddle { get; set; }

    public string? Patientid { get; set; }

    public string? Patientchart { get; set; }

    public DateTime? Patientdob { get; set; }

    public string? Patientssn { get; set; }

    public string? Providerlist { get; set; }

    public string? Carelocation { get; set; }

    public DateTime? Clinicdate { get; set; }

    public string? Doctypecomment { get; set; }

    public string? Gencomment { get; set; }

    public long? Archiveflags { get; set; }

    public long? Iscompleted { get; set; }

    public DateTime? Datecompleted { get; set; }

    public string? Completeorder { get; set; }
}
