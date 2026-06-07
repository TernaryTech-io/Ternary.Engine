using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ecuser
{
    public long Ecusernum { get; set; }

    public string? Ecusername { get; set; }

    public string? Ecuserpassword { get; set; }

    public string? Ecuserpasswordsalt { get; set; }

    public long? Ecauthversion { get; set; }

    public string? Ecresetpassword { get; set; }

    public long? Ecuserstatus { get; set; }

    public string? Ecemail { get; set; }

    public string? Ecsecurityhint { get; set; }

    public long? Isadmin { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Ecdefaultaccountnum { get; set; }

    public long? Ectimezone { get; set; }

    public string? Ecnamedisplay { get; set; }

    public string? Ecemaildisplay { get; set; }

    public long? Deleteditem { get; set; }

    public long? Ecuserapp { get; set; }

    public long? Ecextsrc { get; set; }

    public string? Ecextname { get; set; }
}
