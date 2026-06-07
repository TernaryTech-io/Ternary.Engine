using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Licensetable
{
    public string Installid { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Companyname { get; set; }

    public string? Country { get; set; }

    public string? Customername { get; set; }

    public string? Customernumber { get; set; }

    public long? Dbpatchctrl { get; set; }

    public long? Dbusespaces { get; set; }

    public string? Dbversion { get; set; }

    public string? Dealername { get; set; }

    public string? Dealernum { get; set; }

    public long? Exepatchctrl { get; set; }

    public DateTime? Installdate { get; set; }

    public long? Licenseflag { get; set; }

    public long? Maxpasswordlen { get; set; }

    public long? Maxrefresh { get; set; }

    public long? Minpasswordlen { get; set; }

    public long? Minrefresh { get; set; }

    public string? Serialnum { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
