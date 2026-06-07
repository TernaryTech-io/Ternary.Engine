using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Regusersproduct
{
    public long Registernum { get; set; }

    public long Producttype { get; set; }

    public long? Numunits { get; set; }

    public long? Registerstamp { get; set; }

    public DateTime? Registerdate { get; set; }

    public string? Registerhash { get; set; }

    public long? Assignmenttype { get; set; }

    public long? Lastused { get; set; }
}
