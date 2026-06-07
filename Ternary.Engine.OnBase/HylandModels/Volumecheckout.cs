using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Volumecheckout
{
    public long Checkoutnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Checkedout { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public string? Vrrequestorname { get; set; }

    public long? Volumereqcodenum { get; set; }

    public DateTime? Expectreturndate { get; set; }

    public long? Checkoutusernum { get; set; }

    public long? Checkouthomeloc { get; set; }

    public DateTime? Datecheckedout { get; set; }

    public long? Unitnum { get; set; }

    public string? Chtdestlocation { get; set; }

    public long? Checkinusernum { get; set; }

    public long? Checkinhomeloc { get; set; }

    public DateTime? Datecheckedin { get; set; }

    public string? Delivinstructions { get; set; }

    public long? Printitemnum { get; set; }
}
