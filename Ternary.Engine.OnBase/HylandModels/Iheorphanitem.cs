using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iheorphanitem
{
    public long? Itemnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Eventtype { get; set; }

    public long? Status { get; set; }

    public DateTime? Lastfaileddate { get; set; }

    public long? Ihecommunitynum { get; set; }

    public long? Flags { get; set; }

    public long? Iheendpointnum { get; set; }

    public long Iheorphanitemnum { get; set; }
}
