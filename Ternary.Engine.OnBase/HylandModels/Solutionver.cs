using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Solutionver
{
    public long Solutionvernum { get; set; }

    public long? Solutioninfonum { get; set; }

    public long? Solutionversion { get; set; }

    public string? Solutiontitle { get; set; }

    public string? Solutiondesc { get; set; }

    public string? Versionlabel { get; set; }

    public DateTime? Datecreated { get; set; }

    public string? Companyname { get; set; }

    public string? Solutioncontactname { get; set; }

    public string? Solutioncontactemail { get; set; }

    public string? Solutioncontactphone { get; set; }

    public long? Itemnum { get; set; }

    public long? Flags { get; set; }
}
