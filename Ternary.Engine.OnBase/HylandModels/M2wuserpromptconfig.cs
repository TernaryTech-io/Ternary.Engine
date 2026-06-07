using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wuserpromptconfig
{
    public long Userpromptnum { get; set; }

    public long? Datatypecode { get; set; }

    public string? Calendardefaulttext { get; set; }

    public string? Errormsg { get; set; }

    public string? Datavalidationexp { get; set; }

    public long? Minvalue { get; set; }

    public long? Maxvalue { get; set; }

    public long? Validationtypecode { get; set; }

    public string? Dateinputformat { get; set; }

    public DateTime? Dateinputmaxvalue { get; set; }

    public DateTime? Dateinputminvalue { get; set; }

    public string? Dictionaryname { get; set; }

    public string? Itemseperator { get; set; }

    public string? Formatstring { get; set; }

    public string? Promptlabel { get; set; }

    public string? Tooltip { get; set; }

    public long? Flags { get; set; }

    public long? Mwdictnum { get; set; }

    public long? Seqnum { get; set; }
}
