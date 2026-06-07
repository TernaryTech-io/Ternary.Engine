using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmscreen
{
    public long Screenid { get; set; }

    public long? Classid { get; set; }

    public string? Displayname { get; set; }

    public long? Editorversion { get; set; }

    public string? Screenname { get; set; }

    public string? Screentitle { get; set; }

    public long? Showeformmenu { get; set; }

    public long? Showrevisions { get; set; }

    public long? Flags { get; set; }
}
