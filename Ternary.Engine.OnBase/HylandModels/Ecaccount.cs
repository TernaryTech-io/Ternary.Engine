using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecaccount
{
    public long Ecaccountnum { get; set; }

    public string? Ecaccountname { get; set; }

    public long? Ecaccounttype { get; set; }

    public long? Paymentterms { get; set; }

    public string? Ecbilltoaddress1 { get; set; }

    public string? Ecbilltoaddress2 { get; set; }

    public string? Ecbilltoaddress3 { get; set; }

    public string? Ecbilltocity { get; set; }

    public string? Ecbilltostate { get; set; }

    public string? Ecbilltozipcode { get; set; }

    public string? Ecbilltocountry { get; set; }

    public string? Ecshiptoaddress1 { get; set; }

    public string? Ecshiptoaddress2 { get; set; }

    public string? Ecshiptoaddress3 { get; set; }

    public string? Ecshiptocity { get; set; }

    public string? Ecshiptostate { get; set; }

    public string? Ecshiptozipcode { get; set; }

    public string? Ecshiptocountry { get; set; }

    public long? Accountownernum { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Ecbilltofirstname { get; set; }

    public string? Ecbilltomiddlename { get; set; }

    public string? Ecbilltolastname { get; set; }

    public string? Ecbilltophone { get; set; }

    public string? Ecshiptofirstname { get; set; }

    public string? Ecshiptomiddlename { get; set; }

    public string? Ecshiptolastname { get; set; }

    public string? Ecshiptophone { get; set; }

    public long? Accesslvltypenum { get; set; }

    public long? Flags { get; set; }

    public string? Ecnamedisplay { get; set; }

    public long? Deleteditem { get; set; }
}
