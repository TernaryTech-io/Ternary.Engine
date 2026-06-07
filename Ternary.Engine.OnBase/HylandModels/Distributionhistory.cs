using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Distributionhistory
{
    public long? Distributejobnum { get; set; }

    public long? Jobnum { get; set; }

    public long? Recipientnum { get; set; }

    public long? Jobtype { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Faxnum { get; set; }

    public string? Email { get; set; }

    public string? Emailcc1 { get; set; }

    public string? Emailcc2 { get; set; }

    public DateTime? Datesent { get; set; }

    public long? Itemnum { get; set; }

    public long? Attempt { get; set; }

    public long? Distributionflags { get; set; }

    public long? Deliveryinfonum { get; set; }

    public string? Pdfpassword { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
