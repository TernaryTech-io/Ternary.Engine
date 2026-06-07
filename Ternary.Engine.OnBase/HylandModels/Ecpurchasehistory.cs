using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecpurchasehistory
{
    public long? Ecstorenum { get; set; }

    public long Ecpurchasenum { get; set; }

    public string? Ectransactionid { get; set; }

    public long? Ecusernum { get; set; }

    public DateTime? Ecpurchasedate { get; set; }

    public decimal? Ecpurchaseamount { get; set; }

    public long? Ecpaymenttype { get; set; }

    public long? Cardtype { get; set; }

    public string? Last4digits { get; set; }

    public string? Expireson { get; set; }

    public long? Ecaccountnum { get; set; }

    public long? Postedtoextsys { get; set; }

    public long? Billingcycle { get; set; }

    public long? Isvoided { get; set; }

    public long? Isexpired { get; set; }

    public long? Isprocessing { get; set; }

    public string? Ecconfirmationid { get; set; }

    public string? Ecreceiptid { get; set; }
}
