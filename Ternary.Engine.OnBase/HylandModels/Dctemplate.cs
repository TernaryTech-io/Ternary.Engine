using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dctemplate
{
    public long Dctemplatenum { get; set; }

    public string? Dctemplatename { get; set; }

    public long? Itemnum { get; set; }

    public long? Destdoctypenum { get; set; }

    public long? Flags { get; set; }

    public long? Fontnum { get; set; }

    public long? Templatetype { get; set; }

    public long? Templatedisabled { get; set; }

    public string? Emailto { get; set; }

    public string? Emailfrom { get; set; }

    public string? Emailsubject { get; set; }

    public string? Mailmessagetext { get; set; }

    public long? Vbscriptnum { get; set; }

    public long? Testingsourcenum { get; set; }

    public long? Testingsourcetype { get; set; }

    public long? Maxfragmentid { get; set; }

    public long? Imageoptions { get; set; }

    public long? Obblobnum { get; set; }

    public long? Pdfoptions { get; set; }
}
