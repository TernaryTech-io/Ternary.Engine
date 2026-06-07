using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Readinggroup
{
    public long Readinggroupnum { get; set; }

    public string? Readinggroupname { get; set; }

    public string? Usagepolicy { get; set; }

    public string? Bannertext { get; set; }

    public string? Helptext { get; set; }

    public long? Allowdocdelete { get; set; }

    public long? Enabledocappr { get; set; }

    public long? Requestdocappr { get; set; }

    public long? Hideoldrevisions { get; set; }

    public string? Acknowledgetext { get; set; }

    public long? Viewauth { get; set; }

    public long? Viewallpages { get; set; }

    public long? Institution { get; set; }

    public long? Mustreadbydays { get; set; }

    public long? Notifybymail { get; set; }

    public long? Notifyrejected { get; set; }

    public long? Expirationdays { get; set; }

    public long? Digitalsignature { get; set; }

    public long? Enableexam { get; set; }

    public long? Allowrejection { get; set; }

    public long? Crgflags { get; set; }

    public long? Rejectionform { get; set; }
}
