using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mkplcase
{
    public long Mkplcasenum { get; set; }

    public string? Extquoteid { get; set; }

    public string? Accountid { get; set; }

    public string? Extcaseid { get; set; }

    public long? Mkplcasetype { get; set; }

    public decimal? Totalamount { get; set; }

    public decimal? Neededamount { get; set; }

    public long? Amounttype { get; set; }

    public string? Isocurrencyname { get; set; }

    public long? Status { get; set; }

    public DateTime? Createddate { get; set; }

    public DateTime? Datemodified { get; set; }

    public decimal? Casecost { get; set; }

    public long? Usernum { get; set; }

    public string? Casetitle { get; set; }
}
