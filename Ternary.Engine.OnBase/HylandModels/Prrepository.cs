using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Prrepository
{
    public long Repositorynum { get; set; }

    public string? Repositoryname { get; set; }

    public string? Repositorydesc { get; set; }

    public string? Repositoryrules { get; set; }

    public long? Allowrequest { get; set; }

    public long? Overduenotify { get; set; }

    public long? Checkoutlength { get; set; }

    public long? Checkouttype { get; set; }

    public long? Custodytype { get; set; }

    public long? Transferofcustody { get; set; }

    public long? Recheckoutbyself { get; set; }

    public long? Histcheckouts { get; set; }

    public long? Curcheckouts { get; set; }

    public long? Pendcheckouts { get; set; }

    public string? Uniqueidname { get; set; }

    public string? Contentsdescname { get; set; }

    public string? Locationdescname { get; set; }

    public string? Sublocation1name { get; set; }

    public string? Sublocation2name { get; set; }

    public string? Sublocation3name { get; set; }

    public string? Sublocation4name { get; set; }

    public long? Flags { get; set; }

    public long? Isoffsite { get; set; }

    public long? Pqueuenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Facilitynum { get; set; }
}
