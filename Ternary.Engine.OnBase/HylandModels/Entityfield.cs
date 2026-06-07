using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityfield
{
    public long Entityfieldnum { get; set; }

    public long? Entitytypenum { get; set; }

    public long? Etdatatypecode { get; set; }

    public string? Etdisplayname { get; set; }

    public string? Etcolumnname { get; set; }

    public long? Etrelatedtypenum { get; set; }

    public long? Etlength { get; set; }

    public long? Isprimary { get; set; }

    public string? Etdescription { get; set; }

    public long? Dependentrelation { get; set; }

    public string? Etenumeration { get; set; }

    public string? Etdefaultvalue { get; set; }

    public long? Flags { get; set; }

    public long? Istransient { get; set; }

    public string? Etsource { get; set; }

    public string? Etmaxnumkey { get; set; }

    public long? Etusagetype { get; set; }

    public long? Etvisibility { get; set; }

    public long? Ettrackchanges { get; set; }

    public string? Etdatasetname { get; set; }

    public long? Etpublishedid { get; set; }

    public string? Etuiparameters { get; set; }

    public string? Etsourcespec { get; set; }

    public long? Etmaskvalue { get; set; }

    public long? Etshiftvalue { get; set; }

    public long? Etdisplayfiltertype { get; set; }

    public long? Etmodulevisibility { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
