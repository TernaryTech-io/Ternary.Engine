using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raraw835datum
{
    public long Raraw835datanum { get; set; }

    public string? Patientaccountnumber { get; set; }

    public DateTime? Datepaymentreceived { get; set; }

    public string? Claimnumber { get; set; }

    public decimal? Totalclaimamount { get; set; }

    public decimal? Amountpaidbymedicare { get; set; }

    public long? Claimstatuscode { get; set; }

    public string? Billtype { get; set; }

    public DateTime? Servicedate { get; set; }

    public DateTime? Patientdischargedate { get; set; }

    public string? Payertype { get; set; }

    public long? Raptbillingrecnum { get; set; }
}
