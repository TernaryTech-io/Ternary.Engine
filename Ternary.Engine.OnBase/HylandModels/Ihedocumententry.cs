using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihedocumententry
{
    public long Iheregistryobjnum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public string? Iheentryuuid { get; set; }

    public string? Iheuniqueid { get; set; }

    public string? Ihelogicalid { get; set; }

    public long? Iheversion { get; set; }

    public string? Ihepatientid { get; set; }

    public long? Ihedocavailability { get; set; }

    public long? Iheavailabilitystatus { get; set; }

    public long? Ihelimitedmetadata { get; set; }

    public long? Iheobjecttype { get; set; }

    public DateTime? Creationdate { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Stopdate { get; set; }

    public string? Iherepositoryuniqueid { get; set; }

    public string? Ihehash { get; set; }

    public long? Ihesize { get; set; }

    public long? Ihemimetypenum { get; set; }

    public long? Iheclasscodenum { get; set; }

    public long? Iheformatcodenum { get; set; }

    public long? Ihefacilitytypecodenum { get; set; }

    public long? Ihepracticecodenum { get; set; }

    public long? Ihetypecodenum { get; set; }

    public string? Ihelanguagecode { get; set; }

    public long? Flags { get; set; }
}
