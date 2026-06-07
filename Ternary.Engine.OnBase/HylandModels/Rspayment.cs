using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rspayment
{
    public long Rsreceiptnum { get; set; }

    public string? Rsreceiptui { get; set; }

    public decimal? Amountdue { get; set; }

    public decimal? Balancedue { get; set; }

    public DateTime? Paymentdate { get; set; }

    public long? Usernum { get; set; }

    public decimal? Cashpayment { get; set; }

    public decimal? Checkpayment { get; set; }

    public decimal? Debitamount { get; set; }

    public decimal? Creditamount { get; set; }

    public decimal? Creditcardamount { get; set; }

    public string? Checknumber { get; set; }

    public long? Rsaccountnum { get; set; }

    public string? Cclastfourdigits { get; set; }

    public long? Recordernum { get; set; }

    public long? Paymentstatus { get; set; }
}
