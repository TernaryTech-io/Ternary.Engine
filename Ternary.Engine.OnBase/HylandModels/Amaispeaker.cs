using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Amaispeaker
{
    public long Amaispeakernum { get; set; }

    public long? Agendaitemnum { get; set; }

    public long? Amspeakernum { get; set; }

    public long? Ammemberrnum { get; set; }

    public long? Amremainingtime { get; set; }

    public long? Amelapsedtime { get; set; }

    public long? Amoriginaltime { get; set; }

    public DateTime? Amstarttime { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Seqnum { get; set; }

    public string? Amspeakernotes { get; set; }

    public long? Amspeakerposition { get; set; }

    public long? Flags { get; set; }
}
