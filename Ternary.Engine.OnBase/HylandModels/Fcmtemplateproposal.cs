using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fcmtemplateproposal
{
    public long Fcproposalnum { get; set; }

    public long? Fctemplatenum { get; set; }

    public long? Fcdescriptionnum { get; set; }

    public long? Fccreatedby { get; set; }

    public DateTime? Fccreateddate { get; set; }

    public long? Fcproposalinfonum { get; set; }
}
