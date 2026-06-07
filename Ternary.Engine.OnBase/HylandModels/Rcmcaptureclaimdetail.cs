using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmcaptureclaimdetail
{
    public long Clmdetailitemnum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Claimitemnum { get; set; }

    public DateTime? Dateofservicebegin { get; set; }

    public DateTime? Dateofserviceend { get; set; }

    public string? Procedurecode { get; set; }

    public string? Proceduredescription { get; set; }

    public long? Unitcount { get; set; }

    public string? Explanationcode { get; set; }

    public string? Diagnosiscode { get; set; }

    public decimal? Billedamount { get; set; }

    public decimal? Discountamount { get; set; }

    public decimal? Allowedamount { get; set; }

    public decimal? Deductibleamount { get; set; }

    public decimal? Patientamount { get; set; }

    public decimal? Paidamount { get; set; }

    public decimal? Deniedamount { get; set; }

    public decimal? Coinsuranceamount { get; set; }

    public decimal? Copayamount { get; set; }

    public string? Modifierdata { get; set; }
}
