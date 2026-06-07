using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stmtrecipient
{
    public long Recipientnum { get; set; }

    public string? Recipientname { get; set; }

    public long? Statementnum { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Faxnum { get; set; }

    public string? Email { get; set; }

    public long? Distributionflags { get; set; }

    public string? Idkeywords { get; set; }

    public long? Numbercopies { get; set; }

    public long? Stmtdelivinfonum { get; set; }

    public string? Emailcc1 { get; set; }

    public string? Emailcc2 { get; set; }

    public string? Faxnumcc1 { get; set; }

    public long? Deliverypriority { get; set; }

    public long? Deliverytimeframe { get; set; }

    public string? Pdfpassword { get; set; }

    public long? Institution { get; set; }

    public string? Greetingname { get; set; }

    public DateTime? Lastupdate { get; set; }

    public DateTime? Lastdistdate { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
