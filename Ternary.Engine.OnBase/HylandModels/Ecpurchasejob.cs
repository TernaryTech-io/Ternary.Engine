using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecpurchasejob
{
    public long Ecpurchasejobnum { get; set; }

    public long? Ecpurchasenum { get; set; }

    public long? Ecusernum { get; set; }

    public long? Flags { get; set; }

    public string? Ecshiptoaddress1 { get; set; }

    public string? Ecshiptoaddress2 { get; set; }

    public string? Ecshiptoaddress3 { get; set; }

    public string? Ecshiptocity { get; set; }

    public string? Ecshiptostate { get; set; }

    public string? Ecshiptozipcode { get; set; }

    public string? Ecshiptocountry { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Processeddate { get; set; }

    public long? Processedbyusernum { get; set; }

    public long? Processedstatus { get; set; }

    public string? Usertrackingdata { get; set; }

    public string? Ecshiptofirstname { get; set; }

    public string? Ecshiptomiddlename { get; set; }

    public string? Ecshiptolastname { get; set; }

    public string? Ecshiptophone { get; set; }
}
