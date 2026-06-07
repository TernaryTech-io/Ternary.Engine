using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Autopubschedule
{
    public long Schedordernum { get; set; }

    public string? Schedordername { get; set; }

    public long? Autopubordernum { get; set; }

    public long? Pubfrequency { get; set; }

    public long? Pubdelay { get; set; }

    public DateTime? Timeofday { get; set; }

    public long? Usernum { get; set; }

    public long? Numbercopies { get; set; }

    public long? Envelopenum { get; set; }

    public long? Institution { get; set; }

    public DateTime? Lastintervaldate { get; set; }

    public long? Flags { get; set; }

    public long? Bulkfileflags { get; set; }

    public long? Formatnum { get; set; }

    public string? Ftpserver { get; set; }

    public long? Ftpport { get; set; }

    public string? Ftpusername { get; set; }

    public string? Ftppassword { get; set; }

    public string? Ftpfilepath { get; set; }

    public long? Ftpflags { get; set; }

    public string? Preprocesspath { get; set; }

    public string? Preprocparams { get; set; }

    public long? Preprocreturn { get; set; }

    public long? Preprocreturnop { get; set; }

    public long? Ytdinitialmonth { get; set; }

    public string? Sitecode { get; set; }

    public string? Jobpassword { get; set; }

    public long? Defaultdate { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
