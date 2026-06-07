using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ampublish
{
    public long Ampublishnum { get; set; }

    public long? Ammeetingnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Publishitemnum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Publishtype { get; set; }

    public long? Flags { get; set; }

    public long? Agendaitemnum { get; set; }

    public long? Docrevnum { get; set; }
}
