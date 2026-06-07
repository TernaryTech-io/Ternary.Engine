using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmview
{
    public long Viewid { get; set; }

    public string? Rmdescription { get; set; }

    public long? Editorversion { get; set; }

    public long? Screenid { get; set; }

    public long? Sequenceid { get; set; }

    public string? Stylesheetpath { get; set; }

    public string? Rmtitle { get; set; }

    public long? Parentviewid { get; set; }

    public long? Lcid { get; set; }

    public long? Stylesheetresourceid { get; set; }

    public DateTime? Lastmodified { get; set; }
}
